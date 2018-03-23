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
    public partial class Champions : Form
    {
        public Champions()
        {
            InitializeComponent();
            {
                BackColor = Color.FromName(global.BackColor);
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            
            homeForm newHome = new homeForm();
            newHome.Show();
            //this.Hide();
            this.Close();
        }

        private void textboxImage0_TextChanged(object sender, EventArgs e)
        {
            //var champion = updatedb.getDB();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //updatedb.selectDBtest();

        }
    }
}
