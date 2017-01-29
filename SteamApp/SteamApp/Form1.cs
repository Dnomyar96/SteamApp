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
    public partial class Form1 : Form
    {
        private string key;
        private string steamID;
        private string user;
        private ArrayList games;
        private OwnedGames ownedGames;
        private PlayerInfo playerInfo;
        private SelectUser application;

        public Form1(string user, string api, string id, SelectUser application)
        {
            InitializeComponent();
            key = api;
            steamID = id;
            this.user = user;
            this.application = application;
            ownedGames = new OwnedGames(key, steamID);
            playerInfo = new PlayerInfo();
            ShowGamesList();
            ShowUserInfo();
        }

        private void ShowGamesList()
        {
            games = ownedGames.getOwnedGames();
            gamesList.Items.Clear();
            games.Sort();
            foreach (var game in games)
            {
                gamesList.Items.Add(game);
            }
        }

        private void ShowUserInfo()
        {
            avatarBox.Load(playerInfo.GetAvatarUrl(key, steamID));
            userLbl.Text = user;
        }

        private void SearchGamesList(string searchString)
        {
            gamesList.Items.Clear();
            games.Sort();
            foreach (string game in games)
            {
                if (game.Contains(searchString))
                {
                    gamesList.Items.Add(game);
                }
            }
        }

        private string ConvertPlayTime(string playtime)
        {
            int total = Convert.ToInt32(playtime);
            int hours = 0;
            int minutes = 0;
            hours = total/60;
            minutes = total%60;
            return hours + " hours + " + minutes + " minutes";
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            SearchGamesList(searchBox.Text);
        }

        private void gamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameNameLbl.Text = gamesList.SelectedItem.ToString();
            playtimeLbl.Text = ConvertPlayTime(ownedGames.GetPlaytime(gamesList.SelectedItem.ToString()));
            logo.Load(ownedGames.GetLogoURL(gamesList.SelectedItem.ToString()));
        }
    }
}
