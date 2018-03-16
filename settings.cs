using System;
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
    public partial class settings : Form
    {
        public settings()
        {
            BackColor = Color.FromName(global.BackColor);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                global.BackColor = textBoxColour.Text;
            }
            catch { }
            this.BackColor = Color.FromName(global.BackColor);
            //Champions.DefaultBackColor = Color.FromName(global.BackColor);
        }

        private void textBoxColour_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
