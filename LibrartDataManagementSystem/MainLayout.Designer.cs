
namespace LibrartDataManagementSystem
{
    partial class MainLayout
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
            this.pnl_Navigation = new System.Windows.Forms.Panel();
            this.btn_Members = new System.Windows.Forms.Button();
            this.btn_Logs = new System.Windows.Forms.Button();
            this.btn_Borrowers = new System.Windows.Forms.Button();
            this.btn_Books = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_BorrowTransation = new System.Windows.Forms.Button();
            this.pnl_Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Navigation
            // 
            this.pnl_Navigation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Navigation.Controls.Add(this.btn_BorrowTransation);
            this.pnl_Navigation.Controls.Add(this.btn_Members);
            this.pnl_Navigation.Controls.Add(this.btn_Logs);
            this.pnl_Navigation.Controls.Add(this.btn_Borrowers);
            this.pnl_Navigation.Controls.Add(this.btn_Books);
            this.pnl_Navigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Navigation.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigation.Name = "pnl_Navigation";
            this.pnl_Navigation.Size = new System.Drawing.Size(1378, 100);
            this.pnl_Navigation.TabIndex = 0;
            // 
            // btn_Members
            // 
            this.btn_Members.Location = new System.Drawing.Point(87, 33);
            this.btn_Members.Name = "btn_Members";
            this.btn_Members.Size = new System.Drawing.Size(75, 23);
            this.btn_Members.TabIndex = 3;
            this.btn_Members.Text = "Members";
            this.btn_Members.UseVisualStyleBackColor = true;
            this.btn_Members.Click += new System.EventHandler(this.btn_Members_Click);
            // 
            // btn_Logs
            // 
            this.btn_Logs.Location = new System.Drawing.Point(501, 33);
            this.btn_Logs.Name = "btn_Logs";
            this.btn_Logs.Size = new System.Drawing.Size(75, 23);
            this.btn_Logs.TabIndex = 2;
            this.btn_Logs.Text = "Logs";
            this.btn_Logs.UseVisualStyleBackColor = true;
            this.btn_Logs.Click += new System.EventHandler(this.btn_Logs_Click);
            // 
            // btn_Borrowers
            // 
            this.btn_Borrowers.Location = new System.Drawing.Point(397, 33);
            this.btn_Borrowers.Name = "btn_Borrowers";
            this.btn_Borrowers.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrowers.TabIndex = 1;
            this.btn_Borrowers.Text = "Borrowers";
            this.btn_Borrowers.UseVisualStyleBackColor = true;
            this.btn_Borrowers.Click += new System.EventHandler(this.btn_Borrowers_Click);
            // 
            // btn_Books
            // 
            this.btn_Books.Location = new System.Drawing.Point(180, 33);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Size = new System.Drawing.Size(75, 23);
            this.btn_Books.TabIndex = 0;
            this.btn_Books.Text = "Books";
            this.btn_Books.UseVisualStyleBackColor = true;
            this.btn_Books.Click += new System.EventHandler(this.btn_Books_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 100);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1378, 632);
            this.pnl_Main.TabIndex = 1;
            this.pnl_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Main_Paint);
            // 
            // btn_BorrowTransation
            // 
            this.btn_BorrowTransation.Location = new System.Drawing.Point(272, 33);
            this.btn_BorrowTransation.Name = "btn_BorrowTransation";
            this.btn_BorrowTransation.Size = new System.Drawing.Size(119, 23);
            this.btn_BorrowTransation.TabIndex = 4;
            this.btn_BorrowTransation.Text = "Borrow Transation";
            this.btn_BorrowTransation.UseVisualStyleBackColor = true;
            this.btn_BorrowTransation.Click += new System.EventHandler(this.btn_BorrowTransation_Click);
            // 
            // MainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 732);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Navigation);
            this.Name = "MainLayout";
            this.Text = "MainLayout";
            this.Load += new System.EventHandler(this.MainLayout_Load);
            this.pnl_Navigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation;
        private System.Windows.Forms.Button btn_Logs;
        private System.Windows.Forms.Button btn_Borrowers;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button btn_Members;
        private System.Windows.Forms.Button btn_BorrowTransation;
    }
}