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
    public partial class champViewer : Form
    {
        public string text_Name { get; set; }
        void fillData(string CreatorName)
        {
            var champ = updatedb.searchDB(CreatorName);
            textBoxName.Text = champ.name.Trim();
            textBoxIMGURL.Text = champ.imageLink;
            try
            {
                pictureBoxChampionImage.Load(champ.imageLink);
            }catch { }
            textBoxHP.Text = champ.basehp.ToString();
            textBoxHPRegen.Text = champ.basehp.ToString();
            textBoxMana.Text = champ.basemana.ToString();
            textBoxManaRegen.Text = champ.basemanaregen.ToString();
            textBoxRange.Text = champ.range.ToString();
            textBoxBaseAD.Text = champ.basead.ToString();
            textBoxBaseattackspeed.Text = champ.baseattackspeed.ToString();
            textBoxBasearmour.Text = champ.basearmour.ToString();
            textBoxBaseMR.Text = champ.basemr.ToString();
            textBoxBaseSpeed.Text = champ.basespeed.ToString();
            textBoxBluePrice.Text = champ.bluePrice.ToString();
            textBoxRPCost.Text = champ.rpPrice.ToString();
            textBoxPassive.Text = champ.passive.Trim();
            textBoxQ.Text = champ.Q.Trim();
            textBoxW.Text = champ.W.Trim();
            textBoxE.Text = champ.E.Trim();
            textBoxR.Text = champ.R.Trim();
        }

        public champViewer(string CreatorName)
        {
            InitializeComponent();
            //this.textBoxName.Text = CreatorName;
            fillData(CreatorName);
        }
        public string label_Name_Text
        {
            get
            {
                return this.label_Name_Text;
            }
            set
            {
                this.label_Name_Text = value;
            }
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

        /*private void btnTest_Click(object sender, EventArgs e)
        {
            var db = updatedb.championList();
            foreach (tblChampionMetaData c in db)
            {
                Console.WriteLine(c.name);
            }
        }*/






        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.TrimEnd();
                int hp = Int32.Parse(textBoxHP.Text);
                int hpregen = Int32.Parse(textBoxHPRegen.Text);
                int mana = Int32.Parse(textBoxMana.Text);
                int manaregen = Int32.Parse(textBoxManaRegen.Text);
                int range = Int32.Parse(textBoxRange.Text);
                int ad = Int32.Parse(textBoxBaseAD.Text);
                int armour = Int32.Parse(textBoxBasearmour.Text);
                float attackspeed = float.Parse(textBoxBaseattackspeed.Text);
                int mr = Int32.Parse(textBoxBaseMR.Text);
                int speed = Int32.Parse(textBoxBaseSpeed.Text);
                int bluePrice = Int32.Parse(textBoxBluePrice.Text);
                int rpPrice = Int32.Parse(textBoxRPCost.Text);
                string passive = textBoxPassive.Text.TrimEnd();
                string Q = textBoxQ.Text.TrimEnd();
                string W = textBoxW.Text.TrimEnd();
                string E = textBoxE.Text.TrimEnd();
                string R = textBoxR.Text.TrimEnd();
                string imageLink = textBoxIMGURL.Text.TrimEnd();
                if (passive.Length <= 25 &&
                    Q.Length <= 25 &&
                    W.Length <= 25 &&
                    E.Length <= 25 &&
                    R.Length <= 25 &&
                    imageLink.Length <= 200)
                    updatedb.editRecord(name, hp, hpregen, mana, manaregen, range, ad, attackspeed, armour, mr, speed, bluePrice, rpPrice, Q, W, E, R, passive, imageLink);
            }
            catch { }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void champViewer_Load(object sender, EventArgs e)
        {

        }

        private void lblBaseHP_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Upload_Info_Box infobox = new Upload_Info_Box();
            infobox.ShowDialog();
        }
    }
}
