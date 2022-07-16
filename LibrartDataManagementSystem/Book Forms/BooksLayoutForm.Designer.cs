
namespace LibrartDataManagementSystem
{
    partial class BooksLayoutForm
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
            this.pnl_sideNavigationBarBooks = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AddBooks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BrowseBooks = new System.Windows.Forms.Button();
            this.pnl_ContentBooks = new System.Windows.Forms.Panel();
            this.pnl_sideNavigationBarBooks.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sideNavigationBarBooks
            // 
            this.pnl_sideNavigationBarBooks.BackColor = System.Drawing.Color.Maroon;
            this.pnl_sideNavigationBarBooks.Controls.Add(this.panel2);
            this.pnl_sideNavigationBarBooks.Controls.Add(this.panel1);
            this.pnl_sideNavigationBarBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sideNavigationBarBooks.Location = new System.Drawing.Point(0, 0);
            this.pnl_sideNavigationBarBooks.Name = "pnl_sideNavigationBarBooks";
            this.pnl_sideNavigationBarBooks.Size = new System.Drawing.Size(228, 461);
            this.pnl_sideNavigationBarBooks.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.btn_AddBooks);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(48, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 40);
            this.panel2.TabIndex = 6;
            // 
            // btn_AddBooks
            // 
            this.btn_AddBooks.Location = new System.Drawing.Point(10, 4);
            this.btn_AddBooks.Name = "btn_AddBooks";
            this.btn_AddBooks.Size = new System.Drawing.Size(103, 31);
            this.btn_AddBooks.TabIndex = 1;
            this.btn_AddBooks.Text = "Add Books";
            this.btn_AddBooks.UseVisualStyleBackColor = true;
            this.btn_AddBooks.Click += new System.EventHandler(this.btn_AddBooks_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btn_BrowseBooks);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(48, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 40);
            this.panel1.TabIndex = 6;
            // 
            // btn_BrowseBooks
            // 
            this.btn_BrowseBooks.Location = new System.Drawing.Point(7, 3);
            this.btn_BrowseBooks.Name = "btn_BrowseBooks";
            this.btn_BrowseBooks.Size = new System.Drawing.Size(112, 32);
            this.btn_BrowseBooks.TabIndex = 0;
            this.btn_BrowseBooks.Text = "Browse Books";
            this.btn_BrowseBooks.UseVisualStyleBackColor = true;
            this.btn_BrowseBooks.Click += new System.EventHandler(this.btn_BrowseBooks_Click);
            // 
            // pnl_ContentBooks
            // 
            this.pnl_ContentBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContentBooks.Location = new System.Drawing.Point(228, 0);
            this.pnl_ContentBooks.Name = "pnl_ContentBooks";
            this.pnl_ContentBooks.Size = new System.Drawing.Size(785, 461);
            this.pnl_ContentBooks.TabIndex = 1;
            // 
            // BooksLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 461);
            this.Controls.Add(this.pnl_ContentBooks);
            this.Controls.Add(this.pnl_sideNavigationBarBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksLayoutForm";
            this.Text = "BooksLayoutForm";
            this.Load += new System.EventHandler(this.BooksLayoutForm_Load);
            this.pnl_sideNavigationBarBooks.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sideNavigationBarBooks;
        private System.Windows.Forms.Button btn_AddBooks;
        private System.Windows.Forms.Button btn_BrowseBooks;
        private System.Windows.Forms.Panel pnl_ContentBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}