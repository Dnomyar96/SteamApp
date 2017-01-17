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
        private ArrayList games;
        private OwnedGames ownedGames;

        public Form1()
        {
            InitializeComponent();
            key = "E9E1010520E7045656DF8E1CBC2CDE76";
            steamID = "76561198126405404";
            ownedGames = new OwnedGames(key, steamID);
            ShowGamesList();
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
