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
    public partial class uploadWindow : Form
    {
        public uploadWindow()
        {
            InitializeComponent();
        }

        private void lblPassive_Click(object sender, EventArgs e)
        {

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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int hp = Int32.Parse(textBoxHP.Text);
            int hpregen = Int32.Parse(textBoxHPRegen.Text);
            int mana = Int32.Parse(textBoxMana.Text);
            int manaregen = Int32.Parse(textBoxManaRegen.Text);
            int range = Int32.Parse(textBoxRange.Text);
            int ad = Int32.Parse(textBoxBaseAD.Text);
            float attackspeed = float.Parse(textBoxBaseattackspeed.Text);
            int armour = Int32.Parse(textBoxBasearmour.Text);
            int mr = Int32.Parse(textBoxBaseMR.Text);
            int speed = Int32.Parse(textBoxBaseSpeed.Text);
            int bluePrice = Int32.Parse(textBoxBluePrice.Text);
            int rpPrice = Int32.Parse(textBoxRPCost.Text);
            string passive = textBoxPassive.Text;
            string Q = textBoxQ.Text;
            string W = textBoxW.Text;
            string E = textBoxE.Text;
            string R = textBoxR.Text;
            string imageLink = textBoxIMGURL.Text;
            updatedb.pushDB(name, hp, hpregen, mana, manaregen, range, ad, attackspeed, armour, mr, speed, bluePrice, rpPrice, Q, W, E, R, passive, imageLink);
            //string name = textBoxName.Text;
            //champion result = updatedb.searchDB(name);
            //add an if check for string length
        }
    }
}
