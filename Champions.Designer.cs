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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxChampionNames = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // listBoxChampionNames
            // 
            this.listBoxChampionNames.FormattingEnabled = true;
            this.listBoxChampionNames.Location = new System.Drawing.Point(12, 12);
            this.listBoxChampionNames.Name = "listBoxChampionNames";
            this.listBoxChampionNames.Size = new System.Drawing.Size(163, 264);
            this.listBoxChampionNames.TabIndex = 2;
            this.listBoxChampionNames.SelectedIndexChanged += new System.EventHandler(this.listBoxChampionNames_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(181, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "View and Edit";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(181, 67);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(85, 20);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged_1);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Location = new System.Drawing.Point(181, 51);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // Champions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(274, 298);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.listBoxChampionNames);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Champions";
            this.Text = "Champions";
            this.Load += new System.EventHandler(this.Champions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxChampionNames;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}