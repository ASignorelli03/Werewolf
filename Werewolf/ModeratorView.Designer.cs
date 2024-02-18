namespace Werewolf
{
    partial class ModeratorView
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
            this.databaseDataSetActual = new Werewolf.DatabaseDataSetActual();
            this.liveGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.liveGameTableAdapter = new Werewolf.DatabaseDataSetActualTableAdapters.LiveGameTableAdapter();
            this.tableAdapterManager = new Werewolf.DatabaseDataSetActualTableAdapters.TableAdapterManager();
            this.liveGameDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liveGameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Werewolf.DatabaseDataSet();
            this.modViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modViewTableAdapter = new Werewolf.DatabaseDataSetTableAdapters.ModViewTableAdapter();
            this.tableAdapterManager1 = new Werewolf.DatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveGameDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveGameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSetActual
            // 
            this.databaseDataSetActual.DataSetName = "DatabaseDataSetActual";
            this.databaseDataSetActual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // liveGameBindingSource
            // 
            this.liveGameBindingSource.DataMember = "LiveGame";
            this.liveGameBindingSource.DataSource = this.databaseDataSetActual;
            // 
            // liveGameTableAdapter
            // 
            this.liveGameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LiveGameTableAdapter = this.liveGameTableAdapter;
            this.tableAdapterManager.UpdateOrder = Werewolf.DatabaseDataSetActualTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // liveGameDataGridView
            // 
            this.liveGameDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liveGameDataGridView.AutoGenerateColumns = false;
            this.liveGameDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.liveGameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liveGameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.liveGameDataGridView.DataSource = this.liveGameBindingSource1;
            this.liveGameDataGridView.Location = new System.Drawing.Point(12, 60);
            this.liveGameDataGridView.Name = "liveGameDataGridView";
            this.liveGameDataGridView.RowHeadersWidth = 62;
            this.liveGameDataGridView.RowTemplate.Height = 28;
            this.liveGameDataGridView.Size = new System.Drawing.Size(784, 231);
            this.liveGameDataGridView.TabIndex = 0;
            this.liveGameDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.liveGameDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Player";
            this.dataGridViewTextBoxColumn1.HeaderText = "Player";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn2.HeaderText = "Role";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lynches";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lynches";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Modifer";
            this.dataGridViewTextBoxColumn5.HeaderText = "Modifer";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // liveGameBindingSource1
            // 
            this.liveGameBindingSource1.DataMember = "LiveGame";
            this.liveGameBindingSource1.DataSource = this.databaseDataSetActual;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modViewBindingSource
            // 
            this.modViewBindingSource.DataMember = "ModView";
            this.modViewBindingSource.DataSource = this.databaseDataSet;
            // 
            // modViewTableAdapter
            // 
            this.modViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.LiveGameTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Werewolf.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ModeratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.liveGameDataGridView);
            this.Name = "ModeratorView";
            this.Text = "ModeratorView";
            this.Load += new System.EventHandler(this.ModeratorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveGameDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveGameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseDataSetActual databaseDataSetActual;
        private System.Windows.Forms.BindingSource liveGameBindingSource;
        private DatabaseDataSetActualTableAdapters.LiveGameTableAdapter liveGameTableAdapter;
        private DatabaseDataSetActualTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView liveGameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource liveGameBindingSource1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource modViewBindingSource;
        private DatabaseDataSetTableAdapters.ModViewTableAdapter modViewTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}