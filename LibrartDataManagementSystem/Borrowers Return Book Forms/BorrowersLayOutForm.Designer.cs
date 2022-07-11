
namespace LibrartDataManagementSystem
{
    partial class BorrowersLayOutForm
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
            this.pnl_sideNavigationBarBorrowers = new System.Windows.Forms.Panel();
            this.btn_SearchBorrowers = new System.Windows.Forms.Button();
            this.pnl_ContentBorrowers = new System.Windows.Forms.Panel();
            this.pnl_sideNavigationBarBorrowers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sideNavigationBarBorrowers
            // 
            this.pnl_sideNavigationBarBorrowers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_sideNavigationBarBorrowers.Controls.Add(this.btn_SearchBorrowers);
            this.pnl_sideNavigationBarBorrowers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sideNavigationBarBorrowers.Location = new System.Drawing.Point(0, 0);
            this.pnl_sideNavigationBarBorrowers.Name = "pnl_sideNavigationBarBorrowers";
            this.pnl_sideNavigationBarBorrowers.Size = new System.Drawing.Size(200, 450);
            this.pnl_sideNavigationBarBorrowers.TabIndex = 0;
            // 
            // btn_SearchBorrowers
            // 
            this.btn_SearchBorrowers.Location = new System.Drawing.Point(79, 105);
            this.btn_SearchBorrowers.Name = "btn_SearchBorrowers";
            this.btn_SearchBorrowers.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchBorrowers.TabIndex = 0;
            this.btn_SearchBorrowers.Text = "Search";
            this.btn_SearchBorrowers.UseVisualStyleBackColor = true;
            this.btn_SearchBorrowers.Click += new System.EventHandler(this.btn_SearchBorrowers_Click);
            // 
            // pnl_ContentBorrowers
            // 
            this.pnl_ContentBorrowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContentBorrowers.Location = new System.Drawing.Point(200, 0);
            this.pnl_ContentBorrowers.Name = "pnl_ContentBorrowers";
            this.pnl_ContentBorrowers.Size = new System.Drawing.Size(600, 450);
            this.pnl_ContentBorrowers.TabIndex = 1;
            // 
            // BorrowersLayOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_ContentBorrowers);
            this.Controls.Add(this.pnl_sideNavigationBarBorrowers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowersLayOutForm";
            this.Text = "BorrowersLayOutForm";
            this.Load += new System.EventHandler(this.BorrowersLayOutForm_Load);
            this.pnl_sideNavigationBarBorrowers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sideNavigationBarBorrowers;
        private System.Windows.Forms.Panel pnl_ContentBorrowers;
        private System.Windows.Forms.Button btn_SearchBorrowers;
    }
}