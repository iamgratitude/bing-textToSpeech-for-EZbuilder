namespace BingTextToSpeech
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textToSpeakTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.configurationButton = new EZ_Builder.UCForms.UC.UCConfigurationButton();
            this.breakTextBox = new System.Windows.Forms.TextBox();
            this.speakingRateTextBox = new System.Windows.Forms.TextBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.addBreakButton = new System.Windows.Forms.Button();
            this.changeSpeakingRateButton = new System.Windows.Forms.Button();
            this.changeVolumeButton = new System.Windows.Forms.Button();
            this.changePitchButton = new System.Windows.Forms.Button();
            this.pitchComboBox = new System.Windows.Forms.ComboBox();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucHelpHover4 = new EZ_Builder.UCForms.UC.UCHelpHover();
            this.ucHelpHover3 = new EZ_Builder.UCForms.UC.UCHelpHover();
            this.ucHelpHover2 = new EZ_Builder.UCForms.UC.UCHelpHover();
            this.ucHelpHover1 = new EZ_Builder.UCForms.UC.UCHelpHover();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textToSpeakTextBox
            // 
            this.textToSpeakTextBox.Location = new System.Drawing.Point(9, 60);
            this.textToSpeakTextBox.Multiline = true;
            this.textToSpeakTextBox.Name = "textToSpeakTextBox";
            this.textToSpeakTextBox.Size = new System.Drawing.Size(294, 61);
            this.textToSpeakTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to speak:";
            // 
            // playButton
            // 
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(98, 141);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(114, 38);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // configurationButton
            // 
            this.configurationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configurationButton.Image = ((System.Drawing.Image)(resources.GetObject("configurationButton.Image")));
            this.configurationButton.Location = new System.Drawing.Point(12, 12);
            this.configurationButton.Name = "configurationButton";
            this.configurationButton.Size = new System.Drawing.Size(30, 31);
            this.configurationButton.TabIndex = 3;
            this.configurationButton.UseVisualStyleBackColor = true;
            this.configurationButton.Click += new System.EventHandler(this.configurationButton_Click);
            // 
            // breakTextBox
            // 
            this.breakTextBox.Location = new System.Drawing.Point(17, 19);
            this.breakTextBox.Name = "breakTextBox";
            this.breakTextBox.Size = new System.Drawing.Size(100, 20);
            this.breakTextBox.TabIndex = 4;
            this.breakTextBox.Text = "100";
            // 
            // speakingRateTextBox
            // 
            this.speakingRateTextBox.Location = new System.Drawing.Point(17, 60);
            this.speakingRateTextBox.Name = "speakingRateTextBox";
            this.speakingRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.speakingRateTextBox.TabIndex = 5;
            this.speakingRateTextBox.Text = "+50.00";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(17, 100);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.volumeTextBox.TabIndex = 6;
            this.volumeTextBox.Text = "-50.00";
            // 
            // addBreakButton
            // 
            this.addBreakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBreakButton.Location = new System.Drawing.Point(132, 14);
            this.addBreakButton.Name = "addBreakButton";
            this.addBreakButton.Size = new System.Drawing.Size(129, 28);
            this.addBreakButton.TabIndex = 8;
            this.addBreakButton.Text = "Add break";
            this.addBreakButton.UseVisualStyleBackColor = true;
            this.addBreakButton.Click += new System.EventHandler(this.addBreakButton_Click);
            // 
            // changeSpeakingRateButton
            // 
            this.changeSpeakingRateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSpeakingRateButton.Location = new System.Drawing.Point(132, 55);
            this.changeSpeakingRateButton.Name = "changeSpeakingRateButton";
            this.changeSpeakingRateButton.Size = new System.Drawing.Size(129, 28);
            this.changeSpeakingRateButton.TabIndex = 9;
            this.changeSpeakingRateButton.Text = "Change speaking rate";
            this.changeSpeakingRateButton.UseVisualStyleBackColor = true;
            this.changeSpeakingRateButton.Click += new System.EventHandler(this.changeSpeakingRateButton_Click);
            // 
            // changeVolumeButton
            // 
            this.changeVolumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeVolumeButton.Location = new System.Drawing.Point(132, 95);
            this.changeVolumeButton.Name = "changeVolumeButton";
            this.changeVolumeButton.Size = new System.Drawing.Size(129, 28);
            this.changeVolumeButton.TabIndex = 10;
            this.changeVolumeButton.Text = "Change volume";
            this.changeVolumeButton.UseVisualStyleBackColor = true;
            this.changeVolumeButton.Click += new System.EventHandler(this.changeVolumeButton_Click);
            // 
            // changePitchButton
            // 
            this.changePitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePitchButton.Location = new System.Drawing.Point(132, 133);
            this.changePitchButton.Name = "changePitchButton";
            this.changePitchButton.Size = new System.Drawing.Size(129, 28);
            this.changePitchButton.TabIndex = 11;
            this.changePitchButton.Text = "Change pitch";
            this.changePitchButton.UseVisualStyleBackColor = true;
            this.changePitchButton.Click += new System.EventHandler(this.changePitchButton_Click);
            // 
            // pitchComboBox
            // 
            this.pitchComboBox.FormattingEnabled = true;
            this.pitchComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.pitchComboBox.Location = new System.Drawing.Point(17, 138);
            this.pitchComboBox.Name = "pitchComboBox";
            this.pitchComboBox.Size = new System.Drawing.Size(100, 21);
            this.pitchComboBox.TabIndex = 12;
            this.pitchComboBox.Text = "High";
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyToClipboardButton.Location = new System.Drawing.Point(204, 192);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(99, 29);
            this.copyToClipboardButton.TabIndex = 13;
            this.copyToClipboardButton.Text = "Copy to clipboard";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // clearTextButton
            // 
            this.clearTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTextButton.Location = new System.Drawing.Point(12, 192);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(99, 29);
            this.clearTextButton.TabIndex = 14;
            this.clearTextButton.Text = "Clear";
            this.clearTextButton.UseVisualStyleBackColor = true;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucHelpHover4);
            this.groupBox1.Controls.Add(this.ucHelpHover3);
            this.groupBox1.Controls.Add(this.ucHelpHover2);
            this.groupBox1.Controls.Add(this.ucHelpHover1);
            this.groupBox1.Controls.Add(this.breakTextBox);
            this.groupBox1.Controls.Add(this.speakingRateTextBox);
            this.groupBox1.Controls.Add(this.volumeTextBox);
            this.groupBox1.Controls.Add(this.pitchComboBox);
            this.groupBox1.Controls.Add(this.addBreakButton);
            this.groupBox1.Controls.Add(this.changePitchButton);
            this.groupBox1.Controls.Add(this.changeSpeakingRateButton);
            this.groupBox1.Controls.Add(this.changeVolumeButton);
            this.groupBox1.Location = new System.Drawing.Point(336, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 174);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced Voice Options";
            this.groupBox1.Visible = false;
            // 
            // ucHelpHover4
            // 
            this.ucHelpHover4.Location = new System.Drawing.Point(274, 138);
            this.ucHelpHover4.Margin = new System.Windows.Forms.Padding(0);
            this.ucHelpHover4.Name = "ucHelpHover4";
            this.ucHelpHover4.SetHelpText = resources.GetString("ucHelpHover4.SetHelpText");
            this.ucHelpHover4.Size = new System.Drawing.Size(20, 20);
            this.ucHelpHover4.TabIndex = 19;
            // 
            // ucHelpHover3
            // 
            this.ucHelpHover3.Location = new System.Drawing.Point(274, 100);
            this.ucHelpHover3.Margin = new System.Windows.Forms.Padding(0);
            this.ucHelpHover3.Name = "ucHelpHover3";
            this.ucHelpHover3.SetHelpText = resources.GetString("ucHelpHover3.SetHelpText");
            this.ucHelpHover3.Size = new System.Drawing.Size(20, 20);
            this.ucHelpHover3.TabIndex = 18;
            // 
            // ucHelpHover2
            // 
            this.ucHelpHover2.Location = new System.Drawing.Point(274, 60);
            this.ucHelpHover2.Margin = new System.Windows.Forms.Padding(0);
            this.ucHelpHover2.Name = "ucHelpHover2";
            this.ucHelpHover2.SetHelpText = resources.GetString("ucHelpHover2.SetHelpText");
            this.ucHelpHover2.Size = new System.Drawing.Size(20, 20);
            this.ucHelpHover2.TabIndex = 17;
            // 
            // ucHelpHover1
            // 
            this.ucHelpHover1.Location = new System.Drawing.Point(274, 16);
            this.ucHelpHover1.Margin = new System.Windows.Forms.Padding(0);
            this.ucHelpHover1.Name = "ucHelpHover1";
            this.ucHelpHover1.SetHelpText = "Add a break (in milliseconds) before the current cursor position or selection.";
            this.ucHelpHover1.Size = new System.Drawing.Size(20, 20);
            this.ucHelpHover1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(681, 248);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearTextButton);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.configurationButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textToSpeakTextBox);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Text = "Bing Text to Speech";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textToSpeakTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
        private EZ_Builder.UCForms.UC.UCConfigurationButton configurationButton;
        private System.Windows.Forms.TextBox breakTextBox;
        private System.Windows.Forms.TextBox speakingRateTextBox;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Button addBreakButton;
        private System.Windows.Forms.Button changeSpeakingRateButton;
        private System.Windows.Forms.Button changeVolumeButton;
        private System.Windows.Forms.Button changePitchButton;
        private System.Windows.Forms.ComboBox pitchComboBox;
        private System.Windows.Forms.Button copyToClipboardButton;
        private System.Windows.Forms.Button clearTextButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private EZ_Builder.UCForms.UC.UCHelpHover ucHelpHover4;
        private EZ_Builder.UCForms.UC.UCHelpHover ucHelpHover3;
        private EZ_Builder.UCForms.UC.UCHelpHover ucHelpHover2;
        private EZ_Builder.UCForms.UC.UCHelpHover ucHelpHover1;
    }
}