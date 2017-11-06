using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using EZ_Builder;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

/*
 ****************************************************************************
 * This whole project is intended to be used for educational purposes only. *
 ****************************************************************************
 */ 
namespace BingTextToSpeech
{
    /// <summary>
    /// This class manages the whole thing.
    /// It contains the basic code for an EZ-Builder plugin to work plus code based on the official sample at: https://github.com/Azure-Samples/Cognitive-Speech-TTS/blob/master/Samples-Http/CSharp/TTSProgram.cs
    /// </summary>
    public partial class MainForm : EZ_Builder.UCForms.FormPluginMaster
    {
        private string apiKey;
        public MainForm()
        {
            InitializeComponent();

            EZBManager.EZBs[0].SoundV4.OnStartPlaying += SoundV4_OnStartPlaying;
            EZBManager.EZBs[0].SoundV4.OnStopPlaying += SoundV4_OnStopPlaying;

            EZ_Builder.Scripting.VariableManager.SetVariable("$textToSpeak", "");
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            EZBManager.EZBs[0].SoundV4.OnStartPlaying -= SoundV4_OnStartPlaying;
            EZBManager.EZBs[0].SoundV4.OnStopPlaying -= SoundV4_OnStopPlaying;
        }

        /// Note that there's no option to stop playing if you are playing from the computer.
        /// In order to do that, we'd need a global variable with the SoundPlayer instance, and we don't want that.
        private void SoundV4_OnStopPlaying()
        {
            Invokers.SetText(playButton, "Play");
        }

        private void SoundV4_OnStartPlaying()
        {
            Invokers.SetText(playButton, "Stop");
        }

        /// 
        /// This method is called by EZ-Builder when it requests the configuration for your  plugin. 
        /// EZ-Builder will request the configuration when the control is created and when the project is saved.
        /// The data set in this configuration will be serialized and saved in the EZ-Builder user's project.
        /// Custom data may be stored in the STORAGE dictionary.
        /// 
        public override EZ_Builder.Config.Sub.PluginV1 GetConfiguration()
        {
            return base.GetConfiguration();
        }

        /// 
        /// This method is called by EZ-Builder when a project is loaded or when the control is added to a project.
        /// Set your default data in here!
        /// The configuration from the user's project file will be set using this method.
        /// *Note: The  plugin must call Base.SetConfiguration(cf) in your override. See the example!
        /// Also note that this is a good place to ensure all required configuration data exists.
        /// In the case of a newer version of your  plugin where different configuration data may be required outside of the users configuration file, set it here.
        /// 
        public override void SetConfiguration(EZ_Builder.Config.Sub.PluginV1 cf)
        {
            cf.STORAGE.AddIfNotExist(ConfigurationDictionary.COMPRESSED_AUDIO_DATA, new byte[] { });
            cf.STORAGE.AddIfNotExist(ConfigurationDictionary.PLAY_THROUGH_EZB, true);
            cf.STORAGE.AddIfNotExist(ConfigurationDictionary.VOICE, "Microsoft Server Speech Text to Speech Voice (en-US, BenjaminRUS)");
            cf.STORAGE.AddIfNotExist(ConfigurationDictionary.ADVANCED_OPTIONS, false);

            base.SetConfiguration(cf);

            updateCommonConfig();
        }

        /// 
        /// This method is called by EZ-Builder when another control sends a command to this control using the EZ-Script  ControlCommand() function.
        /// The available  ControlCommand() functions for this control should be returned in the GetSupportedControlCommandsMethodsForSlave() override.
        /// 
        public override void SendCommand(string windowCommand, params string[] values)
        {
            if (windowCommand.Equals(ControlCommands.StartPlayingAudio, StringComparison.InvariantCultureIgnoreCase)) {
                if (values.Length == 1)
                    EZ_Builder.Scripting.VariableManager.SetVariable("$textToSpeak", values[0]);
                else if (values.Length > 1)
                    throw new Exception(string.Format("Only 0 or 1 parameters expected. You passed {0}", values.Length));

                playAudio();
        } else if (windowCommand.Equals(ControlCommands.StopPlayingAudio, StringComparison.InvariantCultureIgnoreCase))
                stopPlaying();
            else
                base.SendCommand(windowCommand, values);
        }

