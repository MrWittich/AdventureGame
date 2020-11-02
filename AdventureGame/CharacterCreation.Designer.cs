namespace AdventureGame
{
    partial class CharacterCreation
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
            this.pbCharacterImage = new System.Windows.Forms.PictureBox();
            this.cbCharacterImage = new System.Windows.Forms.ComboBox();
            this.lblStrength = new System.Windows.Forms.Label();
            this.cbStrength = new System.Windows.Forms.ComboBox();
            this.cbDexterity = new System.Windows.Forms.ComboBox();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblWisdom = new System.Windows.Forms.Label();
            this.cbWisdom = new System.Windows.Forms.ComboBox();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.cbIntelligence = new System.Windows.Forms.ComboBox();
            this.lblCharm = new System.Windows.Forms.Label();
            this.cbCharm = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCharmScore = new System.Windows.Forms.Label();
            this.lblIntelligenceScore = new System.Windows.Forms.Label();
            this.lblWisdomScore = new System.Windows.Forms.Label();
            this.lblDexterityScore = new System.Windows.Forms.Label();
            this.lblStrengthScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacterImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCharacterImage
            // 
            this.pbCharacterImage.ErrorImage = null;
            this.pbCharacterImage.Location = new System.Drawing.Point(585, 34);
            this.pbCharacterImage.Name = "pbCharacterImage";
            this.pbCharacterImage.Size = new System.Drawing.Size(166, 147);
            this.pbCharacterImage.TabIndex = 0;
            this.pbCharacterImage.TabStop = false;
            // 
            // cbCharacterImage
            // 
            this.cbCharacterImage.FormattingEnabled = true;
            this.cbCharacterImage.Items.AddRange(new object[] {
            "Archer",
            "Dino Wizard",
            "Fighter",
            "Frog Fighter",
            "Rogue",
            "Tinker",
            "Wizard"});
            this.cbCharacterImage.Location = new System.Drawing.Point(585, 208);
            this.cbCharacterImage.Name = "cbCharacterImage";
            this.cbCharacterImage.Size = new System.Drawing.Size(171, 28);
            this.cbCharacterImage.TabIndex = 1;
            this.cbCharacterImage.Text = "<Select>";
            this.cbCharacterImage.SelectedIndexChanged += new System.EventHandler(this.cbCharacterImage_SelectedIndexChanged);
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStrength.Location = new System.Drawing.Point(16, 38);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(99, 19);
            this.lblStrength.TabIndex = 2;
            this.lblStrength.Text = "Strength: ";
            // 
            // cbStrength
            // 
            this.cbStrength.FormattingEnabled = true;
            this.cbStrength.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "<Reset>"});
            this.cbStrength.Location = new System.Drawing.Point(76, 46);
            this.cbStrength.Name = "cbStrength";
            this.cbStrength.Size = new System.Drawing.Size(148, 28);
            this.cbStrength.TabIndex = 3;
            this.cbStrength.Text = "Strength";
            this.cbStrength.SelectedIndexChanged += new System.EventHandler(this.cbStrength_SelectedIndexChanged);
            // 
            // cbDexterity
            // 
            this.cbDexterity.FormattingEnabled = true;
            this.cbDexterity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "<Reset>"});
            this.cbDexterity.Location = new System.Drawing.Point(76, 80);
            this.cbDexterity.Name = "cbDexterity";
            this.cbDexterity.Size = new System.Drawing.Size(148, 28);
            this.cbDexterity.TabIndex = 3;
            this.cbDexterity.Text = "Dexterity";
            this.cbDexterity.SelectedIndexChanged += new System.EventHandler(this.cbDexterity_SelectedIndexChanged);
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDexterity.Location = new System.Drawing.Point(16, 72);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(104, 19);
            this.lblDexterity.TabIndex = 2;
            this.lblDexterity.Text = "Dexterity: ";
            // 
            // lblWisdom
            // 
            this.lblWisdom.AutoSize = true;
            this.lblWisdom.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWisdom.Location = new System.Drawing.Point(16, 106);
            this.lblWisdom.Name = "lblWisdom";
            this.lblWisdom.Size = new System.Drawing.Size(81, 19);
            this.lblWisdom.TabIndex = 2;
            this.lblWisdom.Text = "Wisdom:";
            // 
            // cbWisdom
            // 
            this.cbWisdom.FormattingEnabled = true;
            this.cbWisdom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "<Reset>"});
            this.cbWisdom.Location = new System.Drawing.Point(76, 114);
            this.cbWisdom.Name = "cbWisdom";
            this.cbWisdom.Size = new System.Drawing.Size(148, 28);
            this.cbWisdom.TabIndex = 3;
            this.cbWisdom.Text = "Wisdom";
            this.cbWisdom.SelectedIndexChanged += new System.EventHandler(this.cbWisdom_SelectedIndexChanged);
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIntelligence.Location = new System.Drawing.Point(16, 140);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(113, 19);
            this.lblIntelligence.TabIndex = 2;
            this.lblIntelligence.Text = "Intelligence:";
            // 
            // cbIntelligence
            // 
            this.cbIntelligence.FormattingEnabled = true;
            this.cbIntelligence.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "<Reset>"});
            this.cbIntelligence.Location = new System.Drawing.Point(76, 148);
            this.cbIntelligence.Name = "cbIntelligence";
            this.cbIntelligence.Size = new System.Drawing.Size(148, 28);
            this.cbIntelligence.TabIndex = 3;
            this.cbIntelligence.Text = "Intelligence";
            this.cbIntelligence.SelectedIndexChanged += new System.EventHandler(this.cbIntelligence_SelectedIndexChanged);
            // 
            // lblCharm
            // 
            this.lblCharm.AutoSize = true;
            this.lblCharm.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharm.Location = new System.Drawing.Point(16, 174);
            this.lblCharm.Name = "lblCharm";
            this.lblCharm.Size = new System.Drawing.Size(73, 19);
            this.lblCharm.TabIndex = 2;
            this.lblCharm.Text = "Charm:";
            // 
            // cbCharm
            // 
            this.cbCharm.FormattingEnabled = true;
            this.cbCharm.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "<Reset>"});
            this.cbCharm.Location = new System.Drawing.Point(76, 182);
            this.cbCharm.Name = "cbCharm";
            this.cbCharm.Size = new System.Drawing.Size(148, 28);
            this.cbCharm.TabIndex = 3;
            this.cbCharm.Text = "Charm";
            this.cbCharm.SelectedIndexChanged += new System.EventHandler(this.cbCharm_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCharmScore);
            this.groupBox1.Controls.Add(this.lblIntelligenceScore);
            this.groupBox1.Controls.Add(this.lblWisdomScore);
            this.groupBox1.Controls.Add(this.lblDexterityScore);
            this.groupBox1.Controls.Add(this.lblStrengthScore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblStrength);
            this.groupBox1.Controls.Add(this.lblDexterity);
            this.groupBox1.Controls.Add(this.lblCharm);
            this.groupBox1.Controls.Add(this.lblWisdom);
            this.groupBox1.Controls.Add(this.lblIntelligence);
            this.groupBox1.Location = new System.Drawing.Point(280, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 232);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // lblCharmScore
            // 
            this.lblCharmScore.AutoSize = true;
            this.lblCharmScore.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharmScore.Location = new System.Drawing.Point(159, 174);
            this.lblCharmScore.Name = "lblCharmScore";
            this.lblCharmScore.Size = new System.Drawing.Size(60, 19);
            this.lblCharmScore.TabIndex = 3;
            this.lblCharmScore.Text = "label2";
            // 
            // lblIntelligenceScore
            // 
            this.lblIntelligenceScore.AutoSize = true;
            this.lblIntelligenceScore.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIntelligenceScore.Location = new System.Drawing.Point(159, 140);
            this.lblIntelligenceScore.Name = "lblIntelligenceScore";
            this.lblIntelligenceScore.Size = new System.Drawing.Size(60, 19);
            this.lblIntelligenceScore.TabIndex = 3;
            this.lblIntelligenceScore.Text = "label2";
            // 
            // lblWisdomScore
            // 
            this.lblWisdomScore.AutoSize = true;
            this.lblWisdomScore.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWisdomScore.Location = new System.Drawing.Point(159, 106);
            this.lblWisdomScore.Name = "lblWisdomScore";
            this.lblWisdomScore.Size = new System.Drawing.Size(60, 19);
            this.lblWisdomScore.TabIndex = 3;
            this.lblWisdomScore.Text = "label2";
            // 
            // lblDexterityScore
            // 
            this.lblDexterityScore.AutoSize = true;
            this.lblDexterityScore.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDexterityScore.Location = new System.Drawing.Point(159, 72);
            this.lblDexterityScore.Name = "lblDexterityScore";
            this.lblDexterityScore.Size = new System.Drawing.Size(60, 19);
            this.lblDexterityScore.TabIndex = 3;
            this.lblDexterityScore.Text = "label2";
            // 
            // lblStrengthScore
            // 
            this.lblStrengthScore.AutoSize = true;
            this.lblStrengthScore.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStrengthScore.Location = new System.Drawing.Point(159, 37);
            this.lblStrengthScore.Name = "lblStrengthScore";
            this.lblStrengthScore.Size = new System.Drawing.Size(60, 19);
            this.lblStrengthScore.TabIndex = 3;
            this.lblStrengthScore.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-133, -78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SWGothe", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Character Name:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("SWGothe", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(313, 365);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(193, 73);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start Your Adventure";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCharm);
            this.Controls.Add(this.cbIntelligence);
            this.Controls.Add(this.cbWisdom);
            this.Controls.Add(this.cbDexterity);
            this.Controls.Add(this.cbStrength);
            this.Controls.Add(this.cbCharacterImage);
            this.Controls.Add(this.pbCharacterImage);
            this.Name = "CharacterCreation";
            this.Text = "CharacterCreation";
            this.Load += new System.EventHandler(this.CharacterCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacterImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCharacterImage;
        private System.Windows.Forms.ComboBox cbCharacterImage;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.ComboBox cbStrength;
        private System.Windows.Forms.ComboBox cbDexterity;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.Label lblWisdom;
        private System.Windows.Forms.ComboBox cbWisdom;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.ComboBox cbIntelligence;
        private System.Windows.Forms.Label lblCharm;
        private System.Windows.Forms.ComboBox cbCharm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCharmScore;
        private System.Windows.Forms.Label lblIntelligenceScore;
        private System.Windows.Forms.Label lblWisdomScore;
        private System.Windows.Forms.Label lblDexterityScore;
        private System.Windows.Forms.Label lblStrengthScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
    }
}