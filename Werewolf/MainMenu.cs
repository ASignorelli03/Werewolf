using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            checkedListRoles.Items.Clear();
            for (int i = 0; i < roleTable.GetLength(0); i++)
            {
                checkedListRoles.Items.Add(roleTable[i, 0].ToString());
            }
        }
        private void MainMenu_Resize(object sender, System.EventArgs e)
        {
            menuPlayButton.Location = new Point(this.Width / 2 - menuPlayButton.Width / 2, this.Height / 2 - menuPlayButton.Height / 2);
            menuPlayButton.Size = new Size(this.Width / 4, this.Height / 6);
            menuLabel.Location = new Point(this.Width / 2 - menuLabel.Width / 2, this.Height / 4);
            menuLabel.Size = new Size(120, 20);

           
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //find description of currect selected role
            lblroledesc.Text = roleTable[this.checkedListRoles.SelectedIndex,3];
        }

        private void tabRoles_Click(object sender, EventArgs e)
        {

        }

        private void txtbxRoleDesc_TextChanged(object sender, EventArgs e)
        {

        }
        String[,] roleTable =
        {
            {"Apprentice Seer","villager","4" ,"Become the Seer if the Seer is killed." },
            {"Bodyguard","villager","3" ,"Choose a different player each night to protect. That player cannot be killed that night."},
            {"Cupid","villager","-3","Choose two players to be lovers. If one of those players dies, the other dies from a broken heart." },
            {"Diseased","villager","3","If you are attacked by werewolves, the werewolves do not get fed the following night." },
            {"Hunter","villager","3","If you are killed, take someone down with you." },
            {"Village Idiot","village","2","Always vote for players to die." },
            {"Lycan","villager","-1","You are a villager, but you appear falsely to be a werewolf to the Seers and PI." },
            {"Wolf man","werewolf","-9","You Wake With the other Werewolves each night, but the Seer sees you as a Villager" },
            {"Mayor","villager","2","Your vote counts twice when voting to lynch a player if you reveal yourself." },
            {"Old Hag","villager","1","At night, indicate a player who must leave the village the next day." },
            {"P.I.","villager","3","Inspect three players each night (they must be beside each other). You only know if at least one of them is malicious. (variation: Inspect three adjacent players on one night)." },
            {"Priest","villager","3","On the first night, protect a player. The next attempt to kill the player fails. The night after that attempt, you protect a different player. (variation: Protect one player from death caused at night, including vampire attacks.)" },
            {"Prince","villager","3","You can’t be lynched." },
            {"Seer","villager","7","Each night, point at a player and learn if they are: Either on the villager team, or a vampire, or, if a werewolf, the exact powers." },
            {"Spellcaster","villager","1" ,"At night, indicate a player who must not use their voice the following day." },
            {"Tough Guy","villager","3","You survive an extra day if attacked by werewolves at night." },
            {"Villager","villager","1","Find the werewolves and lynch them." },
            {"Witch","villager","4","Kill or heal a player, once each per game." },
            {"Sorcerer","werewolf","-3","You are a seer, but you are on the Werewolf team. You only know if you’ve found a werewolf, another seer, or something else." },
            {"Minion","werewolf","-6","Work with the werewolves or vampires to kill the villagers. The moderator decides whether you work with the werewolves or the vampires." },
            {"Werewolf","werewolf","-6","Eat a villager each night." },
            {"Wolf Cub","werewolf","-8","If you die, the werewolves get two kills the following night." },
            {"Cursed","neutral","-3","You are a villager until attacked by werewolves, at which time you become a werewolf. (variation: You become a vampire when attacked by vampires.)" },
            {"Drunk","villager","3","You are a villager until the third night, when you remember your real role." }, 
           //incomplete list https://ultimatewerewolfgames.tumblr.com/roles
        };

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
