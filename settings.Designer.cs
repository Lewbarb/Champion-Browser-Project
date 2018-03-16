namespace ChampionBrowser
{
    partial class settings
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
            this.buttonDark = new System.Windows.Forms.Button();
            this.textBoxColour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDark
            // 
            this.buttonDark.Location = new System.Drawing.Point(12, 39);
            this.buttonDark.Name = "buttonDark";
            this.buttonDark.Size = new System.Drawing.Size(78, 28);
            this.buttonDark.TabIndex = 0;
            this.buttonDark.Text = "Set Colour";
            this.buttonDark.UseVisualStyleBackColor = true;
            this.buttonDark.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxColour
            // 
            this.textBoxColour.Location = new System.Drawing.Point(97, 131);
            this.textBoxColour.Name = "textBoxColour";
            this.textBoxColour.Size = new System.Drawing.Size(100, 20);
            this.textBoxColour.TabIndex = 1;
            this.textBoxColour.TextChanged += new System.EventHandler(this.textBoxColour_TextChanged);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxColour);
            this.Controls.Add(this.buttonDark);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDark;
        private System.Windows.Forms.TextBox textBoxColour;
    }
}