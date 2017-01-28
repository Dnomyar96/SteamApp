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

        private void LoadXml(string api, string id)
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
        }

        public string GetPlayerName(string api, string id)
        {
            LoadXml(api, id);

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

        public string GetAvatarUrl(string api, string id)
        {
            LoadXml(api, id);

            string url = "";
            foreach (XmlNode playersNode in xml.DocumentElement.ChildNodes)
            {
                if (playersNode.Name == "players")
                {
                    foreach (XmlNode playerNode in playersNode.ChildNodes)
                    {
                        foreach (XmlNode avatarNode in playerNode)
                        {
                            if (avatarNode.Name == "avatarmedium")
                            {
                                url = avatarNode.InnerText;
                            }
                        }
                    }
                }
            }
            return url;
        }
    }
}
