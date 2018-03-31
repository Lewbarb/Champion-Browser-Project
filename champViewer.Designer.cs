namespace ChampionBrowser
{
    partial class champViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(champViewer));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxHP = new System.Windows.Forms.TextBox();
            this.textBoxHPRegen = new System.Windows.Forms.TextBox();
            this.textBoxMana = new System.Windows.Forms.TextBox();
            this.textBoxManaRegen = new System.Windows.Forms.TextBox();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.textBoxBaseAD = new System.Windows.Forms.TextBox();
            this.textBoxBaseattackspeed = new System.Windows.Forms.TextBox();
            this.textBoxBasearmour = new System.Windows.Forms.TextBox();
            this.textBoxBaseMR = new System.Windows.Forms.TextBox();
            this.textBoxIMGURL = new System.Windows.Forms.TextBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.textBoxBaseSpeed = new System.Windows.Forms.TextBox();
            this.textBoxBluePrice = new System.Windows.Forms.TextBox();
            this.textBoxRPCost = new System.Windows.Forms.TextBox();
            this.textBoxPassive = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblBaseHP = new System.Windows.Forms.Label();
            this.lblBaseMana = new System.Windows.Forms.Label();
            this.lblBaseManaRegen = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblBaseAD = new System.Windows.Forms.Label();
            this.lblBaseAttackSpeed = new System.Windows.Forms.Label();
            this.lblBaseArmour = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHPRegen = new System.Windows.Forms.Label();
            this.lblBluePrice = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.pictureBoxChampionImage = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 270);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Name";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxHP
            // 
            this.textBoxHP.Location = new System.Drawing.Point(100, 296);
            this.textBoxHP.Name = "textBoxHP";
            this.textBoxHP.Size = new System.Drawing.Size(100, 20);
            this.textBoxHP.TabIndex = 2;
            this.textBoxHP.Text = "Base HP";
            this.textBoxHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxHPRegen
            // 
            this.textBoxHPRegen.Location = new System.Drawing.Point(100, 322);
            this.textBoxHPRegen.Name = "textBoxHPRegen";
            this.textBoxHPRegen.Size = new System.Drawing.Size(100, 20);
            this.textBoxHPRegen.TabIndex = 3;
            this.textBoxHPRegen.Text = "Base HP Regen";
            this.textBoxHPRegen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMana
            // 
            this.textBoxMana.Location = new System.Drawing.Point(100, 348);
            this.textBoxMana.Name = "textBoxMana";
            this.textBoxMana.Size = new System.Drawing.Size(100, 20);
            this.textBoxMana.TabIndex = 4;
            this.textBoxMana.Tag = "";
            this.textBoxMana.Text = "Base Mana";
            this.textBoxMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxManaRegen
            // 
            this.textBoxManaRegen.Location = new System.Drawing.Point(100, 374);
            this.textBoxManaRegen.Name = "textBoxManaRegen";
            this.textBoxManaRegen.Size = new System.Drawing.Size(100, 20);
            this.textBoxManaRegen.TabIndex = 5;
            this.textBoxManaRegen.Text = "Base Mana Regen";
            this.textBoxManaRegen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(100, 402);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(100, 20);
            this.textBoxRange.TabIndex = 6;
            this.textBoxRange.Text = "Range";
            this.textBoxRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBaseAD
            // 
            this.textBoxBaseAD.Location = new System.Drawing.Point(100, 428);
            this.textBoxBaseAD.Name = "textBoxBaseAD";
            this.textBoxBaseAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaseAD.TabIndex = 7;
            this.textBoxBaseAD.Text = "Base AD";
            this.textBoxBaseAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBaseattackspeed
            // 
            this.textBoxBaseattackspeed.Location = new System.Drawing.Point(100, 454);
            this.textBoxBaseattackspeed.Name = "textBoxBaseattackspeed";
            this.textBoxBaseattackspeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaseattackspeed.TabIndex = 8;
            this.textBoxBaseattackspeed.Text = "Base Attack Speed";
            this.textBoxBaseattackspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBasearmour
            // 
            this.textBoxBasearmour.Location = new System.Drawing.Point(100, 480);
            this.textBoxBasearmour.Name = "textBoxBasearmour";
            this.textBoxBasearmour.Size = new System.Drawing.Size(100, 20);
            this.textBoxBasearmour.TabIndex = 9;
            this.textBoxBasearmour.Text = "Base Armour";
            this.textBoxBasearmour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBaseMR
            // 
            this.textBoxBaseMR.Location = new System.Drawing.Point(206, 480);
            this.textBoxBaseMR.Name = "textBoxBaseMR";
            this.textBoxBaseMR.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaseMR.TabIndex = 10;
            this.textBoxBaseMR.Text = "Base MR";
            this.textBoxBaseMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIMGURL
            // 
            this.textBoxIMGURL.Location = new System.Drawing.Point(152, 509);
            this.textBoxIMGURL.Name = "textBoxIMGURL";
            this.textBoxIMGURL.Size = new System.Drawing.Size(100, 20);
            this.textBoxIMGURL.TabIndex = 11;
            this.textBoxIMGURL.Text = "Image URL";
            this.textBoxIMGURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(165, 535);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 23);
            this.btnImg.TabIndex = 13;
            this.btnImg.Text = "Check URL";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // textBoxBaseSpeed
            // 
            this.textBoxBaseSpeed.Location = new System.Drawing.Point(206, 270);
            this.textBoxBaseSpeed.Name = "textBoxBaseSpeed";
            this.textBoxBaseSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaseSpeed.TabIndex = 17;
            this.textBoxBaseSpeed.Text = "Base Speed";
            this.textBoxBaseSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBluePrice
            // 
            this.textBoxBluePrice.Location = new System.Drawing.Point(206, 296);
            this.textBoxBluePrice.Name = "textBoxBluePrice";
            this.textBoxBluePrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxBluePrice.TabIndex = 18;
            this.textBoxBluePrice.Text = "Blue Essence Cost";
            this.textBoxBluePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRPCost
            // 
            this.textBoxRPCost.Location = new System.Drawing.Point(206, 322);
            this.textBoxRPCost.Name = "textBoxRPCost";
            this.textBoxRPCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxRPCost.TabIndex = 19;
            this.textBoxRPCost.Text = "Riot Points Cost";
            this.textBoxRPCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPassive
            // 
            this.textBoxPassive.Location = new System.Drawing.Point(206, 348);
            this.textBoxPassive.Name = "textBoxPassive";
            this.textBoxPassive.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassive.TabIndex = 20;
            this.textBoxPassive.Text = "Passive";
            this.textBoxPassive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(206, 374);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ.TabIndex = 21;
            this.textBoxQ.Text = "Q";
            this.textBoxQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(206, 402);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(100, 20);
            this.textBoxW.TabIndex = 22;
            this.textBoxW.Text = "W";
            this.textBoxW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(206, 428);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(100, 20);
            this.textBoxE.TabIndex = 23;
            this.textBoxE.Text = "E";
            this.textBoxE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(206, 454);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 24;
            this.textBoxR.Text = "R";
            this.textBoxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(165, 564);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(31, 270);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Name";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.ForeColor = System.Drawing.Color.White;
            this.lblHP.Location = new System.Drawing.Point(37, 296);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 13);
            this.lblHP.TabIndex = 29;
            this.lblHP.Text = "HP";
            // 
            // lblBaseHP
            // 
            this.lblBaseHP.AutoSize = true;
            this.lblBaseHP.ForeColor = System.Drawing.Color.White;
            this.lblBaseHP.Location = new System.Drawing.Point(20, 322);
            this.lblBaseHP.Name = "lblBaseHP";
            this.lblBaseHP.Size = new System.Drawing.Size(57, 13);
            this.lblBaseHP.TabIndex = 30;
            this.lblBaseHP.Text = "HP Regen";
            this.lblBaseHP.Click += new System.EventHandler(this.lblBaseHP_Click);
            // 
            // lblBaseMana
            // 
            this.lblBaseMana.AutoSize = true;
            this.lblBaseMana.ForeColor = System.Drawing.Color.White;
            this.lblBaseMana.Location = new System.Drawing.Point(31, 348);
            this.lblBaseMana.Name = "lblBaseMana";
            this.lblBaseMana.Size = new System.Drawing.Size(34, 13);
            this.lblBaseMana.TabIndex = 31;
            this.lblBaseMana.Text = "Mana";
            // 
            // lblBaseManaRegen
            // 
            this.lblBaseManaRegen.AutoSize = true;
            this.lblBaseManaRegen.ForeColor = System.Drawing.Color.White;
            this.lblBaseManaRegen.Location = new System.Drawing.Point(14, 374);
            this.lblBaseManaRegen.Name = "lblBaseManaRegen";
            this.lblBaseManaRegen.Size = new System.Drawing.Size(69, 13);
            this.lblBaseManaRegen.TabIndex = 32;
            this.lblBaseManaRegen.Text = "Mana Regen";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.ForeColor = System.Drawing.Color.White;
            this.lblRange.Location = new System.Drawing.Point(29, 400);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(39, 13);
            this.lblRange.TabIndex = 33;
            this.lblRange.Text = "Range";
            // 
            // lblBaseAD
            // 
            this.lblBaseAD.AutoSize = true;
            this.lblBaseAD.ForeColor = System.Drawing.Color.White;
            this.lblBaseAD.Location = new System.Drawing.Point(37, 426);
            this.lblBaseAD.Name = "lblBaseAD";
            this.lblBaseAD.Size = new System.Drawing.Size(22, 13);
            this.lblBaseAD.TabIndex = 34;
            this.lblBaseAD.Text = "AD";
            // 
            // lblBaseAttackSpeed
            // 
            this.lblBaseAttackSpeed.AutoSize = true;
            this.lblBaseAttackSpeed.ForeColor = System.Drawing.Color.White;
            this.lblBaseAttackSpeed.Location = new System.Drawing.Point(12, 452);
            this.lblBaseAttackSpeed.Name = "lblBaseAttackSpeed";
            this.lblBaseAttackSpeed.Size = new System.Drawing.Size(72, 13);
            this.lblBaseAttackSpeed.TabIndex = 35;
            this.lblBaseAttackSpeed.Text = "Attack Speed";
            // 
            // lblBaseArmour
            // 
            this.lblBaseArmour.AutoSize = true;
            this.lblBaseArmour.ForeColor = System.Drawing.Color.White;
            this.lblBaseArmour.Location = new System.Drawing.Point(28, 478);
            this.lblBaseArmour.Name = "lblBaseArmour";
            this.lblBaseArmour.Size = new System.Drawing.Size(40, 13);
            this.lblBaseArmour.TabIndex = 36;
            this.lblBaseArmour.Text = "Armour";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(171, 254);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 13);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "LEVEL 1 STATS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "MR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(349, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "R";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(349, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "E";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(347, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "W";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(349, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Q";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(334, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Passive";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblHPRegen
            // 
            this.lblHPRegen.AutoSize = true;
            this.lblHPRegen.ForeColor = System.Drawing.Color.White;
            this.lblHPRegen.Location = new System.Drawing.Point(327, 325);
            this.lblHPRegen.Name = "lblHPRegen";
            this.lblHPRegen.Size = new System.Drawing.Size(58, 13);
            this.lblHPRegen.TabIndex = 40;
            this.lblHPRegen.Text = "Riot Points";
            this.lblHPRegen.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblBluePrice
            // 
            this.lblBluePrice.AutoSize = true;
            this.lblBluePrice.ForeColor = System.Drawing.Color.White;
            this.lblBluePrice.Location = new System.Drawing.Point(320, 299);
            this.lblBluePrice.Name = "lblBluePrice";
            this.lblBluePrice.Size = new System.Drawing.Size(72, 13);
            this.lblBluePrice.TabIndex = 39;
            this.lblBluePrice.Text = "Blue Essence";
            this.lblBluePrice.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(337, 273);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 38;
            this.lblSpeed.Text = "Speed";
            this.lblSpeed.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBoxChampionImage
            // 
            this.pictureBoxChampionImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxChampionImage.Name = "pictureBoxChampionImage";
            this.pictureBoxChampionImage.Size = new System.Drawing.Size(379, 207);
            this.pictureBoxChampionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChampionImage.TabIndex = 12;
            this.pictureBoxChampionImage.TabStop = false;
            this.pictureBoxChampionImage.Click += new System.EventHandler(this.pictureBoxChampionImage_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = global::ChampionBrowser.Properties.Resources.info;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.Location = new System.Drawing.Point(362, 225);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.TabIndex = 47;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // champViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(403, 591);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHPRegen);
            this.Controls.Add(this.lblBluePrice);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBaseArmour);
            this.Controls.Add(this.lblBaseAttackSpeed);
            this.Controls.Add(this.lblBaseAD);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblBaseManaRegen);
            this.Controls.Add(this.lblBaseMana);
            this.Controls.Add(this.lblBaseHP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxPassive);
            this.Controls.Add(this.textBoxRPCost);
            this.Controls.Add(this.textBoxBluePrice);
            this.Controls.Add(this.textBoxBaseSpeed);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.pictureBoxChampionImage);
            this.Controls.Add(this.textBoxIMGURL);
            this.Controls.Add(this.textBoxBaseMR);
            this.Controls.Add(this.textBoxBasearmour);
            this.Controls.Add(this.textBoxBaseattackspeed);
            this.Controls.Add(this.textBoxBaseAD);
            this.Controls.Add(this.textBoxRange);
            this.Controls.Add(this.textBoxManaRegen);
            this.Controls.Add(this.textBoxMana);
            this.Controls.Add(this.textBoxHPRegen);
            this.Controls.Add(this.textBoxHP);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "champViewer";
            this.Text = "View & Edit Champion";
            this.Load += new System.EventHandler(this.champViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        //public System.Windows.Forms.TextBox textBoxName { get; set; }//ctrl+f
        private System.Windows.Forms.TextBox textBoxHP;
        private System.Windows.Forms.TextBox textBoxHPRegen;
        private System.Windows.Forms.TextBox textBoxMana;
        private System.Windows.Forms.TextBox textBoxManaRegen;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.TextBox textBoxBaseAD;
        private System.Windows.Forms.TextBox textBoxBaseattackspeed;
        private System.Windows.Forms.TextBox textBoxBasearmour;
        private System.Windows.Forms.TextBox textBoxBaseMR;
        private System.Windows.Forms.TextBox textBoxIMGURL;
        private System.Windows.Forms.PictureBox pictureBoxChampionImage;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.TextBox textBoxBaseSpeed;
        private System.Windows.Forms.TextBox textBoxBluePrice;
        private System.Windows.Forms.TextBox textBoxRPCost;
        private System.Windows.Forms.TextBox textBoxPassive;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblBaseHP;
        private System.Windows.Forms.Label lblBaseMana;
        private System.Windows.Forms.Label lblBaseManaRegen;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblBaseAD;
        private System.Windows.Forms.Label lblBaseAttackSpeed;
        private System.Windows.Forms.Label lblBaseArmour;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHPRegen;
        private System.Windows.Forms.Label lblBluePrice;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnInfo;
        /*public System.Windows.Forms.TextBox textBoxName { get; set; }
public System.Windows.Forms.TextBox textBoxHP { get; set; }
public System.Windows.Forms.TextBox textBoxHPRegen { get; set; }
public System.Windows.Forms.TextBox textBoxMana { get; set; }
public System.Windows.Forms.TextBox textBoxManaRegen { get; set; }
public System.Windows.Forms.TextBox textBoxRange { get; set; }
public System.Windows.Forms.TextBox textBoxBaseAD { get; set; }
public System.Windows.Forms.TextBox textBoxBaseattackspeed { get; set; }
public System.Windows.Forms.TextBox textBoxBasearmour { get; set; }
public System.Windows.Forms.TextBox textBoxBaseMR { get; set; }
public System.Windows.Forms.TextBox textBoxIMGURL { get; set; }
public System.Windows.Forms.PictureBox pictureBoxChampionImage { get; set; }
public System.Windows.Forms.Button btnImg { get; set; }
public System.Windows.Forms.Button btnTest { get; set; }
public System.Windows.Forms.Button btnUpload { get; set; }
public System.Windows.Forms.TextBox textBoxBaseSpeed { get; set; }
public System.Windows.Forms.TextBox textBoxBluePrice { get; set; }
public System.Windows.Forms.TextBox textBoxRPCost { get; set; }
public System.Windows.Forms.TextBox textBoxPassive { get; set; }
public System.Windows.Forms.TextBox textBoxQ { get; set; }
public System.Windows.Forms.TextBox textBoxW { get; set; }
public System.Windows.Forms.TextBox textBoxE { get; set; }
public System.Windows.Forms.TextBox textBoxR { get; set; }
public System.Windows.Forms.Button btnDelete { get; set; }
public System.Windows.Forms.Button btnSearch { get; set; }
public System.Windows.Forms.Button btnEdit { get; set; }*/
    }
}