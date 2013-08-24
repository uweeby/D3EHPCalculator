namespace D3EHPCalculator
{
    partial class Form1
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
            this.charselectButton = new System.Windows.Forms.Button();
            this.charselectLabel = new System.Windows.Forms.Label();
            this.charselectBox = new System.Windows.Forms.ComboBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionBox = new System.Windows.Forms.ComboBox();
            this.effectiveHPBox = new System.Windows.Forms.TextBox();
            this.baseeffectiveHPLabel = new System.Windows.Forms.Label();
            this.resistallBox = new System.Windows.Forms.TextBox();
            this.resistallLabel = new System.Windows.Forms.Label();
            this.armorBox = new System.Windows.Forms.TextBox();
            this.armorLabel = new System.Windows.Forms.Label();
            this.lifeBox = new System.Windows.Forms.TextBox();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.vitalityBox = new System.Windows.Forms.TextBox();
            this.vitalityLabel = new System.Windows.Forms.Label();
            this.intelligenceBox = new System.Windows.Forms.TextBox();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.dexterityBox = new System.Windows.Forms.TextBox();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.strengthBox = new System.Windows.Forms.TextBox();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.enemylevelBox = new System.Windows.Forms.TextBox();
            this.enemylevelLabel = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.TextBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.profileBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.calculateEHPButton = new System.Windows.Forms.Button();
            this.enemyrawdamageLabel = new System.Windows.Forms.Label();
            this.enemyrawdamageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // charselectButton
            // 
            this.charselectButton.Location = new System.Drawing.Point(393, 34);
            this.charselectButton.Name = "charselectButton";
            this.charselectButton.Size = new System.Drawing.Size(55, 21);
            this.charselectButton.TabIndex = 111;
            this.charselectButton.Text = "Select";
            this.charselectButton.UseVisualStyleBackColor = true;
            this.charselectButton.Click += new System.EventHandler(this.Button2Click);
            // 
            // charselectLabel
            // 
            this.charselectLabel.AutoSize = true;
            this.charselectLabel.Location = new System.Drawing.Point(7, 34);
            this.charselectLabel.Name = "charselectLabel";
            this.charselectLabel.Size = new System.Drawing.Size(89, 13);
            this.charselectLabel.TabIndex = 110;
            this.charselectLabel.Text = "Select Character:";
            // 
            // charselectBox
            // 
            this.charselectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.charselectBox.FormattingEnabled = true;
            this.charselectBox.Location = new System.Drawing.Point(102, 34);
            this.charselectBox.Name = "charselectBox";
            this.charselectBox.Size = new System.Drawing.Size(285, 21);
            this.charselectBox.TabIndex = 109;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(293, 10);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(44, 13);
            this.regionLabel.TabIndex = 108;
            this.regionLabel.Text = "Region:";
            // 
            // regionBox
            // 
            this.regionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionBox.FormattingEnabled = true;
            this.regionBox.Items.AddRange(new object[] {
            "EU",
            "KR",
            "TW",
            "US"});
            this.regionBox.Location = new System.Drawing.Point(343, 7);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(44, 21);
            this.regionBox.TabIndex = 107;
            // 
            // effectiveHPBox
            // 
            this.effectiveHPBox.Location = new System.Drawing.Point(342, 225);
            this.effectiveHPBox.Name = "effectiveHPBox";
            this.effectiveHPBox.Size = new System.Drawing.Size(102, 20);
            this.effectiveHPBox.TabIndex = 98;
            // 
            // baseeffectiveHPLabel
            // 
            this.baseeffectiveHPLabel.AutoSize = true;
            this.baseeffectiveHPLabel.Location = new System.Drawing.Point(239, 228);
            this.baseeffectiveHPLabel.Name = "baseeffectiveHPLabel";
            this.baseeffectiveHPLabel.Size = new System.Drawing.Size(97, 13);
            this.baseeffectiveHPLabel.TabIndex = 97;
            this.baseeffectiveHPLabel.Text = "Base Effective HP:";
            // 
            // resistallBox
            // 
            this.resistallBox.Location = new System.Drawing.Point(343, 95);
            this.resistallBox.Name = "resistallBox";
            this.resistallBox.Size = new System.Drawing.Size(102, 20);
            this.resistallBox.TabIndex = 86;
            // 
            // resistallLabel
            // 
            this.resistallLabel.AutoSize = true;
            this.resistallLabel.Location = new System.Drawing.Point(281, 98);
            this.resistallLabel.Name = "resistallLabel";
            this.resistallLabel.Size = new System.Drawing.Size(56, 13);
            this.resistallLabel.TabIndex = 85;
            this.resistallLabel.Text = "Resist All: ";
            // 
            // armorBox
            // 
            this.armorBox.Location = new System.Drawing.Point(343, 69);
            this.armorBox.Name = "armorBox";
            this.armorBox.Size = new System.Drawing.Size(102, 20);
            this.armorBox.TabIndex = 84;
            // 
            // armorLabel
            // 
            this.armorLabel.AutoSize = true;
            this.armorLabel.Location = new System.Drawing.Point(303, 72);
            this.armorLabel.Name = "armorLabel";
            this.armorLabel.Size = new System.Drawing.Size(40, 13);
            this.armorLabel.TabIndex = 83;
            this.armorLabel.Text = "Armor: ";
            // 
            // lifeBox
            // 
            this.lifeBox.Location = new System.Drawing.Point(102, 225);
            this.lifeBox.Name = "lifeBox";
            this.lifeBox.Size = new System.Drawing.Size(102, 20);
            this.lifeBox.TabIndex = 78;
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.Location = new System.Drawing.Point(69, 228);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(27, 13);
            this.lifeLabel.TabIndex = 77;
            this.lifeLabel.Text = "Life:";
            // 
            // vitalityBox
            // 
            this.vitalityBox.Location = new System.Drawing.Point(102, 199);
            this.vitalityBox.Name = "vitalityBox";
            this.vitalityBox.Size = new System.Drawing.Size(102, 20);
            this.vitalityBox.TabIndex = 76;
            // 
            // vitalityLabel
            // 
            this.vitalityLabel.AutoSize = true;
            this.vitalityLabel.Location = new System.Drawing.Point(56, 202);
            this.vitalityLabel.Name = "vitalityLabel";
            this.vitalityLabel.Size = new System.Drawing.Size(40, 13);
            this.vitalityLabel.TabIndex = 75;
            this.vitalityLabel.Text = "Vitality:";
            // 
            // intelligenceBox
            // 
            this.intelligenceBox.Location = new System.Drawing.Point(102, 173);
            this.intelligenceBox.Name = "intelligenceBox";
            this.intelligenceBox.Size = new System.Drawing.Size(102, 20);
            this.intelligenceBox.TabIndex = 74;
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(32, 176);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(64, 13);
            this.intelligenceLabel.TabIndex = 73;
            this.intelligenceLabel.Text = "Intelligence:";
            // 
            // dexterityBox
            // 
            this.dexterityBox.Location = new System.Drawing.Point(102, 147);
            this.dexterityBox.Name = "dexterityBox";
            this.dexterityBox.Size = new System.Drawing.Size(102, 20);
            this.dexterityBox.TabIndex = 72;
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.AutoSize = true;
            this.dexterityLabel.Location = new System.Drawing.Point(45, 150);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(51, 13);
            this.dexterityLabel.TabIndex = 71;
            this.dexterityLabel.Text = "Dexterity:";
            // 
            // strengthBox
            // 
            this.strengthBox.Location = new System.Drawing.Point(102, 121);
            this.strengthBox.Name = "strengthBox";
            this.strengthBox.Size = new System.Drawing.Size(102, 20);
            this.strengthBox.TabIndex = 70;
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(46, 123);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(50, 13);
            this.strengthLabel.TabIndex = 69;
            this.strengthLabel.Text = "Strength:";
            // 
            // enemylevelBox
            // 
            this.enemylevelBox.Location = new System.Drawing.Point(343, 121);
            this.enemylevelBox.Name = "enemylevelBox";
            this.enemylevelBox.Size = new System.Drawing.Size(102, 20);
            this.enemylevelBox.TabIndex = 68;
            // 
            // enemylevelLabel
            // 
            this.enemylevelLabel.AutoSize = true;
            this.enemylevelLabel.Location = new System.Drawing.Point(266, 124);
            this.enemylevelLabel.Name = "enemylevelLabel";
            this.enemylevelLabel.Size = new System.Drawing.Size(71, 13);
            this.enemylevelLabel.TabIndex = 67;
            this.enemylevelLabel.Text = "Enemy Level:";
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(102, 95);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(102, 20);
            this.levelBox.TabIndex = 66;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(60, 97);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(36, 13);
            this.levelLabel.TabIndex = 65;
            this.levelLabel.Text = "Level:";
            // 
            // classBox
            // 
            this.classBox.Location = new System.Drawing.Point(102, 69);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(102, 20);
            this.classBox.TabIndex = 64;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(61, 72);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(35, 13);
            this.classLabel.TabIndex = 63;
            this.classLabel.Text = "Class:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(393, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(55, 21);
            this.searchButton.TabIndex = 62;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.Button1Click);
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(225, 8);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(62, 20);
            this.codeBox.TabIndex = 61;
            // 
            // profileBox
            // 
            this.profileBox.Location = new System.Drawing.Point(51, 8);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(127, 20);
            this.profileBox.TabIndex = 60;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(184, 11);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(35, 13);
            this.codeLabel.TabIndex = 59;
            this.codeLabel.Text = "Code:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 58;
            this.nameLabel.Text = "Name:";
            // 
            // calculateEHPButton
            // 
            this.calculateEHPButton.Location = new System.Drawing.Point(343, 198);
            this.calculateEHPButton.Name = "calculateEHPButton";
            this.calculateEHPButton.Size = new System.Drawing.Size(101, 21);
            this.calculateEHPButton.TabIndex = 112;
            this.calculateEHPButton.Text = "Calculate EHP";
            this.calculateEHPButton.UseVisualStyleBackColor = true;
            this.calculateEHPButton.Click += new System.EventHandler(this.CalculateEhpButtonClick);
            // 
            // enemyrawdamageLabel
            // 
            this.enemyrawdamageLabel.AutoSize = true;
            this.enemyrawdamageLabel.Location = new System.Drawing.Point(227, 150);
            this.enemyrawdamageLabel.Name = "enemyrawdamageLabel";
            this.enemyrawdamageLabel.Size = new System.Drawing.Size(110, 13);
            this.enemyrawdamageLabel.TabIndex = 119;
            this.enemyrawdamageLabel.Text = "Enemy Raw Damage:";
            // 
            // enemyrawdamageBox
            // 
            this.enemyrawdamageBox.Location = new System.Drawing.Point(343, 147);
            this.enemyrawdamageBox.Name = "enemyrawdamageBox";
            this.enemyrawdamageBox.Size = new System.Drawing.Size(102, 20);
            this.enemyrawdamageBox.TabIndex = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 260);
            this.Controls.Add(this.enemyrawdamageBox);
            this.Controls.Add(this.enemyrawdamageLabel);
            this.Controls.Add(this.calculateEHPButton);
            this.Controls.Add(this.charselectButton);
            this.Controls.Add(this.charselectLabel);
            this.Controls.Add(this.charselectBox);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.effectiveHPBox);
            this.Controls.Add(this.baseeffectiveHPLabel);
            this.Controls.Add(this.resistallBox);
            this.Controls.Add(this.resistallLabel);
            this.Controls.Add(this.armorBox);
            this.Controls.Add(this.armorLabel);
            this.Controls.Add(this.lifeBox);
            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.vitalityBox);
            this.Controls.Add(this.vitalityLabel);
            this.Controls.Add(this.intelligenceBox);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.dexterityBox);
            this.Controls.Add(this.dexterityLabel);
            this.Controls.Add(this.strengthBox);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.enemylevelBox);
            this.Controls.Add(this.enemylevelLabel);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "D3 EHP Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button charselectButton;
        internal System.Windows.Forms.Label charselectLabel;
        internal System.Windows.Forms.ComboBox charselectBox;
        internal System.Windows.Forms.Label regionLabel;
        internal System.Windows.Forms.ComboBox regionBox;
        internal System.Windows.Forms.TextBox effectiveHPBox;
        internal System.Windows.Forms.Label baseeffectiveHPLabel;
        internal System.Windows.Forms.TextBox resistallBox;
        internal System.Windows.Forms.Label resistallLabel;
        internal System.Windows.Forms.TextBox armorBox;
        internal System.Windows.Forms.Label armorLabel;
        internal System.Windows.Forms.TextBox lifeBox;
        internal System.Windows.Forms.Label lifeLabel;
        internal System.Windows.Forms.TextBox vitalityBox;
        internal System.Windows.Forms.Label vitalityLabel;
        internal System.Windows.Forms.TextBox intelligenceBox;
        internal System.Windows.Forms.Label intelligenceLabel;
        internal System.Windows.Forms.TextBox dexterityBox;
        internal System.Windows.Forms.Label dexterityLabel;
        internal System.Windows.Forms.TextBox strengthBox;
        internal System.Windows.Forms.Label strengthLabel;
        internal System.Windows.Forms.TextBox enemylevelBox;
        internal System.Windows.Forms.Label enemylevelLabel;
        internal System.Windows.Forms.TextBox levelBox;
        internal System.Windows.Forms.Label levelLabel;
        internal System.Windows.Forms.TextBox classBox;
        internal System.Windows.Forms.Label classLabel;
        internal System.Windows.Forms.Button searchButton;
        internal System.Windows.Forms.TextBox codeBox;
        internal System.Windows.Forms.TextBox profileBox;
        internal System.Windows.Forms.Label codeLabel;
        internal System.Windows.Forms.Label nameLabel;
        internal System.Windows.Forms.Button calculateEHPButton;
        internal System.Windows.Forms.Label enemyrawdamageLabel;
        internal System.Windows.Forms.TextBox enemyrawdamageBox;
    }
}

