using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            menuPanel.Hide();
            settingsPanel.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void settingsPlayerNameInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (settingsPlayerNameInput.Text != "")
            {
                string[] arr = new string[LstPlayerNames.Items.Count];
                for (int i = 0; i < LstPlayerNames.Items.Count; i++)
                {
                    arr[i] = LstPlayerNames.Items[i].ToString();
                }
                if (CheckList(arr, settingsPlayerNameInput.Text))
                {
                    for (int i = 0; i < LstPlayerNames.Items.Count; i++)
                    {
                        if (arr[i] == settingsPlayerNameInput.Text) arr[i] = "";
                    }
                    LstPlayerNames.Items.Clear();
                    foreach(string s in arr)
                    {
                        if(s !="") LstPlayerNames.Items.Add(s);
                    }
                }
                else
                {
                    LstPlayerNames.Items.Add(settingsPlayerNameInput.Text);
                }
            }
            settingsPlayerNameInput.Clear();
            settingsPlayerNameInput.Focus();
        }
        private Boolean CheckList(String[] strs, String s)
        {
            foreach(String str in strs)
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
    }
}
