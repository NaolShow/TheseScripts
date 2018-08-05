namespace TheseScripts.Forms
{
    partial class TheseSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheseSettings));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.MiscellaneousGroupBox = new System.Windows.Forms.GroupBox();
            this.BetaWelcomeCheck = new System.Windows.Forms.CheckBox();
            this.BO3SearchFolderButton = new System.Windows.Forms.Button();
            this.BO3RootLinkTextBox = new System.Windows.Forms.TextBox();
            this.BO3RootLabel = new System.Windows.Forms.Label();
            this.LanguageCombo = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.TabsGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowConsoleCheck = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.MiscellaneousGroupBox.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.TabsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabAdvanced);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(504, 381);
            this.tabControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.MiscellaneousGroupBox);
            this.tabGeneral.Controls.Add(this.BO3SearchFolderButton);
            this.tabGeneral.Controls.Add(this.BO3RootLinkTextBox);
            this.tabGeneral.Controls.Add(this.BO3RootLabel);
            this.tabGeneral.Controls.Add(this.LanguageCombo);
            this.tabGeneral.Controls.Add(this.LanguageLabel);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(496, 355);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousGroupBox
            // 
            this.MiscellaneousGroupBox.Controls.Add(this.BetaWelcomeCheck);
            this.MiscellaneousGroupBox.Location = new System.Drawing.Point(11, 90);
            this.MiscellaneousGroupBox.Name = "MiscellaneousGroupBox";
            this.MiscellaneousGroupBox.Size = new System.Drawing.Size(477, 44);
            this.MiscellaneousGroupBox.TabIndex = 5;
            this.MiscellaneousGroupBox.TabStop = false;
            this.MiscellaneousGroupBox.Text = "Miscellaneous";
            // 
            // BetaWelcomeCheck
            // 
            this.BetaWelcomeCheck.AutoSize = true;
            this.BetaWelcomeCheck.Location = new System.Drawing.Point(6, 19);
            this.BetaWelcomeCheck.Name = "BetaWelcomeCheck";
            this.BetaWelcomeCheck.Size = new System.Drawing.Size(124, 17);
            this.BetaWelcomeCheck.TabIndex = 0;
            this.BetaWelcomeCheck.Text = "Show Beta Message";
            this.BetaWelcomeCheck.UseVisualStyleBackColor = true;
            this.BetaWelcomeCheck.CheckedChanged += new System.EventHandler(this.BetaWelcomeCheck_CheckedChanged);
            // 
            // BO3SearchFolderButton
            // 
            this.BO3SearchFolderButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BO3SearchFolderButton.Location = new System.Drawing.Point(413, 38);
            this.BO3SearchFolderButton.Name = "BO3SearchFolderButton";
            this.BO3SearchFolderButton.Size = new System.Drawing.Size(75, 23);
            this.BO3SearchFolderButton.TabIndex = 4;
            this.BO3SearchFolderButton.Text = ". . .";
            this.BO3SearchFolderButton.UseVisualStyleBackColor = true;
            this.BO3SearchFolderButton.Click += new System.EventHandler(this.BO3SearchFolderButton_Click);
            // 
            // BO3RootLinkTextBox
            // 
            this.BO3RootLinkTextBox.Location = new System.Drawing.Point(172, 38);
            this.BO3RootLinkTextBox.Name = "BO3RootLinkTextBox";
            this.BO3RootLinkTextBox.ReadOnly = true;
            this.BO3RootLinkTextBox.Size = new System.Drawing.Size(235, 20);
            this.BO3RootLinkTextBox.TabIndex = 3;
            // 
            // BO3RootLabel
            // 
            this.BO3RootLabel.AutoSize = true;
            this.BO3RootLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BO3RootLabel.Location = new System.Drawing.Point(8, 40);
            this.BO3RootLabel.Name = "BO3RootLabel";
            this.BO3RootLabel.Size = new System.Drawing.Size(140, 15);
            this.BO3RootLabel.TabIndex = 2;
            this.BO3RootLabel.Text = "\"Black ops 3\" root folder:";
            // 
            // LanguageCombo
            // 
            this.LanguageCombo.FormattingEnabled = true;
            this.LanguageCombo.Location = new System.Drawing.Point(80, 11);
            this.LanguageCombo.Name = "LanguageCombo";
            this.LanguageCombo.Size = new System.Drawing.Size(408, 21);
            this.LanguageCombo.TabIndex = 1;
            this.LanguageCombo.SelectedIndexChanged += new System.EventHandler(this.LanguageCombo_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageLabel.Location = new System.Drawing.Point(8, 13);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(66, 15);
            this.LanguageLabel.TabIndex = 0;
            this.LanguageLabel.Text = "Language:";
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.TabsGroupBox);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Size = new System.Drawing.Size(496, 355);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "Advanced";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // TabsGroupBox
            // 
            this.TabsGroupBox.Controls.Add(this.ShowConsoleCheck);
            this.TabsGroupBox.Location = new System.Drawing.Point(9, 4);
            this.TabsGroupBox.Name = "TabsGroupBox";
            this.TabsGroupBox.Size = new System.Drawing.Size(479, 50);
            this.TabsGroupBox.TabIndex = 1;
            this.TabsGroupBox.TabStop = false;
            this.TabsGroupBox.Text = "Tabs";
            // 
            // ShowConsoleCheck
            // 
            this.ShowConsoleCheck.AutoSize = true;
            this.ShowConsoleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowConsoleCheck.Location = new System.Drawing.Point(6, 19);
            this.ShowConsoleCheck.Name = "ShowConsoleCheck";
            this.ShowConsoleCheck.Size = new System.Drawing.Size(103, 19);
            this.ShowConsoleCheck.TabIndex = 0;
            this.ShowConsoleCheck.Text = "Show console";
            this.ShowConsoleCheck.UseVisualStyleBackColor = true;
            this.ShowConsoleCheck.CheckedChanged += new System.EventHandler(this.ShowConsoleCheck_CheckedChanged);
            // 
            // TheseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TheseSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheseScripts - Settings";
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.MiscellaneousGroupBox.ResumeLayout(false);
            this.MiscellaneousGroupBox.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.TabsGroupBox.ResumeLayout(false);
            this.TabsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tabGeneral;
        public System.Windows.Forms.Label LanguageLabel;
        public System.Windows.Forms.ComboBox LanguageCombo;
        public System.Windows.Forms.Label BO3RootLabel;
        public System.Windows.Forms.TextBox BO3RootLinkTextBox;
        public System.Windows.Forms.Button BO3SearchFolderButton;
        public System.Windows.Forms.GroupBox MiscellaneousGroupBox;
        public System.Windows.Forms.TabPage tabAdvanced;
        public System.Windows.Forms.CheckBox ShowConsoleCheck;
        public System.Windows.Forms.GroupBox TabsGroupBox;
        public System.Windows.Forms.CheckBox BetaWelcomeCheck;
    }
}