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
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void lblPassive_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchName.Text;
            champion result = updatedb.searchDB(name);
            lblName.Text = result.name;
            lblBluePrice.Text = result.bluePrice.ToString();
            lblPassive.Text = result.passive;
        }
    }
}
