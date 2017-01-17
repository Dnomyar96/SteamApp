using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SteamApp
{
    class OwnedGames
    {
        private string key;
        private string steamID;
        private XmlDocument xml;

        public OwnedGames(string key, string steamID)
        {
            this.key = key;
            this.steamID = steamID;
            xml = new XmlDocument();
            xml.Load("http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=" 
                + key + "&steamid=" + this.steamID + "&include_appinfo=1&format=xml");
        }

        public ArrayList getOwnedGames()
        {
            ArrayList games = new ArrayList();
            foreach (XmlNode gamesNode in xml.DocumentElement.ChildNodes)
            {
                if (gamesNode.Name == "games")
                {
                    foreach (XmlNode messageNode in gamesNode.ChildNodes)
                    {
                        foreach (XmlNode gameNode in messageNode)
                        {
                            if (gameNode.Name == "name")
                            {
                                games.Add(gameNode.InnerText);
                            }
                        }
                    }
                }
            }
            return games;
        }

        public string GetPlaytime(string game)
        {
            bool rightGame = false;
            foreach (XmlNode gamesNode in xml.DocumentElement.ChildNodes)
            {
                if (gamesNode.Name == "games")
                {
                    foreach (XmlNode messageNode in gamesNode.ChildNodes)
                    {
                        foreach (XmlNode gameNode in messageNode)
                        {
                            if (gameNode.Name == "name")
                            {
                                if (gameNode.InnerText.ToString() == game)
                                {
                                    rightGame = true;
                                }
                            }
                            else if (gameNode.Name == "playtime_forever" && rightGame)
                            {
                                return gameNode.InnerText;
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
