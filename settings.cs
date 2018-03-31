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
            InitializeComponent();
            BackColor = Color.FromName(global.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                global.BackColor = textBoxColour.Text;
                this.BackColor = Color.FromName(global.BackColor);
            }
            catch { }
        }

        private void textBoxColour_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Colour_info_box colourInfo = new Colour_info_box();
            colourInfo.ShowDialog();
        }
    }
}
