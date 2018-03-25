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

        public static string text_Name { get; set; }
        public Champions()
        {
            InitializeComponent();
            {
                BackColor = Color.FromName(global.BackColor);
                fill_listbox();
            }
        }
        void fill_listbox()
        {
            var myChampionList = updatedb.championList().OrderBy(o => o.name);//creates alphabetical list of every champion in database
            //listBoxChampionNames.DataSource = myChampionList.ToString();
            foreach (champion c in myChampionList)
            {
                listBoxChampionNames.Items.Add(c.name);
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


        private void Champions_Load(object sender, EventArgs e)
        {

        }

        private void listBoxChampionNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string myName = listBoxChampionNames.SelectedItem.ToString();
            champViewer test = new champViewer(myName);
            test.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string myName = listBoxChampionNames.SelectedItem.ToString();
            champViewer test = new champViewer(myName);
            test.Show();
        }
    }
}
