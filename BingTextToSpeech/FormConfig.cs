using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZ_Builder;

namespace BingTextToSpeech
{
    public partial class FormConfig : Form
    {

        EZ_Builder.Config.Sub.PluginV1 _cf;

        public EZ_Builder.Config.Sub.PluginV1 GetConfiguration
        {
            get
            {
                return _cf;
            }
        }

        public FormConfig(EZ_Builder.Config.Sub.PluginV1 cf)
        {
            InitializeComponent();

            _cf = cf;
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            string localConfigFile = EZ_Builder.Common.CombinePath(EZ_Builder.Constants.PLUGINS_FOLDER, _cf._pluginGUID, "LocalApiKey.cfg");

            FileInfo apiFile = new FileInfo(localConfigFile);
            if (apiFile.Exists && apiFile.Length > 0) keyTextBox.Text = Convert.ToString(File.ReadAllLines(localConfigFile).GetValue(0));

            if (Convert.ToBoolean(_cf.STORAGE[ConfigurationDictionary.PLAY_THROUGH_EZB]))
            {
                radioButton1.Checked = true;
            } else
            {
                radioButton2.Checked = true;
            }

            Dictionary<string, string> voices = getVoicesDictionary();

            comboBox1.Text = voices.FirstOrDefault(x => x.Value == Convert.ToString(_cf.STORAGE[ConfigurationDictionary.VOICE])).Key;
            checkBox1.Checked = Convert.ToBoolean(_cf.STORAGE[ConfigurationDictionary.ADVANCED_OPTIONS]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> voices = getVoicesDictionary();
            string localConfigFile = EZ_Builder.Common.CombinePath(EZ_Builder.Constants.PLUGINS_FOLDER, _cf._pluginGUID, "LocalApiKey.cfg");

            string[] config = new string[1];
            config[0] = keyTextBox.Text;
            File.WriteAllLines(localConfigFile, config);
            
            string chosenVoiceFromDictionary;
            voices.TryGetValue(comboBox1.Text, out chosenVoiceFromDictionary);

            _cf.STORAGE.AddOrUpdate(ConfigurationDictionary.VOICE, chosenVoiceFromDictionary);
            _cf.STORAGE.AddOrUpdate(ConfigurationDictionary.PLAY_THROUGH_EZB, radioButton1.Checked);

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _cf.STORAGE.AddOrUpdate(ConfigurationDictionary.ADVANCED_OPTIONS, checkBox1.Checked);
        }

        private Dictionary<string, string> getVoicesDictionary()
        {
            return new Dictionary<string, string>
            {
                {"ar-EG, Female, Hoda", "Microsoft Server Speech Text to Speech Voice (ar-EG, Hoda)"},
                {"ar-SA, Male, Naayf",  "Microsoft Server Speech Text to Speech Voice (ar-SA, Naayf)"},
                {"ca-ES, Female, HerenaRUS",    "Microsoft Server Speech Text to Speech Voice (ca-ES, HerenaRUS)"},
                {"cs-CZ, Male, Vit",    "Microsoft Server Speech Text to Speech Voice (cs-CZ, Vit)"},
                {"da-DK, Female, HelleRUS", "Microsoft Server Speech Text to Speech Voice (da-DK, HelleRUS)"},
                {"de-AT, Male, Michael",    "Microsoft Server Speech Text to Speech Voice (de-AT, Michael)"},
                {"de-CH, Male, Karsten",    "Microsoft Server Speech Text to Speech Voice (de-CH, Karsten)"},
                {"de-DE, Female, Hedda",    "Microsoft Server Speech Text to Speech Voice (de-DE, Hedda) "},
                {"de-DE, Female, HeddaRUS", "Microsoft Server Speech Text to Speech Voice (de-DE, HeddaRUS)"},
                {"de-DE, Male, Stefan, Apollo", "Microsoft Server Speech Text to Speech Voice (de-DE, Stefan, Apollo)"},
                {"el-GR, Male, Stefanos",   "Microsoft Server Speech Text to Speech Voice (el-GR, Stefanos)"},
                {"en-AU, Female, Catherine",    "Microsoft Server Speech Text to Speech Voice (en-AU, Catherine) "},
                {"en-AU, Female, HayleyRUS",    "Microsoft Server Speech Text to Speech Voice (en-AU, HayleyRUS)"},
                {"en-CA, Female, Linda",    "Microsoft Server Speech Text to Speech Voice (en-CA, Linda)"},
                {"en-CA, Female, HeatherRUS",   "Microsoft Server Speech Text to Speech Voice (en-CA, HeatherRUS)"},
                {"en-GB, Female, Susan, Apollo",    "Microsoft Server Speech Text to Speech Voice (en-GB, Susan, Apollo)"},
                {"en-GB, Female, HazelRUS", "Microsoft Server Speech Text to Speech Voice (en-GB, HazelRUS)"},
                {"en-GB, Male, Apollo", "Microsoft Server Speech Text to Speech Voice (en-GB, George, Apollo)"},
                {"en-IE, Male, Shaun",  "Microsoft Server Speech Text to Speech Voice (en-IE, Shaun)"},
                {"en-IN, Female, Heera, Apollo",    "Microsoft Server Speech Text to Speech Voice (en-IN, Heera, Apollo)"},
                {"en-IN, Female, PriyaRUS", "Microsoft Server Speech Text to Speech Voice (en-IN, PriyaRUS)"},
                {"en-IN, Male, Ravi, Apollo",   "Microsoft Server Speech Text to Speech Voice (en-IN, Ravi, Apollo) "},
                {"en-US, Female, ZiraRUS",  "Microsoft Server Speech Text to Speech Voice (en-US, ZiraRUS)"},
                {"en-US, Female, JessaRUS", "Microsoft Server Speech Text to Speech Voice (en-US, JessaRUS)"},
                {"en-US, Male, BenjaminRUS",    "Microsoft Server Speech Text to Speech Voice (en-US, BenjaminRUS)"},
                {"es-ES, Female, Laura, Apollo",    "Microsoft Server Speech Text to Speech Voice (es-ES, Laura, Apollo)"},
                {"es-ES, Female, HelenaRUS",    "Microsoft Server Speech Text to Speech Voice (es-ES, HelenaRUS)"},
                {"es-ES, Male, Pablo, Apollo",  "Microsoft Server Speech Text to Speech Voice (es-ES, Pablo, Apollo)"},
                {"es-MX, Female, HildaRUS", "Microsoft Server Speech Text to Speech Voice (es-MX, HildaRUS)"},
                {"es-MX, Male, Raul, Apollo",   "Microsoft Server Speech Text to Speech Voice (es-MX, Raul, Apollo)"},
                {"fi-FI, Female, HeidiRUS", "Microsoft Server Speech Text to Speech Voice (fi-FI, HeidiRUS)"},
                {"fr-CA, Female, Caroline", "Microsoft Server Speech Text to Speech Voice (fr-CA, Caroline)"},
                {"fr-CA, Female, HarmonieRUS",  "Microsoft Server Speech Text to Speech Voice (fr-CA, HarmonieRUS)"},
                {"fr-CH, Male, Guillaume",  "Microsoft Server Speech Text to Speech Voice (fr-CH, Guillaume)"},
                {"fr-FR, Female, Julie, Apollo",    "Microsoft Server Speech Text to Speech Voice (fr-FR, Julie, Apollo)"},
                {"fr-FR, Female, HortenseRUS",  "Microsoft Server Speech Text to Speech Voice (fr-FR, HortenseRUS)"},
                {"fr-FR, Male, Apollo", "Microsoft Server Speech Text to Speech Voice (fr-FR, Paul, Apollo)"},
                {"he-IL, Male, Asaf",   "Microsoft Server Speech Text to Speech Voice (he-IL, Asaf)"},
                {"hi-IN, Female, Kalpana, Apollo",  "Microsoft Server Speech Text to Speech Voice (hi-IN, Kalpana, Apollo)"},
                {"hi-IN, Female, Kalpana",  "Microsoft Server Speech Text to Speech Voice (hi-IN, Kalpana)"},
                {"hi-IN, Male, Hemant", "Microsoft Server Speech Text to Speech Voice (hi-IN, Hemant)"},
                {"hu-HU, Male, Szabolcs",   "Microsoft Server Speech Text to Speech Voice (hu-HU, Szabolcs)"},
                {"id-ID, Male, Andika", "Microsoft Server Speech Text to Speech Voice (id-ID, Andika)"},
                {"it-IT, Male, Cosimo, Apollo", "Microsoft Server Speech Text to Speech Voice (it-IT, Cosimo, Apollo)"},
                {"ja-JP, Female, Ayumi, Apollo",    "Microsoft Server Speech Text to Speech Voice (ja-JP, Ayumi, Apollo)"},
                {"ja-JP, Male, Apollo", "Microsoft Server Speech Text to Speech Voice (ja-JP, Ichiro, Apollo)"},
                {"ja-JP, Female, HarukaRUS",    "Microsoft Server Speech Text to Speech Voice (ja-JP, HarukaRUS)"},
                {"ja-JP, Female, LuciaRUS", "Microsoft Server Speech Text to Speech Voice (ja-JP, LuciaRUS)"},
                {"ja-JP, Male, EkaterinaRUS",   "Microsoft Server Speech Text to Speech Voice (ja-JP, EkaterinaRUS)"},
                {"ko-KR, Female, HeamiRUS", "Microsoft Server Speech Text to Speech Voice (ko-KR, HeamiRUS)"},
                {"nb-NO, Female, HuldaRUS", "Microsoft Server Speech Text to Speech Voice (nb-NO, HuldaRUS)"},
                {"nl-NL, Female, HannaRUS", "Microsoft Server Speech Text to Speech Voice (nl-NL, HannaRUS)"},
                {"pl-PL, Female, PaulinaRUS",   "Microsoft Server Speech Text to Speech Voice (pl-PL, PaulinaRUS)"},
                {"pt-BR, Female, HeloisaRUS",   "Microsoft Server Speech Text to Speech Voice (pt-BR, HeloisaRUS)"},
                {"pt-BR, Male, Daniel, Apollo", "Microsoft Server Speech Text to Speech Voice (pt-BR, Daniel, Apollo)"},
                {"pt-PT, Female, HeliaRUS", "Microsoft Server Speech Text to Speech Voice (pt-PT, HeliaRUS)"},
                {"ro-RO, Male, Andrei", "Microsoft Server Speech Text to Speech Voice (ro-RO, Andrei)"},
                {"ru-RU, Female, Irina, Apollo",    "Microsoft Server Speech Text to Speech Voice (ru-RU, Irina, Apollo)"},
                {"ru-RU, Male, Pavel, Apollo",  "Microsoft Server Speech Text to Speech Voice (ru-RU, Pavel, Apollo)"},
                {"sk-SK, Male, Filip",  "Microsoft Server Speech Text to Speech Voice (sk-SK, Filip)"},
                {"sv-SE, Female, HedvigRUS",    "Microsoft Server Speech Text to Speech Voice (sv-SE, HedvigRUS)"},
                {"th-TH, Male, Pattara",    "Microsoft Server Speech Text to Speech Voice (th-TH, Pattara)"},
                {"tr-TR, Female, SedaRUS",  "Microsoft Server Speech Text to Speech Voice (tr-TR, SedaRUS)"},
                {"zh-CN, Female, HuihuiRUS",    "Microsoft Server Speech Text to Speech Voice (zh-CN, HuihuiRUS)"},
                {"zh-CN, Female, Yaoyao, Apollo",   "Microsoft Server Speech Text to Speech Voice (zh-CN, Yaoyao, Apollo)"},
                {"zh-CN, Male, Kangkang, Apollo",   "Microsoft Server Speech Text to Speech Voice (zh-CN, Kangkang, Apollo)"},
                {"zh-HK, Female, Tracy, Apollo",    "Microsoft Server Speech Text to Speech Voice (zh-HK, Tracy, Apollo)"},
                {"zh-HK, Female, TracyRUS", "Microsoft Server Speech Text to Speech Voice (zh-HK, TracyRUS)"},
                {"zh-HK, Male, Danny, Apollo",  "Microsoft Server Speech Text to Speech Voice (zh-HK, Danny, Apollo)"},
                {"zh-TW, Female, Yating, Apollo",   "Microsoft Server Speech Text to Speech Voice (zh-TW, Yating, Apollo)"},
                {"zh-TW, Female, HanHanRUS",    "Microsoft Server Speech Text to Speech Voice (zh-TW, HanHanRUS)"},
                {"zh-TW, Male, Zhiwei, Apollo", "Microsoft Server Speech Text to Speech Voice (zh-TW, Zhiwei, Apollo)"}
            };
        }
    }
}