        /// 
        /// This method is called by EZ-Builder for the  Cheat Sheet to receive all available  ControlCommand() syntax for this control.
        /// When the  ControlCommand() is called for this function, see the SendCommand() override.
        /// 
        public override object[] GetSupportedControlCommands()
        {
            List<string> items = new List<string>();

            items.Add(ControlCommands.StartPlayingAudio);
            items.Add(ControlCommands.StartPlayingAudio + ", [text]");
            items.Add(ControlCommands.StopPlayingAudio);

            return items.ToArray();
        }

        void stopPlaying()
        {
            EZBManager.EZBs[0].SoundV4.Stop();
        }

        void playAudio()
        {
            ThreadStart threadDelegate = new ThreadStart(sendSpeakRequest);
            Thread speakRequestThread = new Thread(threadDelegate);
            speakRequestThread.Start();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            EZ_Builder.Scripting.VariableManager.SetVariable("$textToSpeak", textToSpeakTextBox.Text);
            playAudio();
        }

        private void sendSpeakRequest()
        {
            string accessToken;

            // Note: The way to get api key:
            // Free: https://www.microsoft.com/cognitive-services/en-us/subscriptions?productId=/products/Bing.Speech.Preview
            // Paid: https://portal.azure.com/#create/Microsoft.CognitiveServices/apitype/Bing.Speech/pricingtier/S0
            Authentication auth = new Authentication(apiKey);

            try
            {
                accessToken = auth.GetAccessToken();
                //EZBManager.Log("Token: {0}\n", accessToken);
            }
            catch (Exception ex)
            {
                EZBManager.Log("Failed authentication.");
                EZBManager.Log(ex.ToString());
                EZBManager.Log(ex.Message);
                return;
            }

            string requestUri = "https://speech.platform.bing.com/synthesize";

            var speaker = new Synthesize();

            speaker.OnAudioAvailable += PlayAudio;
            speaker.OnError += ErrorHandler;
            
            Task task = speaker.Speak(CancellationToken.None, new Synthesize.InputOptions()
            {
                RequestUri = new Uri(requestUri),

                Text = EZ_Builder.Scripting.VariableManager.GetVariable("$textToSpeak"),

                VoiceName = Convert.ToString(_cf.STORAGE[ConfigurationDictionary.VOICE]),

                OutputFormat = AudioOutputFormat.Riff16Khz16BitMonoPcm,
                AuthorizationToken = "Bearer " + accessToken,
            });
            task.Wait();
        }

        private void ErrorHandler(object sender, GenericEventArgs<Exception> e)
        {
            EZBManager.Log("Unable to complete the TTS request: [{0}]", e.ToString());
        }

