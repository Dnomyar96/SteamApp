using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamApp
{
    class SavedDataReader
    {
        string path;

        public SavedDataReader()
        {
            path = (AppDomain.CurrentDomain.BaseDirectory + "users.txt");
        }

        public ArrayList GetUsers()
        {
            ArrayList users = new ArrayList();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        users.Add(s);
                    }
                }
            }
            catch (Exception e)
            {
                
            }
            return users;
        }

        public bool SaveUser(string api, string id)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(api + ";" + id);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(api + ";" + id);
                }
            }
            return true;
        }
    }
}
