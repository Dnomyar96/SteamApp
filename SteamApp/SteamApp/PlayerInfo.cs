using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SteamApp
{
    class PlayerInfo
    {
        private XmlDocument xml;
        public PlayerInfo()
        {
            xml = new XmlDocument();
        }

        public string GetPlayerName(string api, string id)
        {
            try
            {
                xml.Load("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=" +
                         api + "&steamids=" + id + "&format=xml");
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't connect to the Steam servers. Please check your connection.");
            }

            string name = "";
            foreach (XmlNode playersNode in xml.DocumentElement.ChildNodes)
            {
                if (playersNode.Name == "players")
                {
                    foreach (XmlNode playerNode in playersNode.ChildNodes)
                    {
                        foreach (XmlNode infoNode in playerNode)
                        {
                            if (infoNode.Name == "personaname")
                            {
                                name = infoNode.InnerText;
                            }
                        }
                    }
                }
            }
            return name;
        }
    }
}
