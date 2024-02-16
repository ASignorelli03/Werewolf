namespace Werewolf
{
    partial class MainMenu
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menuPlayButton = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsPlayerNameInput = new System.Windows.Forms.TextBox();
            this.btnPlayerAdder = new System.Windows.Forms.Button();
            this.LstPlayerNames = new System.Windows.Forms.ListBox();
            this.tbctrlsettings = new System.Windows.Forms.TabControl();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.checkedListRoles = new System.Windows.Forms.CheckedListBox();
            this.lblroledesc = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.tbctrlsettings.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            this.tabRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Controls.Add(this.menuPlayButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1423, 759);
            this.menuPanel.TabIndex = 0;
            // 
            // menuLabel
            // 
            this.menuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(691, 254);
            this.menuLabel.MaximumSize = new System.Drawing.Size(240, 60);
            this.menuLabel.MinimumSize = new System.Drawing.Size(79, 20);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(83, 20);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "WereWolf ";
            // 
            // menuPlayButton
            // 
            this.menuPlayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPlayButton.Location = new System.Drawing.Point(611, 304);
            this.menuPlayButton.MaximumSize = new System.Drawing.Size(600, 225);
            this.menuPlayButton.MinimumSize = new System.Drawing.Size(200, 75);
            this.menuPlayButton.Name = "menuPlayButton";
            this.menuPlayButton.Size = new System.Drawing.Size(200, 75);
            this.menuPlayButton.TabIndex = 0;
            this.menuPlayButton.Text = "play";
            this.menuPlayButton.UseVisualStyleBackColor = true;
            this.menuPlayButton.Click += new System.EventHandler(this.menuPlayButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.Controls.Add(this.tbctrlsettings);
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1423, 759);
            this.settingsPanel.TabIndex = 1;
            this.settingsPanel.Visible = false;
            this.settingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.settingsPanel_Paint);
            // 
            // settingsPlayerNameInput
            // 
            this.settingsPlayerNameInput.Location = new System.Drawing.Point(166, 28);
            this.settingsPlayerNameInput.Name = "settingsPlayerNameInput";
            this.settingsPlayerNameInput.Size = new System.Drawing.Size(168, 26);
            this.settingsPlayerNameInput.TabIndex = 1;
            this.settingsPlayerNameInput.TextChanged += new System.EventHandler(this.settingsPlayerNameInput_TextChanged);
            // 
            // btnPlayerAdder
            // 
            this.btnPlayerAdder.AutoSize = true;
            this.btnPlayerAdder.Location = new System.Drawing.Point(32, 26);
            this.btnPlayerAdder.Name = "btnPlayerAdder";
            this.btnPlayerAdder.Size = new System.Drawing.Size(115, 30);
            this.btnPlayerAdder.TabIndex = 2;
            this.btnPlayerAdder.Text = "Add/Remove";
            this.btnPlayerAdder.UseVisualStyleBackColor = true;
            this.btnPlayerAdder.Click += new System.EventHandler(this.button1_Click);
            // 
            // LstPlayerNames
            // 
            this.LstPlayerNames.ColumnWidth = 75;
            this.LstPlayerNames.FormattingEnabled = true;
            this.LstPlayerNames.ItemHeight = 20;
            this.LstPlayerNames.Location = new System.Drawing.Point(32, 66);
            this.LstPlayerNames.MultiColumn = true;
            this.LstPlayerNames.Name = "LstPlayerNames";
            this.LstPlayerNames.Size = new System.Drawing.Size(682, 264);
            this.LstPlayerNames.TabIndex = 3;
            this.LstPlayerNames.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // tbctrlsettings
            // 
            this.tbctrlsettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbctrlsettings.Controls.Add(this.tabPlayers);
            this.tbctrlsettings.Controls.Add(this.tabRoles);
            this.tbctrlsettings.Location = new System.Drawing.Point(108, 68);
            this.tbctrlsettings.Name = "tbctrlsettings";
            this.tbctrlsettings.SelectedIndex = 0;
            this.tbctrlsettings.Size = new System.Drawing.Size(1188, 611);
            this.tbctrlsettings.TabIndex = 4;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.LstPlayerNames);
            this.tabPlayers.Controls.Add(this.btnPlayerAdder);
            this.tabPlayers.Controls.Add(this.settingsPlayerNameInput);
            this.tabPlayers.Location = new System.Drawing.Point(4, 54);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayers.Size = new System.Drawing.Size(1180, 553);
            this.tabPlayers.TabIndex = 0;
            this.tabPlayers.Text = "players";
            this.tabPlayers.UseVisualStyleBackColor = true;
            this.tabPlayers.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabRoles
            // 
            this.tabRoles.AutoScroll = true;
            this.tabRoles.Controls.Add(this.lblroledesc);
            this.tabRoles.Controls.Add(this.checkedListRoles);
            this.tabRoles.Location = new System.Drawing.Point(4, 54);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoles.Size = new System.Drawing.Size(1180, 553);
            this.tabRoles.TabIndex = 1;
            this.tabRoles.Text = "roles";
            this.tabRoles.UseVisualStyleBackColor = true;
            this.tabRoles.Click += new System.EventHandler(this.tabRoles_Click);
            // 
            // checkedListRoles
            // 
            this.checkedListRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListRoles.ColumnWidth = 175;
            this.checkedListRoles.FormattingEnabled = true;
            this.checkedListRoles.Items.AddRange(new object[] {
            "The Amulet of Protection:",
            "Apprentice Seer (+4): ",
            "Aura Seer (+3): ",
            "Beholder (+2): ",
            "Big Bad Wolf (-9):",
            "Bogeyman (-6): ",
            "Bodyguard (+3): ",
            "Cupid (-3): ",
            "The Count (+5): ",
            "Diseased (+3): ",
            "Fruit Brute (-3):",
            "Ghost (+2):",
            "Hunter (+3): ",
            "Village Idiot (+2):",
            "Insomniac (+3):",
            "Lycan (-1):",
            "Wolf man (-9) : ",
            "Martyr (+3):",
            "Mason (+2) (3): ",
            "Mayor (+2): ",
            "Old Hag (+1): ",
            "Old Man (0):",
            "P.I. (+3): ",
            "Pacifist (-2): ",
            "Priest (+3): ",
            "Prince (+3): ",
            "Seer (+7): ",
            "Spellcaster (+1):",
            "Tough Guy (+3): ",
            "Troublemaker (+2): ",
            "Thing (+3): ",
            "Villager (+1) (20): ",
            "Witch (+4):",
            "Sorcerer (-3): ",
            "Minion (-6): ",
            "Werewolf (-6) (12): ",
            "Wolf Cub (-8):",
            "Dream Wolf (-5): ",
            "Cursed (-3): ",
            "Doppelgänger (-2): ",
            "Drunk (3): ",
            "Cult Leader (+1): ",
            "Hoodlum:",
            "Tanner (+1):",
            "Lone Wolf (-5): ",
            "Vampire (-7) (8): ",
            "Wild Child: ",
            "Sasquatch (-2): ",
            "Leprechaun (+5): ",
            "Bloody Mary (+1): ",
            "Chupacabra (+4): ",
            "Nostradamus (+1): ",
            "Dire Wolf (-4): "});
            this.checkedListRoles.Location = new System.Drawing.Point(55, 38);
            this.checkedListRoles.MultiColumn = true;
            this.checkedListRoles.Name = "checkedListRoles";
            this.checkedListRoles.Size = new System.Drawing.Size(1026, 372);
            this.checkedListRoles.TabIndex = 0;
            this.checkedListRoles.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblroledesc
            // 
            this.lblroledesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblroledesc.Location = new System.Drawing.Point(51, 443);
            this.lblroledesc.Name = "lblroledesc";
            this.lblroledesc.Size = new System.Drawing.Size(1000, 75);
            this.lblroledesc.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btnPlayerAdder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 759);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.settingsPanel);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.Text = "MainMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.tbctrlsettings.ResumeLayout(false);
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            this.tabRoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button menuPlayButton;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.TextBox settingsPlayerNameInput;
        private System.Windows.Forms.Button btnPlayerAdder;
        private System.Windows.Forms.ListBox LstPlayerNames;
        private System.Windows.Forms.TabControl tbctrlsettings;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.CheckedListBox checkedListRoles;
        private System.Windows.Forms.Label lblroledesc;
    }
}