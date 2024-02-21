using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Werewolf.DatabaseDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Werewolf
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }


        private void settingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuPlayButton_Click(object sender, EventArgs e)
        {
            settingsPanel.BringToFront();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void settingsPlayerNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//add/remove fro liveGame db here 
            if (settingsPlayerNameInput.Text != "")
            {
                string[] arr = new string[LstPlayerNames.Items.Count];
                for (int i = 0; i < LstPlayerNames.Items.Count; i++)
                {
                    arr[i] = LstPlayerNames.Items[i].ToString();
                }
                if (CheckList(arr, settingsPlayerNameInput.Text))// already in list means delete from it
                {
                    for (int i = 0; i < LstPlayerNames.Items.Count; i++)
                    {
                        if (arr[i] == settingsPlayerNameInput.Text) arr[i] = "";
                    }
                    LstPlayerNames.Items.Clear();
                    foreach (string s in arr)
                    {
                        if (s != "") LstPlayerNames.Items.Add(s);
                    }
                    runCommand($"DELETE FROM liveGame WHERE Player = '{settingsPlayerNameInput.Text}'");
                }
                else//not in list means add to it
                {
                    LstPlayerNames.Items.Add(settingsPlayerNameInput.Text);
                    runCommand($"INSERT INTO ModView(Player, Role, Status) VALUES('{settingsPlayerNameInput.Text}', 'villager', 'Alive')");
                }
            }
            settingsPlayerNameInput.Clear();
            settingsPlayerNameInput.Focus();
            lblPlayerCount.Text = "Player Count: " + LstPlayerNames.Items.Count;
        }
        private Boolean CheckList(String[] strs, String s)
        {
            foreach (String str in strs)
            {
                if (str == s)
                {
                    return true;
                }
            }
            return false;
        }
        private void settingsPlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSetActual.deadNoRole' table. You can move, or remove it, as needed.
            this.deadNoRoleTableAdapter.Fill(this.databaseDataSetActual.deadNoRole);
            // TODO: This line of code loads data into the 'databaseDataSetActual.aliveList' table. You can move, or remove it, as needed.
            this.aliveListTableAdapter.Fill(this.databaseDataSetActual.aliveList);

            this.Width = 1500;
            this.Height = 800;
            pnlgame.Location = new Point(0, 0);
            pnlgame.Size = new Size(1500, 800);
            settingsPanel.Location = new Point(0, 0);
            settingsPanel.Size = new Size(1500, 800);
            menuPanel.Location = new Point(0, 0);
            menuPanel.Size = new Size(1500, 800);
            menuPanel.BringToFront();
            tbctrlsettings.Location = new Point(0, 0);
            tbctrlsettings.Size = new Size(1500, 800);
            checkedListRoles.Items.Clear();
            lblroledesc.Location = new Point(settingsPanel.Location.X+20,settingsPanel.Location.Y+40);
            DataTable dt = sqlSelect("Select Name FROM Roles");
            foreach (DataRow row in dt.Rows)
            {
                string name = row["Name"].ToString();
                checkedListRoles.Items.Add(name);
            }
            dt = sqlSelect("Select Player FROM LiveGame");
            foreach(DataRow row in dt.Rows)
            {
                string name = row["Player"].ToString();
                LstPlayerNames.Items.Add(name);
            }
            LstPlayerNames.Update();
            LstPlayerNames.Refresh();
        }
        private void MainMenu_Resize(object sender, System.EventArgs e)
        {
            this.Width = 1500;
            this.Height = 800;
            pnlgame.Location = new Point(0, 0);
            pnlgame.Size = new Size(this.Width, this.Height);
            settingsPanel.Location = new Point(0, 0);
            settingsPanel.Size = new Size(this.Width, this.Height);
            menuPanel.Location = new Point(0, 0);
            menuPanel.Size = new Size(this.Width, this.Height);
            menuPanel.BringToFront();
            tbctrlsettings.Location = settingsPanel.Location;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoleName = this.checkedListRoles.SelectedItem.ToString(); // Get the selected role name
            DataTable dt = sqlSelect("SELECT Description FROM Roles WHERE Name = '" + selectedRoleName + "'");

            foreach (DataRow row in dt.Rows)
            {
                string description = row["Description"].ToString();
                lblroledesc.Text = description;
            }
            lblRoleCount.Text = "Role Count: "+checkedListRoles.CheckedItems.Count;//change where this event is to when the box is checked not when the selection is changed
        }
        private void tabRoles_Click(object sender, EventArgs e)
        {

        }

        private void txtbxRoleDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkedListRoles.CheckedItems.Count == LstPlayerNames.Items.Count)
            {
                string[] roles = new string[checkedListRoles.CheckedItems.Count];
                for (int i = 0; i < checkedListRoles.SelectedItems.Count; i++)
                {
                    roles[i] = checkedListRoles.SelectedItems[i].ToString();
                }
                if (checkBox1.Checked)
                {
                    randomize(roles);
                }
                for (int i = 0; i < LstPlayerNames.Items.Count; i++)
                {
                    string playerName = LstPlayerNames.Items[i].ToString();
                    if (roles[i] == null) roles[i] = "villager";//seg fault here, not every player is making it into the alivegame table
                    string sql = $"INSERT INTO ModView(Player, Role, Status) VALUES('{playerName}', '{roles[i]}', 'Alive')";
                    runCommand(sql);
                }
                var ModeratorView = new ModeratorView();
                pnlgame.BringToFront();
                ModeratorView.Show();
            }
            else//warning text about playercount not being role count
            {
                int n = checkedListRoles.CheckedItems.Count - LstPlayerNames.Items.Count;
                if (checkedListRoles.CheckedItems.Count > LstPlayerNames.Items.Count) lblWarning.Text = "Remove " +n.ToString() + " more role(s)";
                else lblWarning.Text = "Select " + (-n).ToString() + " more role(s)";
                        
            }
        }
        private void randomize(string[] items) 
        {
            Random rand = new Random();
            for(int i =0;i<items.Length;i++)
            {
                int j = rand.Next(items.Length);
                string temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }

        private void pnlgame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            settingsPanel.BringToFront();
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

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
        private DataTable sqlSelect(string s)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ashoo\\source\\repos\\Werewolf\\Werewolf\\Database.mdf;Integrated Security=True;Connect Timeout=30";
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (var command = new SqlCommand(s, connection))
                    {
                        connection.Open();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            dt.Load(dr);
                        }
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
            return dt;
        }

        private void aliveListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deadNoRoleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
