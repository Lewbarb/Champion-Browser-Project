namespace ChampionBrowser
{
    partial class uploadWindow
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
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.textBoxHP = new System.Windows.Forms.TextBox();
            this.textBoxHPRegen = new System.Windows.Forms.TextBox();
            this.textBoxMana = new System.Windows.Forms.TextBox();
            this.textBoxManaRegen = new System.Windows.Forms.TextBox();
            this.j = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBoxIMGURL = new System.Windows.Forms.TextBox();
            this.pictureBoxChampionImage = new System.Windows.Forms.PictureBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Name";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(130, 462);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxHP
            // 
            this.textBoxHP.Location = new System.Drawing.Point(12, 49);
            this.textBoxHP.Name = "textBoxHP";
            this.textBoxHP.Size = new System.Drawing.Size(100, 20);
            this.textBoxHP.TabIndex = 2;
            this.textBoxHP.Text = "Base HP";
            this.textBoxHP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxHPRegen
            // 
            this.textBoxHPRegen.Location = new System.Drawing.Point(12, 75);
            this.textBoxHPRegen.Name = "textBoxHPRegen";
            this.textBoxHPRegen.Size = new System.Drawing.Size(100, 20);
            this.textBoxHPRegen.TabIndex = 3;
            this.textBoxHPRegen.Text = "Base HP Regen";
            // 
            // textBoxMana
            // 
            this.textBoxMana.Location = new System.Drawing.Point(12, 101);
            this.textBoxMana.Name = "textBoxMana";
            this.textBoxMana.Size = new System.Drawing.Size(100, 20);
            this.textBoxMana.TabIndex = 4;
            this.textBoxMana.Tag = "";
            this.textBoxMana.Text = "Base Mana";
            // 
            // textBoxManaRegen
            // 
            this.textBoxManaRegen.Location = new System.Drawing.Point(12, 127);
            this.textBoxManaRegen.Name = "textBoxManaRegen";
            this.textBoxManaRegen.Size = new System.Drawing.Size(100, 20);
            this.textBoxManaRegen.TabIndex = 5;
            this.textBoxManaRegen.Text = "Base Mana Regen";
            // 
            // j
            // 
            this.j.Location = new System.Drawing.Point(12, 155);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(100, 20);
            this.j.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 181);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 207);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 233);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(12, 259);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 10;
            // 
            // textBoxIMGURL
            // 
            this.textBoxIMGURL.Location = new System.Drawing.Point(177, 301);
            this.textBoxIMGURL.Name = "textBoxIMGURL";
            this.textBoxIMGURL.Size = new System.Drawing.Size(100, 20);
            this.textBoxIMGURL.TabIndex = 11;
            this.textBoxIMGURL.Text = "Image URL";
            this.textBoxIMGURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxChampionImage
            // 
            this.pictureBoxChampionImage.Location = new System.Drawing.Point(177, 338);
            this.pictureBoxChampionImage.Name = "pictureBoxChampionImage";
            this.pictureBoxChampionImage.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxChampionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChampionImage.TabIndex = 12;
            this.pictureBoxChampionImage.TabStop = false;
            this.pictureBoxChampionImage.Click += new System.EventHandler(this.pictureBoxChampionImage_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(188, 394);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 23);
            this.btnImg.TabIndex = 13;
            this.btnImg.Text = "Check";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(187, 23);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // uploadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 497);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.pictureBoxChampionImage);
            this.Controls.Add(this.textBoxIMGURL);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.j);
            this.Controls.Add(this.textBoxManaRegen);
            this.Controls.Add(this.textBoxMana);
            this.Controls.Add(this.textBoxHPRegen);
            this.Controls.Add(this.textBoxHP);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.textBoxName);
            this.Name = "uploadWindow";
            this.Text = "SearchWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChampionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox textBoxHP;
        private System.Windows.Forms.TextBox textBoxHPRegen;
        private System.Windows.Forms.TextBox textBoxMana;
        private System.Windows.Forms.TextBox textBoxManaRegen;
        private System.Windows.Forms.TextBox j;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBoxIMGURL;
        private System.Windows.Forms.PictureBox pictureBoxChampionImage;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnTest;
    }
}