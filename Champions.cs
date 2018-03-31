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
            BackColor = Color.FromName(global.BackColor);
            fill_listbox();
        }
            void fill_listbox()
        {
            var myChampionList = updatedb.championList().OrderBy(o => o.name);//creates alphabetical list of every champion in database
            //listBoxChampionNames.DataSource = myChampionList.ToString();
            foreach (tblChampionMetaData c in myChampionList)
            {
                listBoxChampionNames.Items.Add(c.name.Trim());
            }
        }
        void filter_listbox(string searchName)
        {
            listBoxChampionNames.Items.Clear();
            var myChampionList = updatedb.championList().OrderBy(o => o.name).ToList() ;//creates alphabetical list of every champion in database
            foreach (tblChampionMetaData c in myChampionList.ToList())
            {
                if (!c.name.ToLower().Contains(searchName.ToLower()))
                {
                    myChampionList.Remove(c);
                }
                else
                    listBoxChampionNames.Items.Add(c.name.Trim());
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
            try
            {
                string myName = null;
                myName = listBoxChampionNames.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(myName))
                {
                    champViewer test = new champViewer(myName);
                    test.Show();
                }
            }
            catch(System.NullReferenceException)
            {
                Empty_warning error = new Empty_warning();
                System.Media.SystemSounds.Hand.Play();
                error.ShowDialog();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
        }

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            filter_listbox(textBoxSearch.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
