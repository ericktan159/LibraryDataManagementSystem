
namespace LibrartDataManagementSystem
{
    partial class LogsLayoutForm
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
            this.pnl_sideNavigationBarLogs = new System.Windows.Forms.Panel();
            this.btn_ViewLogs = new System.Windows.Forms.Button();
            this.pnl_ContentLogs = new System.Windows.Forms.Panel();
            this.pnl_sideNavigationBarLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sideNavigationBarLogs
            // 
            this.pnl_sideNavigationBarLogs.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_sideNavigationBarLogs.Controls.Add(this.btn_ViewLogs);
            this.pnl_sideNavigationBarLogs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sideNavigationBarLogs.Location = new System.Drawing.Point(0, 0);
            this.pnl_sideNavigationBarLogs.Name = "pnl_sideNavigationBarLogs";
            this.pnl_sideNavigationBarLogs.Size = new System.Drawing.Size(200, 450);
            this.pnl_sideNavigationBarLogs.TabIndex = 0;
            // 
            // btn_ViewLogs
            // 
            this.btn_ViewLogs.Location = new System.Drawing.Point(61, 91);
            this.btn_ViewLogs.Name = "btn_ViewLogs";
            this.btn_ViewLogs.Size = new System.Drawing.Size(75, 23);
            this.btn_ViewLogs.TabIndex = 0;
            this.btn_ViewLogs.Text = "View";
            this.btn_ViewLogs.UseVisualStyleBackColor = true;
            this.btn_ViewLogs.Click += new System.EventHandler(this.btn_ViewLogs_Click);
            // 
            // pnl_ContentLogs
            // 
            this.pnl_ContentLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ContentLogs.Location = new System.Drawing.Point(200, 0);
            this.pnl_ContentLogs.Name = "pnl_ContentLogs";
            this.pnl_ContentLogs.Size = new System.Drawing.Size(600, 450);
            this.pnl_ContentLogs.TabIndex = 1;
            // 
            // LogsLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_ContentLogs);
            this.Controls.Add(this.pnl_sideNavigationBarLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogsLayoutForm";
            this.Text = "LogsLayoutForm";
            this.Load += new System.EventHandler(this.LogsLayoutForm_Load);
            this.pnl_sideNavigationBarLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sideNavigationBarLogs;
        private System.Windows.Forms.Panel pnl_ContentLogs;
        private System.Windows.Forms.Button btn_ViewLogs;
    }
}