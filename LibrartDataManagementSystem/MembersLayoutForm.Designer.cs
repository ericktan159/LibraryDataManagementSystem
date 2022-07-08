
namespace LibrartDataManagementSystem
{
    partial class MembersLayoutForm
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
            this.pnl_ContentMembers = new System.Windows.Forms.Panel();
            this.pnl_sideNavigationBarMembers = new System.Windows.Forms.Panel();
            this.btn_AddMembers = new System.Windows.Forms.Button();
            this.btn_BrowseMembers = new System.Windows.Forms.Button();
            this.pnl_sideNavigationBarMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ContentMembers
            // 
            this.pnl_ContentMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContentMembers.Location = new System.Drawing.Point(200, 0);
            this.pnl_ContentMembers.Name = "pnl_ContentMembers";
            this.pnl_ContentMembers.Size = new System.Drawing.Size(600, 450);
            this.pnl_ContentMembers.TabIndex = 3;
            // 
            // pnl_sideNavigationBarMembers
            // 
            this.pnl_sideNavigationBarMembers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_sideNavigationBarMembers.Controls.Add(this.btn_AddMembers);
            this.pnl_sideNavigationBarMembers.Controls.Add(this.btn_BrowseMembers);
            this.pnl_sideNavigationBarMembers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sideNavigationBarMembers.Location = new System.Drawing.Point(0, 0);
            this.pnl_sideNavigationBarMembers.Name = "pnl_sideNavigationBarMembers";
            this.pnl_sideNavigationBarMembers.Size = new System.Drawing.Size(200, 450);
            this.pnl_sideNavigationBarMembers.TabIndex = 2;
            // 
            // btn_AddMembers
            // 
            this.btn_AddMembers.Location = new System.Drawing.Point(22, 116);
            this.btn_AddMembers.Name = "btn_AddMembers";
            this.btn_AddMembers.Size = new System.Drawing.Size(131, 23);
            this.btn_AddMembers.TabIndex = 1;
            this.btn_AddMembers.Text = "Add Members";
            this.btn_AddMembers.UseVisualStyleBackColor = true;
            this.btn_AddMembers.Click += new System.EventHandler(this.btn_AddMembers_Click);
            // 
            // btn_BrowseMembers
            // 
            this.btn_BrowseMembers.Location = new System.Drawing.Point(32, 71);
            this.btn_BrowseMembers.Name = "btn_BrowseMembers";
            this.btn_BrowseMembers.Size = new System.Drawing.Size(121, 23);
            this.btn_BrowseMembers.TabIndex = 0;
            this.btn_BrowseMembers.Text = "Browse Members";
            this.btn_BrowseMembers.UseVisualStyleBackColor = true;
            this.btn_BrowseMembers.Click += new System.EventHandler(this.btn_BrowseMembers_Click);
            // 
            // MembersLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_ContentMembers);
            this.Controls.Add(this.pnl_sideNavigationBarMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MembersLayoutForm";
            this.Text = "MembersLayoutForm";
            this.Load += new System.EventHandler(this.MembersLayoutForm_Load);
            this.pnl_sideNavigationBarMembers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ContentMembers;
        private System.Windows.Forms.Panel pnl_sideNavigationBarMembers;
        private System.Windows.Forms.Button btn_AddMembers;
        private System.Windows.Forms.Button btn_BrowseMembers;
    }
}