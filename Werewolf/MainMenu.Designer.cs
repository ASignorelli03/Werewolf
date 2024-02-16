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
            this.menuPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Controls.Add(this.menuPlayButton);
            this.menuPanel.Location = new System.Drawing.Point(28, 15);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(692, 374);
            this.menuPanel.TabIndex = 0;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(192, 69);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(79, 20);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "WereWolf";
            // 
            // menuPlayButton
            // 
            this.menuPlayButton.Location = new System.Drawing.Point(142, 149);
            this.menuPlayButton.Name = "menuPlayButton";
            this.menuPlayButton.Size = new System.Drawing.Size(165, 75);
            this.menuPlayButton.TabIndex = 0;
            this.menuPlayButton.Text = "play";
            this.menuPlayButton.UseVisualStyleBackColor = true;
            this.menuPlayButton.Click += new System.EventHandler(this.menuPlayButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.LstPlayerNames);
            this.settingsPanel.Controls.Add(this.btnPlayerAdder);
            this.settingsPanel.Controls.Add(this.settingsPlayerNameInput);
            this.settingsPanel.Location = new System.Drawing.Point(12, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(627, 359);
            this.settingsPanel.TabIndex = 1;
            this.settingsPanel.Visible = false;
            this.settingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.settingsPanel_Paint);
            // 
            // settingsPlayerNameInput
            // 
            this.settingsPlayerNameInput.Location = new System.Drawing.Point(119, 63);
            this.settingsPlayerNameInput.Name = "settingsPlayerNameInput";
            this.settingsPlayerNameInput.Size = new System.Drawing.Size(168, 26);
            this.settingsPlayerNameInput.TabIndex = 1;
            this.settingsPlayerNameInput.TextChanged += new System.EventHandler(this.settingsPlayerNameInput_TextChanged);
            // 
            // btnPlayerAdder
            // 
            this.btnPlayerAdder.Location = new System.Drawing.Point(119, 27);
            this.btnPlayerAdder.Name = "btnPlayerAdder";
            this.btnPlayerAdder.Size = new System.Drawing.Size(115, 30);
            this.btnPlayerAdder.TabIndex = 2;
            this.btnPlayerAdder.Text = "Add/Remove";
            this.btnPlayerAdder.UseVisualStyleBackColor = true;
            this.btnPlayerAdder.Click += new System.EventHandler(this.button1_Click);
            // 
            // LstPlayerNames
            // 
            this.LstPlayerNames.FormattingEnabled = true;
            this.LstPlayerNames.ItemHeight = 20;
            this.LstPlayerNames.Location = new System.Drawing.Point(119, 98);
            this.LstPlayerNames.Name = "LstPlayerNames";
            this.LstPlayerNames.Size = new System.Drawing.Size(168, 264);
            this.LstPlayerNames.TabIndex = 3;
            this.LstPlayerNames.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
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
    }
}