        private void PlayAudio(object sender, GenericEventArgs<Stream> args)
        {
            if (Convert.ToBoolean(_cf.STORAGE[ConfigurationDictionary.PLAY_THROUGH_EZB]))
            {
                using (var memoryStream = new MemoryStream())
                {
                    args.EventData.CopyTo(memoryStream);
                    memoryStream.Position = 0;

                    try
                    {
                        using (NAudio.Wave.WaveStream wav = new NAudio.Wave.WaveFileReader(memoryStream))
                        {
                            using (NAudio.Wave.WaveFormatConversionStream pcm = new NAudio.Wave.WaveFormatConversionStream(new NAudio.Wave.WaveFormat(EZ_B.EZBv4Sound.AUDIO_SAMPLE_BITRATE, 8, 1), wav))
                            {
                                if (EZBManager.EZBs[0].SoundV4.IsPlaying)
                                    stopPlaying();
                                else
                                    EZBManager.EZBs[0].SoundV4.PlayData(pcm);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        EZBManager.Log("Error: " + ex.Message);
                        EZBManager.Log("StackTrace: " + ex.StackTrace);
                    }
                }
            }
            else
            {
                SoundPlayer player = new SoundPlayer(args.EventData);
                player.PlaySync();
            }

            args.EventData.Dispose();
        }

        private void updateCommonConfig()
        {
            string localConfigFile = EZ_Builder.Common.CombinePath(EZ_Builder.Constants.PLUGINS_FOLDER, _cf._pluginGUID, "LocalApiKey.cfg");
            FileInfo apiFile = new FileInfo(localConfigFile);
            if (apiFile.Exists && apiFile.Length > 0) apiKey = Convert.ToString(File.ReadAllLines(localConfigFile).GetValue(0));

            groupBox1.Visible = Convert.ToBoolean(_cf.STORAGE[ConfigurationDictionary.ADVANCED_OPTIONS]);
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textToSpeakTextBox.Text.Replace("\"", "\\\""));
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            textToSpeakTextBox.Clear();
            EZ_Builder.Scripting.VariableManager.SetVariable("$textToSpeak", "");
        }

        private void configurationButton_Click(object sender, EventArgs e)
        {
            using (FormConfig formConfig = new FormConfig(_cf))
            {

                if (formConfig.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                _cf = formConfig.GetConfiguration;

                updateCommonConfig();
            }
        }

        //The next methods manipulate strings following the documentation at https://docs.microsoft.com/en-us/azure/cognitive-services/speech/api-reference-rest/bingvoiceoutput#ChangeSSML
        private void addBreakButton_Click(object sender, EventArgs e)
        {
            int position = textToSpeakTextBox.SelectionStart;
            string text = textToSpeakTextBox.Text;
            string textToInsert = position > 0 ? "<break time=\"" : "\"<break time=\"";

            textToSpeakTextBox.Text = text.Insert(position, textToInsert + breakTextBox.Text.Trim() + "ms\"/>\"");
            textToSpeakTextBox.Select();
        }

        private void changeSpeakingRateButton_Click(object sender, EventArgs e)
        {
            int initialPosition = textToSpeakTextBox.SelectionStart;
            int finalPosition = initialPosition + textToSpeakTextBox.SelectionLength;
            string text = textToSpeakTextBox.Text;
            string textToInsert = finalPosition != text.Length ? "\"</prosody>\"" : "\"</prosody>";

            string finalText = text.Insert(finalPosition, textToInsert);
            textToInsert = initialPosition > 0 ? "\"<prosody rate=\"" : "<prosody rate=\"";
            finalText = finalText.Insert(initialPosition, textToInsert + speakingRateTextBox.Text.Trim() +"%\">\"");

            textToSpeakTextBox.Text = finalText;
            textToSpeakTextBox.Select();
        }

        private void changeVolumeButton_Click(object sender, EventArgs e)
        {
            int initialPosition = textToSpeakTextBox.SelectionStart;
            int finalPosition = initialPosition + textToSpeakTextBox.SelectionLength;
            string text = textToSpeakTextBox.Text;
            string textToInsert = finalPosition != text.Length ? "\"</prosody>\"" : "\"</prosody>";

            string finalText = text.Insert(finalPosition, textToInsert);
            textToInsert = initialPosition > 0 ? "\"<prosody volume=\"" : "<prosody volume=\"";
            finalText = finalText.Insert(initialPosition, textToInsert + volumeTextBox.Text.Trim() + "%\">\"");

            textToSpeakTextBox.Text = finalText;
            textToSpeakTextBox.Select();
        }

        private void changePitchButton_Click(object sender, EventArgs e)
        {
            int initialPosition = textToSpeakTextBox.SelectionStart;
            int finalPosition = initialPosition + textToSpeakTextBox.SelectionLength;
            string text = textToSpeakTextBox.Text;
            string textToInsert = finalPosition != text.Length ? "\"</prosody>\"" : "\"</prosody>";

            string finalText = text.Insert(finalPosition, textToInsert);
            textToInsert = initialPosition > 0 ? "\"<prosody pitch=\"" : "<prosody pitch=\"";
            finalText = finalText.Insert(initialPosition, textToInsert + pitchComboBox.Text.Trim().ToLower() + "\">\"");

            textToSpeakTextBox.Text = finalText;
            textToSpeakTextBox.Select();
        }
    }
}
