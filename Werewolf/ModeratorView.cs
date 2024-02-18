using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Werewolf.DatabaseDataSetActualTableAdapters;

namespace Werewolf
{
    public partial class ModeratorView : Form
    {
        public ModeratorView()
        {
            InitializeComponent();
        }

        private void liveGameBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void ModeratorView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.ModView' table. You can move, or remove it, as needed.
            this.modViewTableAdapter.Fill(this.databaseDataSet.ModView);
        }

        private void liveGameDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ignore
        }

        private void liveGameDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0;i<liveGameDataGridView.SelectedCells.Count;i++)
            {
                int row = liveGameDataGridView.SelectedCells[i].RowIndex;
                string name = liveGameDataGridView.Rows[row].Cells[0].Value.ToString();
                string sql = $"UPDATE LiveGame SET Status = 'Dead' WHERE Name = '{name }'";
                runCommand(sql);
            }
        }
        private void runCommand(string s)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ashoo\\source\\repos\\Werewolf\\Werewolf\\Database.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(s, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions here (e.g., log or display an error message)
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
