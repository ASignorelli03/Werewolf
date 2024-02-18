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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menuPlayButton = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.tbctrlsettings = new System.Windows.Forms.TabControl();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.LstPlayerNames = new System.Windows.Forms.ListBox();
            this.btnPlayerAdder = new System.Windows.Forms.Button();
            this.settingsPlayerNameInput = new System.Windows.Forms.TextBox();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.lblroledesc = new System.Windows.Forms.Label();
            this.checkedListRoles = new System.Windows.Forms.CheckedListBox();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnlgame = new System.Windows.Forms.Panel();
            this.deadNoRoleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadNoRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetActual = new Werewolf.DatabaseDataSetActual();
            this.aliveListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliveListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btngameback = new System.Windows.Forms.Button();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aliveListTableAdapter = new Werewolf.DatabaseDataSetActualTableAdapters.aliveListTableAdapter();
            this.tableAdapterManager = new Werewolf.DatabaseDataSetActualTableAdapters.TableAdapterManager();
            this.deadNoRoleTableAdapter = new Werewolf.DatabaseDataSetActualTableAdapters.deadNoRoleTableAdapter();
            this.menuPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.tbctrlsettings.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            this.tabRoles.SuspendLayout();
            this.tabStart.SuspendLayout();
            this.pnlgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deadNoRoleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadNoRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliveListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliveListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPanel.BackgroundImage")));
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Controls.Add(this.menuPlayButton);
            this.menuPanel.Location = new System.Drawing.Point(1587, 34);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(236, 194);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // menuLabel
            // 
            this.menuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(98, -28);
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
            this.menuPlayButton.Location = new System.Drawing.Point(18, 22);
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
            this.settingsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsPanel.Controls.Add(this.tbctrlsettings);
            this.settingsPanel.Location = new System.Drawing.Point(26, 46);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1080, 636);
            this.settingsPanel.TabIndex = 1;
            this.settingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.settingsPanel_Paint);
            // 
            // tbctrlsettings
            // 
            this.tbctrlsettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrlsettings.Controls.Add(this.tabPlayers);
            this.tbctrlsettings.Controls.Add(this.tabRoles);
            this.tbctrlsettings.Controls.Add(this.tabStart);
            this.tbctrlsettings.Location = new System.Drawing.Point(26, 14);
            this.tbctrlsettings.Name = "tbctrlsettings";
            this.tbctrlsettings.SelectedIndex = 0;
            this.tbctrlsettings.Size = new System.Drawing.Size(979, 575);
            this.tbctrlsettings.TabIndex = 4;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.LstPlayerNames);
            this.tabPlayers.Controls.Add(this.btnPlayerAdder);
            this.tabPlayers.Controls.Add(this.settingsPlayerNameInput);
            this.tabPlayers.Location = new System.Drawing.Point(4, 29);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayers.Size = new System.Drawing.Size(971, 542);
            this.tabPlayers.TabIndex = 0;
            this.tabPlayers.Text = "players";
            this.tabPlayers.UseVisualStyleBackColor = true;
            this.tabPlayers.Click += new System.EventHandler(this.tabPage1_Click);
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
            // settingsPlayerNameInput
            // 
            this.settingsPlayerNameInput.Location = new System.Drawing.Point(166, 28);
            this.settingsPlayerNameInput.Name = "settingsPlayerNameInput";
            this.settingsPlayerNameInput.Size = new System.Drawing.Size(168, 26);
            this.settingsPlayerNameInput.TabIndex = 1;
            this.settingsPlayerNameInput.TextChanged += new System.EventHandler(this.settingsPlayerNameInput_TextChanged);
            // 
            // tabRoles
            // 
            this.tabRoles.AutoScroll = true;
            this.tabRoles.Controls.Add(this.comboBoxSort);
            this.tabRoles.Controls.Add(this.lblroledesc);
            this.tabRoles.Controls.Add(this.checkedListRoles);
            this.tabRoles.Location = new System.Drawing.Point(4, 29);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoles.Size = new System.Drawing.Size(971, 542);
            this.tabRoles.TabIndex = 1;
            this.tabRoles.Text = "roles";
            this.tabRoles.UseVisualStyleBackColor = true;
            this.tabRoles.Click += new System.EventHandler(this.tabRoles_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Alphabetic",
            "Villager Team",
            "Werewolf Team",
            "Neutral Team",
            "Last Played"});
            this.comboBoxSort.Location = new System.Drawing.Point(358, 6);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(268, 28);
            this.comboBoxSort.TabIndex = 2;
            this.comboBoxSort.Text = "Sort by..";
            // 
            // lblroledesc
            // 
            this.lblroledesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblroledesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblroledesc.Location = new System.Drawing.Point(55, 498);
            this.lblroledesc.Name = "lblroledesc";
            this.lblroledesc.Size = new System.Drawing.Size(894, 41);
            this.lblroledesc.TabIndex = 1;
            // 
            // checkedListRoles
            // 
            this.checkedListRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListRoles.ColumnWidth = 175;
            this.checkedListRoles.FormattingEnabled = true;
            this.checkedListRoles.Items.AddRange(new object[] {
            "Villager",
            "Werewolf",
            "Lycan",
            "Apprentice Seer"});
            this.checkedListRoles.Location = new System.Drawing.Point(55, 38);
            this.checkedListRoles.MultiColumn = true;
            this.checkedListRoles.Name = "checkedListRoles";
            this.checkedListRoles.Size = new System.Drawing.Size(894, 441);
            this.checkedListRoles.TabIndex = 0;
            this.checkedListRoles.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tabStart
            // 
            this.tabStart.Controls.Add(this.checkBox5);
            this.tabStart.Controls.Add(this.checkBox4);
            this.tabStart.Controls.Add(this.button1);
            this.tabStart.Controls.Add(this.checkBox3);
            this.tabStart.Controls.Add(this.checkBox2);
            this.tabStart.Controls.Add(this.checkBox1);
            this.tabStart.Location = new System.Drawing.Point(4, 29);
            this.tabStart.Name = "tabStart";
            this.tabStart.Size = new System.Drawing.Size(154, 117);
            this.tabStart.TabIndex = 2;
            this.tabStart.Text = "start";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(96, 155);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(161, 24);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Show roles in play";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(96, 251);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(115, 24);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Save game";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.button1.Location = new System.Drawing.Point(394, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 327);
            this.button1.TabIndex = 3;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(96, 203);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(196, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Moderator cheat sheet";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(96, 110);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(190, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Show Roles on Death";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(96, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Auto Role Assign";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pnlgame
            // 
            this.pnlgame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlgame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlgame.Controls.Add(this.deadNoRoleDataGridView);
            this.pnlgame.Controls.Add(this.aliveListDataGridView);
            this.pnlgame.Controls.Add(this.btngameback);
            this.pnlgame.Location = new System.Drawing.Point(319, 60);
            this.pnlgame.Name = "pnlgame";
            this.pnlgame.Size = new System.Drawing.Size(1199, 571);
            this.pnlgame.TabIndex = 5;
            this.pnlgame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlgame_Paint);
            // 
            // deadNoRoleDataGridView
            // 
            this.deadNoRoleDataGridView.AccessibleName = "";
            this.deadNoRoleDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.deadNoRoleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deadNoRoleDataGridView.AutoGenerateColumns = false;
            this.deadNoRoleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deadNoRoleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.deadNoRoleDataGridView.DataSource = this.deadNoRoleBindingSource;
            this.deadNoRoleDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.deadNoRoleDataGridView.Location = new System.Drawing.Point(730, 120);
            this.deadNoRoleDataGridView.Name = "deadNoRoleDataGridView";
            this.deadNoRoleDataGridView.RowHeadersWidth = 62;
            this.deadNoRoleDataGridView.RowTemplate.Height = 28;
            this.deadNoRoleDataGridView.Size = new System.Drawing.Size(181, 329);
            this.deadNoRoleDataGridView.TabIndex = 2;
            this.deadNoRoleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deadNoRoleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Player";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dead Players";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 222;
            // 
            // deadNoRoleBindingSource
            // 
            this.deadNoRoleBindingSource.DataMember = "deadNoRole";
            this.deadNoRoleBindingSource.DataSource = this.databaseDataSetActual;
            // 
            // databaseDataSetActual
            // 
            this.databaseDataSetActual.DataSetName = "DatabaseDataSetActual";
            this.databaseDataSetActual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aliveListDataGridView
            // 
            this.aliveListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aliveListDataGridView.AutoGenerateColumns = false;
            this.aliveListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aliveListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.aliveListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aliveListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.aliveListDataGridView.DataSource = this.aliveListBindingSource;
            this.aliveListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.aliveListDataGridView.Location = new System.Drawing.Point(30, 120);
            this.aliveListDataGridView.Name = "aliveListDataGridView";
            this.aliveListDataGridView.RowHeadersWidth = 62;
            this.aliveListDataGridView.RowTemplate.Height = 28;
            this.aliveListDataGridView.Size = new System.Drawing.Size(534, 329);
            this.aliveListDataGridView.TabIndex = 1;
            this.aliveListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aliveListDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Player";
            this.dataGridViewTextBoxColumn1.HeaderText = "Alive Players";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Lynches";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nights Lynched";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modifer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modifers";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // aliveListBindingSource
            // 
            this.aliveListBindingSource.DataMember = "aliveList";
            this.aliveListBindingSource.DataSource = this.databaseDataSetActual;
            // 
            // btngameback
            // 
            this.btngameback.Location = new System.Drawing.Point(30, 30);
            this.btngameback.Name = "btngameback";
            this.btngameback.Size = new System.Drawing.Size(172, 59);
            this.btngameback.TabIndex = 0;
            this.btngameback.Text = "back";
            this.btngameback.UseVisualStyleBackColor = true;
            this.btngameback.Click += new System.EventHandler(this.button2_Click);
            // 
            // aliveListTableAdapter
            // 
            this.aliveListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.LiveGameTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Werewolf.DatabaseDataSetActualTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deadNoRoleTableAdapter
            // 
            this.deadNoRoleTableAdapter.ClearBeforeFill = true;
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btnPlayerAdder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 841);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.pnlgame);
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
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            this.pnlgame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deadNoRoleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadNoRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliveListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliveListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).EndInit();
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
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Panel pnlgame;
        private System.Windows.Forms.Button btngameback;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource1;
        private DatabaseDataSetActual databaseDataSetActual;
        private System.Windows.Forms.BindingSource aliveListBindingSource;
        private DatabaseDataSetActualTableAdapters.aliveListTableAdapter aliveListTableAdapter;
        private DatabaseDataSetActualTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView aliveListDataGridView;
        private System.Windows.Forms.BindingSource deadNoRoleBindingSource;
        private DatabaseDataSetActualTableAdapters.deadNoRoleTableAdapter deadNoRoleTableAdapter;
        private System.Windows.Forms.DataGridView deadNoRoleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}