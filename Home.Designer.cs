namespace ChampionBrowser
{
    partial class homeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.labeExamle1 = new System.Windows.Forms.Label();
            this.buttonChamps = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonDark = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeExamle1
            // 
            this.labeExamle1.AutoSize = true;
            this.labeExamle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeExamle1.ForeColor = System.Drawing.Color.White;
            this.labeExamle1.Location = new System.Drawing.Point(117, 18);
            this.labeExamle1.Name = "labeExamle1";
            this.labeExamle1.Size = new System.Drawing.Size(171, 24);
            this.labeExamle1.TabIndex = 0;
            this.labeExamle1.Tag = "title";
            this.labeExamle1.Text = "Champion Browser";
            this.labeExamle1.Click += new System.EventHandler(this.labeExamle1_Click);
            // 
            // buttonChamps
            // 
            this.buttonChamps.BackColor = System.Drawing.Color.Gray;
            this.buttonChamps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChamps.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonChamps.ForeColor = System.Drawing.Color.White;
            this.buttonChamps.Location = new System.Drawing.Point(25, 101);
            this.buttonChamps.Name = "buttonChamps";
            this.buttonChamps.Size = new System.Drawing.Size(91, 23);
            this.buttonChamps.TabIndex = 1;
            this.buttonChamps.Tag = "";
            this.buttonChamps.Text = "Champion DB";
            this.buttonChamps.UseVisualStyleBackColor = false;
            this.buttonChamps.Click += new System.EventHandler(this.buttonChamps_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Gray;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(289, 101);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(99, 23);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Colour Picker";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonDark
            // 
            this.buttonDark.BackColor = System.Drawing.Color.Gray;
            this.buttonDark.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDark.ForeColor = System.Drawing.Color.White;
            this.buttonDark.Location = new System.Drawing.Point(0, 0);
            this.buttonDark.Name = "buttonDark";
            this.buttonDark.Size = new System.Drawing.Size(75, 23);
            this.buttonDark.TabIndex = 3;
            this.buttonDark.Text = "Dark";
            this.buttonDark.UseVisualStyleBackColor = false;
            this.buttonDark.Visible = false;
            this.buttonDark.Click += new System.EventHandler(this.buttonDark_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Gray;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(164, 101);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnOpenSearch_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(413, 234);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.buttonDark);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonChamps);
            this.Controls.Add(this.labeExamle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "homeForm";
            this.Text = "Champion Browser";
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeExamle1;
        private System.Windows.Forms.Button buttonChamps;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonDark;
        private System.Windows.Forms.Button btnUpload;
    }
}

