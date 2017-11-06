namespace BingTextToSpeech
{
    partial class FormConfig
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
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ucHelpHover1 = new EZ_Builder.UCForms.UC.UCHelpHover();
            this.ucHelpHover2 = new EZ_Builder.UCForms.UC.UCHelpHover();
            this.ucHelpHover3 = new EZ_Builder.UCForms.UC.UCHelpHover();
            this.ucHelpHover4 = new EZ_Builder.UCForms.UC.UCHelpHover();
            this.SuspendLayout();
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(106, 90);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(251, 20);
            this.keyTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API key:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(263, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(28, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Play through:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(128, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EZ-B";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(183, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Computer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Voice:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "en-US, Male, BenjaminRUS";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ar-EG, Female, Hoda",
            "ar-SA, Male, Naayf",
            "ca-ES, Female, HerenaRUS",
            "cs-CZ, Male, Vit",
            "da-DK, Female, HelleRUS",
            "de-AT, Male, Michael",
            "de-CH, Male, Karsten",
            "de-DE, Female, Hedda",
            "de-DE, Female, HeddaRUS",
            "de-DE, Male, Stefan, Apollo",
            "el-GR, Male, Stefanos",
            "en-AU, Female, Catherine",
            "en-AU, Female, HayleyRUS",
            "en-CA, Female, Linda",
            "en-CA, Female, HeatherRUS",
            "en-GB, Female, Susan, Apollo",
            "en-GB, Female, HazelRUS",
            "en-GB, Male, Apollo",
            "en-IE, Male, Shaun",
            "en-IN, Female, Heera, Apollo",
            "en-IN, Female, PriyaRUS",
            "en-IN, Male, Ravi, Apollo",
            "en-US, Female, ZiraRUS",
            "en-US, Female, JessaRUS",
            "en-US, Male, BenjaminRUS",
            "es-ES, Female, Laura, Apollo",
            "es-ES, Female, HelenaRUS",
            "es-ES, Male, Pablo, Apollo",
            "es-MX, Female, HildaRUS",
            "es-MX, Male, Raul, Apollo",
            "fi-FI, Female, HeidiRUS",
            "fr-CA, Female, Caroline",
            "fr-CA, Female, HarmonieRUS",
            "fr-CH, Male, Guillaume",
            "fr-FR, Female, Julie, Apollo",
            "fr-FR, Female, HortenseRUS",
            "fr-FR, Male, Apollo",
            "he-IL, Male, Asaf",
            "hi-IN, Female, Kalpana, Apollo",
            "hi-IN, Female, Kalpana",
            "hi-IN, Male, Hemant",
            "hu-HU, Male, Szabolcs",
            "id-ID, Male, Andika",
            "it-IT, Male, Cosimo, Apollo",
            "ja-JP, Female, Ayumi, Apollo",
            "ja-JP, Male, Apollo",
            "ja-JP, Female, HarukaRUS",
            "ja-JP, Female, LuciaRUS",
            "ja-JP, Male, EkaterinaRUS",
            "ko-KR, Female, HeamiRUS",
            "nb-NO, Female, HuldaRUS",
            "nl-NL, Female, HannaRUS",
            "pl-PL, Female, PaulinaRUS",
            "pt-BR, Female, HeloisaRUS",
            "pt-BR, Male, Daniel, Apollo",
            "pt-PT, Female, HeliaRUS",
            "ro-RO, Male, Andrei",
            "ru-RU, Female, Irina, Apollo",
            "ru-RU, Male, Pavel, Apollo",
            "sk-SK, Male, Filip",
            "sv-SE, Female, HedvigRUS",
            "th-TH, Male, Pattara",
            "tr-TR, Female, SedaRUS",
            "zh-CN, Female, HuihuiRUS",
            "zh-CN, Female, Yaoyao, Apollo",
            "zh-CN, Male, Kangkang, Apollo",
            "zh-HK, Female, Tracy, Apollo",
            "zh-HK, Female, TracyRUS",
            "zh-HK, Male, Danny, Apollo",
            "zh-TW, Female, Yating, Apollo",
            "zh-TW, Female, HanHanRUS",
            "zh-TW, Male, Zhiwei, Apollo"});
            this.comboBox1.Location = new System.Drawing.Point(96, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "en-US, Male, BenjaminRUS";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(56, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show Advanced Voice Options";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ucHelpHover1
            // 
            this.ucHelpHover1.Location = new System.Drawing.Point(19, 35);
            this.ucHelpHover1.Margin = new System.Windows.Forms.Padding(0);
            this.ucHelpHover1.Name = "ucHelpHover1";
            this.ucHelpHover1.SetHelpText = "Choose whether the audio will be played through your EZ-B or the Computer.";
            this.ucHelpHover1.Size = new System.Drawing.Size(20, 20);
            this.ucHelpHover1.TabIndex = 18;
            // 
            // ucHelpHover2
            // 
            this.ucHelpHover2.Location = new System.Drawing.Point(19, 86);
            this.ucHelpHover2.Margin = new System.Windows.Forms.Padding(0);
            this.ucHelpHover2.Name = "ucHelpHover2";
            this.ucHelpHover2.SetHelpText = "The API key is assigned by Microsoft when the Bing Speech API service is assigned" +
    " to your account.\r\n\r\nPaste the API key here.";
            this.ucHelpHover2.Size = new System.Drawing.Size(20, 20);
            this.ucHelpHover2.TabIndex = 19;
            // 
            // ucHelpHover3
            // 
            this.ucHelpHover3.Location = new System.Drawing.Point(19, 140);
            this.ucHelpHover3.Margin = new System.Windows.Forms.Padding(0);
            this.ucHelpHover3.Name = "ucHelpHover3";
            this.ucHelpHover3.SetHelpText = "The language and voice to be used.";
            this.ucHelpHover3.Size = new System.Drawing.Size(20, 20);
            this.ucHelpHover3.TabIndex = 20;
            // 
            // ucHelpHover4
            // 
            this.ucHelpHover4.Location = new System.Drawing.Point(19, 195);
            this.ucHelpHover4.Margin = new System.Windows.Forms.Padding(0);
            this.ucHelpHover4.Name = "ucHelpHover4";
            this.ucHelpHover4.SetHelpText = "Choose whether you want the advanced options to be displayed.";
            this.ucHelpHover4.Size = new System.Drawing.Size(20, 20);
            this.ucHelpHover4.TabIndex = 21;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 313);
            this.Controls.Add(this.ucHelpHover4);
            this.Controls.Add(this.ucHelpHover3);
            this.Controls.Add(this.ucHelpHover2);
            this.Controls.Add(this.ucHelpHover1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyTextBox);
            this.Name = "FormConfig";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private EZ_Builder.UCForms.UC.UCHelpHover ucHelpHover1;
        private EZ_Builder.UCForms.UC.UCHelpHover ucHelpHover2;
        private EZ_Builder.UCForms.UC.UCHelpHover ucHelpHover3;
        private EZ_Builder.UCForms.UC.UCHelpHover ucHelpHover4;
    }
}