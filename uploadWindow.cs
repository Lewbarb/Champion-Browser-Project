﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionBrowser
{
    public partial class uploadWindow : Form
    {
        public uploadWindow()
        {
            InitializeComponent();
        }

        private void lblPassive_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            champion result = updatedb.searchDB(name);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxChampionImage_Click(object sender, EventArgs e)
        {

        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            pictureBoxChampionImage.Load(textBoxIMGURL.Text);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var db = updatedb.championList();
            foreach (champion c in db)
            {
                Console.WriteLine(c.name);
            }
        }
    }
}
