using System;
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
    public partial class CompareSingleGame : Form
    {
        private Form1 main;

        public CompareSingleGame(Form1 main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (gameTxt.Text == "")
            {
                MessageBox.Show("Please enter a game title");
            }
            else
            {
                main.CompareSingleGame(gameTxt.Text);
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
