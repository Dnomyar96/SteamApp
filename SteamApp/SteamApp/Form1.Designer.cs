namespace SteamApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gamesBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.gamesList = new System.Windows.Forms.ListBox();
            this.gameBox = new System.Windows.Forms.GroupBox();
            this.playtimeLbl = new System.Windows.Forms.Label();
            this.gameNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gamesBox.SuspendLayout();
            this.gameBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesBox
            // 
            this.gamesBox.Controls.Add(this.label1);
            this.gamesBox.Controls.Add(this.searchBox);
            this.gamesBox.Controls.Add(this.gamesList);
            this.gamesBox.Location = new System.Drawing.Point(13, 13);
            this.gamesBox.Name = "gamesBox";
            this.gamesBox.Size = new System.Drawing.Size(370, 263);
            this.gamesBox.TabIndex = 0;
            this.gamesBox.TabStop = false;
            this.gamesBox.Text = "Games";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(248, 36);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(116, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // gamesList
            // 
            this.gamesList.FormattingEnabled = true;
            this.gamesList.Location = new System.Drawing.Point(7, 20);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(231, 238);
            this.gamesList.TabIndex = 0;
            this.gamesList.SelectedIndexChanged += new System.EventHandler(this.gamesList_SelectedIndexChanged);
            // 
            // gameBox
            // 
            this.gameBox.Controls.Add(this.playtimeLbl);
            this.gameBox.Controls.Add(this.gameNameLbl);
            this.gameBox.Controls.Add(this.label3);
            this.gameBox.Controls.Add(this.label2);
            this.gameBox.Location = new System.Drawing.Point(390, 13);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(295, 258);
            this.gameBox.TabIndex = 1;
            this.gameBox.TabStop = false;
            this.gameBox.Text = "Game";
            // 
            // playtimeLbl
            // 
            this.playtimeLbl.AutoSize = true;
            this.playtimeLbl.Location = new System.Drawing.Point(88, 39);
            this.playtimeLbl.Name = "playtimeLbl";
            this.playtimeLbl.Size = new System.Drawing.Size(0, 13);
            this.playtimeLbl.TabIndex = 3;
            // 
            // gameNameLbl
            // 
            this.gameNameLbl.AutoSize = true;
            this.gameNameLbl.Location = new System.Drawing.Point(88, 20);
            this.gameNameLbl.Name = "gameNameLbl";
            this.gameNameLbl.Size = new System.Drawing.Size(99, 13);
            this.gameNameLbl.TabIndex = 2;
            this.gameNameLbl.Text = "[No game selected]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Playtime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 288);
            this.Controls.Add(this.gameBox);
            this.Controls.Add(this.gamesBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gamesBox.ResumeLayout(false);
            this.gamesBox.PerformLayout();
            this.gameBox.ResumeLayout(false);
            this.gameBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gamesBox;
        private System.Windows.Forms.ListBox gamesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.GroupBox gameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gameNameLbl;
        private System.Windows.Forms.Label playtimeLbl;
    }
}

