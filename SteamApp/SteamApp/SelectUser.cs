using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamApp
{
    public partial class SelectUser : Form
    {
        private SavedDataReader reader;
        private ArrayList users;
        private PlayerInfo player;
        private Dictionary<string, string> players;

        public SelectUser()
        {
            InitializeComponent();
            reader = new SavedDataReader();
            users = reader.GetUsers();
            player = new PlayerInfo();
            players = new Dictionary<string, string>();
            ShowUsers();
        }

        private void ShowUsers()
        {
            foreach (string user in users)
            {
                string api = user.Substring(0, user.IndexOf(";"));
                string id = user.Substring(user.IndexOf(";") + 1);
                userBox.Items.Add(player.GetPlayerName(api, id));
                players[player.GetPlayerName(api, id)] = user;
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (userBox.SelectedItem != null)
            {
                string selectedUser = userBox.SelectedItem.ToString();
                string apiId = players[userBox.SelectedItem.ToString()];
                string selectedUserApi = apiId.Substring(0, apiId.IndexOf(";"));
                string selectedUserId = apiId.Substring(apiId.IndexOf(";") + 1);
                Form1 main = new Form1(selectedUser, selectedUserApi, selectedUserId);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a user");
            }
        }

        private void addUserBtn_Click_1(object sender, EventArgs e)
        {
            if (apiText.Text == "" || idText.Text == "")
            {
                MessageBox.Show("Please provide a Steam API Key and a Steam ID");
            }
            else
            {
                string api = "";
                string id = "";
                api = apiText.Text;
                id = idText.Text;
                reader.SaveUser(api, id);
            }
        }
    }
}
