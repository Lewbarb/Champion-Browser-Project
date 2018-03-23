namespace ChampionBrowser
{
    partial class SearchWindow
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
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassive = new System.Windows.Forms.Label();
            this.lblBluePrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(56, 91);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchName.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(56, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(252, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblPassive
            // 
            this.lblPassive.AutoSize = true;
            this.lblPassive.Location = new System.Drawing.Point(252, 78);
            this.lblPassive.Name = "lblPassive";
            this.lblPassive.Size = new System.Drawing.Size(44, 13);
            this.lblPassive.TabIndex = 3;
            this.lblPassive.Text = "Passive";
            this.lblPassive.Click += new System.EventHandler(this.lblPassive_Click);
            // 
            // lblBluePrice
            // 
            this.lblBluePrice.AutoSize = true;
            this.lblBluePrice.Location = new System.Drawing.Point(252, 98);
            this.lblBluePrice.Name = "lblBluePrice";
            this.lblBluePrice.Size = new System.Drawing.Size(52, 13);
            this.lblBluePrice.TabIndex = 4;
            this.lblBluePrice.Text = "BluePrice";
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBluePrice);
            this.Controls.Add(this.lblPassive);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearchName);
            this.Name = "SearchWindow";
            this.Text = "SearchWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassive;
        private System.Windows.Forms.Label lblBluePrice;
    }
}