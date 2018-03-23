namespace ChampionBrowser
{
    partial class Champions
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxImage0 = new System.Windows.Forms.TextBox();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 47);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(163, 23);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Text = "Search...";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1109, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(12, 12);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(75, 23);
            this.buttonGoBack.TabIndex = 2;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textboxImage0);
            this.panel1.Controls.Add(this.pictureBox0);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 400);
            this.panel1.TabIndex = 3;
            // 
            // textboxImage0
            // 
            this.textboxImage0.BackColor = System.Drawing.Color.Gray;
            this.textboxImage0.Location = new System.Drawing.Point(15, 163);
            this.textboxImage0.Name = "textboxImage0";
            this.textboxImage0.Size = new System.Drawing.Size(155, 20);
            this.textboxImage0.TabIndex = 1;
            this.textboxImage0.Text = "Kha\'Zix";
            this.textboxImage0.TextChanged += new System.EventHandler(this.textboxImage0_TextChanged);
            // 
            // pictureBox0
            // 
            this.pictureBox0.ImageLocation = "E:\\Uni\\Project\\images\\kha.png";
            this.pictureBox0.Location = new System.Drawing.Point(15, 13);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(155, 144);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox0.TabIndex = 0;
            this.pictureBox0.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(746, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find Lissandra";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button2_Click);
            // 
            // Champions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(940, 488);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "Champions";
            this.Text = "Champions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textboxImage0;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.Button btnFind;
    }
}