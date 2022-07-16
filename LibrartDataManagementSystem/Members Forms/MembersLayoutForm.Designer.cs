
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_sideNavigationBarMembers.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnl_sideNavigationBarMembers.BackColor = System.Drawing.Color.Maroon;
            this.pnl_sideNavigationBarMembers.Controls.Add(this.panel1);
            this.pnl_sideNavigationBarMembers.Controls.Add(this.panel3);
            this.pnl_sideNavigationBarMembers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sideNavigationBarMembers.Location = new System.Drawing.Point(0, 0);
            this.pnl_sideNavigationBarMembers.Name = "pnl_sideNavigationBarMembers";
            this.pnl_sideNavigationBarMembers.Size = new System.Drawing.Size(200, 450);
            this.pnl_sideNavigationBarMembers.TabIndex = 2;
            // 
            // btn_AddMembers
            // 
            this.btn_AddMembers.Location = new System.Drawing.Point(9, 3);
            this.btn_AddMembers.Name = "btn_AddMembers";
            this.btn_AddMembers.Size = new System.Drawing.Size(129, 34);
            this.btn_AddMembers.TabIndex = 1;
            this.btn_AddMembers.Text = "Add Members";
            this.btn_AddMembers.UseVisualStyleBackColor = true;
            this.btn_AddMembers.Click += new System.EventHandler(this.btn_AddMembers_Click);
            // 
            // btn_BrowseMembers
            // 
            this.btn_BrowseMembers.Location = new System.Drawing.Point(9, 5);
            this.btn_BrowseMembers.Name = "btn_BrowseMembers";
            this.btn_BrowseMembers.Size = new System.Drawing.Size(129, 30);
            this.btn_BrowseMembers.TabIndex = 0;
            this.btn_BrowseMembers.Text = "Browse Members";
            this.btn_BrowseMembers.UseVisualStyleBackColor = true;
            this.btn_BrowseMembers.Click += new System.EventHandler(this.btn_BrowseMembers_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.btn_BrowseMembers);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(30, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 40);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btn_AddMembers);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(30, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 40);
            this.panel1.TabIndex = 8;
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
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ContentMembers;
        private System.Windows.Forms.Panel pnl_sideNavigationBarMembers;
        private System.Windows.Forms.Button btn_AddMembers;
        private System.Windows.Forms.Button btn_BrowseMembers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}