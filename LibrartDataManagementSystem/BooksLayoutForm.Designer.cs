
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
            this.btn_AddBooks = new System.Windows.Forms.Button();
            this.btn_BrowseBooks = new System.Windows.Forms.Button();
            this.pnl_ContentBooks = new System.Windows.Forms.Panel();
            this.pnl_sideNavigationBarBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sideNavigationBarBooks
            // 
            this.pnl_sideNavigationBarBooks.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_sideNavigationBarBooks.Controls.Add(this.btn_AddBooks);
            this.pnl_sideNavigationBarBooks.Controls.Add(this.btn_BrowseBooks);
            this.pnl_sideNavigationBarBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sideNavigationBarBooks.Location = new System.Drawing.Point(0, 0);
            this.pnl_sideNavigationBarBooks.Name = "pnl_sideNavigationBarBooks";
            this.pnl_sideNavigationBarBooks.Size = new System.Drawing.Size(200, 450);
            this.pnl_sideNavigationBarBooks.TabIndex = 0;
            // 
            // btn_AddBooks
            // 
            this.btn_AddBooks.Location = new System.Drawing.Point(41, 116);
            this.btn_AddBooks.Name = "btn_AddBooks";
            this.btn_AddBooks.Size = new System.Drawing.Size(112, 23);
            this.btn_AddBooks.TabIndex = 1;
            this.btn_AddBooks.Text = "Add Books";
            this.btn_AddBooks.UseVisualStyleBackColor = true;
            this.btn_AddBooks.Click += new System.EventHandler(this.btn_AddBooks_Click);
            // 
            // btn_BrowseBooks
            // 
            this.btn_BrowseBooks.Location = new System.Drawing.Point(41, 71);
            this.btn_BrowseBooks.Name = "btn_BrowseBooks";
            this.btn_BrowseBooks.Size = new System.Drawing.Size(112, 23);
            this.btn_BrowseBooks.TabIndex = 0;
            this.btn_BrowseBooks.Text = "Browse Books";
            this.btn_BrowseBooks.UseVisualStyleBackColor = true;
            this.btn_BrowseBooks.Click += new System.EventHandler(this.btn_BrowseBooks_Click);
            // 
            // pnl_ContentBooks
            // 
            this.pnl_ContentBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContentBooks.Location = new System.Drawing.Point(200, 0);
            this.pnl_ContentBooks.Name = "pnl_ContentBooks";
            this.pnl_ContentBooks.Size = new System.Drawing.Size(600, 450);
            this.pnl_ContentBooks.TabIndex = 1;
            // 
            // BooksLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_ContentBooks);
            this.Controls.Add(this.pnl_sideNavigationBarBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksLayoutForm";
            this.Text = "BooksLayoutForm";
            this.pnl_sideNavigationBarBooks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sideNavigationBarBooks;
        private System.Windows.Forms.Button btn_AddBooks;
        private System.Windows.Forms.Button btn_BrowseBooks;
        private System.Windows.Forms.Panel pnl_ContentBooks;
    }
}