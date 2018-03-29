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
            if (textBoxName.Text != "Name")
            {
                updatedb.searchDB(textBoxName.Text);
            }
        }
        public string text_Name { get; set; }
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
            foreach (tblChampionMetaData c in db)
            {
                Console.WriteLine(c.name);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
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
                string passive = textBoxPassive.Text;
                string Q = textBoxQ.Text;
                string W = textBoxW.Text;
                string E = textBoxE.Text;
                string R = textBoxR.Text;
                string imageLink = textBoxIMGURL.Text;
                if (passive.Length <= 25 && 
                    Q.Length <= 25 && 
                    W.Length <= 25 &&  
                    E.Length <= 25 && 
                    R.Length <= 25)
                 updatedb.pushDB(name, hp, hpregen, mana, manaregen, range, ad, attackspeed, armour, mr, speed, bluePrice, rpPrice, Q, W, E, R, passive, imageLink);
                this.Close();   
            }catch { }
            //string name = textBoxName.Text;
            //champion result = updatedb.searchDB(name);
            //add an if check for string length
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            updatedb.deleteRecord(name);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            var champ = updatedb.searchDB(name);
            try
            {
                pictureBoxChampionImage.Load(champ.imageLink);
            }
            catch { }
            textBoxName.Text = champ.name.TrimEnd();
            textBoxIMGURL.Text = champ.imageLink;
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
            textBoxPassive.Text = champ.passive.TrimEnd();
            textBoxQ.Text = champ.Q.TrimEnd();
            textBoxW.Text = champ.W.TrimEnd();
            textBoxE.Text = champ.E.TrimEnd();
            textBoxR.Text = champ.R.TrimEnd();
        }

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
                    R.Length <= 25)
                    updatedb.editRecord(name, 
                                        hp, 
                                        hpregen,
                                        mana, 
                                        manaregen, 
                                        range, 
                                        ad, 
                                        attackspeed, 
                                        armour, 
                                        mr, 
                                        speed, 
                                        bluePrice, 
                                        rpPrice, 
                                        Q, 
                                        W, 
                                        E, 
                                        R, 
                                        passive, 
                                        imageLink);
            }
            catch { }
        }

        private void textBoxBaseSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
