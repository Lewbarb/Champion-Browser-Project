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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromName(global.BackColor);
        }

        private void labeExamle1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChamps_Click(object sender, EventArgs e)
        {
            Champions champ = new Champions();
            champ.Show();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settings setting = new settings();
            setting.Show();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDark_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void buttonLight_Click(object sender, EventArgs e)
        {
            //settings.DefaultBackColor = Color.Lavender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string passive;
            int basead;
            //updatedb.pushDB(name, passive, basead);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //updatedb.selectDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //updatedb.pushDB();
        }

        private void btnOpenSearch_Click(object sender, EventArgs e)
        {
            uploadWindow window = new uploadWindow();
            window.Show();
        }
    }
}
