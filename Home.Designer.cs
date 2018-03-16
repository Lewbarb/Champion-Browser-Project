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
            this.labeExamle1 = new System.Windows.Forms.Label();
            this.buttonChamps = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonDark = new System.Windows.Forms.Button();
            this.buttonLight = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeExamle1
            // 
            this.labeExamle1.AutoSize = true;
            this.labeExamle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeExamle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.buttonChamps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChamps.Location = new System.Drawing.Point(36, 69);
            this.buttonChamps.Name = "buttonChamps";
            this.buttonChamps.Size = new System.Drawing.Size(91, 23);
            this.buttonChamps.TabIndex = 1;
            this.buttonChamps.Tag = "";
            this.buttonChamps.Text = "Champion DB";
            this.buttonChamps.UseVisualStyleBackColor = true;
            this.buttonChamps.Click += new System.EventHandler(this.buttonChamps_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(260, 69);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonDark
            // 
            this.buttonDark.Location = new System.Drawing.Point(0, 0);
            this.buttonDark.Name = "buttonDark";
            this.buttonDark.Size = new System.Drawing.Size(75, 23);
            this.buttonDark.TabIndex = 3;
            this.buttonDark.Text = "Dark";
            this.buttonDark.UseVisualStyleBackColor = true;
            this.buttonDark.Click += new System.EventHandler(this.buttonDark_Click);
            // 
            // buttonLight
            // 
            this.buttonLight.Location = new System.Drawing.Point(338, 0);
            this.buttonLight.Name = "buttonLight";
            this.buttonLight.Size = new System.Drawing.Size(75, 23);
            this.buttonLight.TabIndex = 4;
            this.buttonLight.Text = "Light";
            this.buttonLight.UseVisualStyleBackColor = true;
            this.buttonLight.Click += new System.EventHandler(this.buttonLight_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(284, 133);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 5;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(413, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.buttonLight);
            this.Controls.Add(this.buttonDark);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonChamps);
            this.Controls.Add(this.labeExamle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button buttonLight;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button button1;
    }
}

