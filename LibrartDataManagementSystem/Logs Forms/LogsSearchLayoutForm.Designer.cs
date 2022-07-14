
namespace LibrartDataManagementSystem
{
    partial class LogsSearchLayoutForm
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
            this.btn_Filter_LogsViews = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Logs_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Log_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Log_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBookAdd = new System.Windows.Forms.CheckBox();
            this.checkBookUpdate = new System.Windows.Forms.CheckBox();
            this.checkBookDelete = new System.Windows.Forms.CheckBox();
            this.checkBorrow = new System.Windows.Forms.CheckBox();
            this.checkMemberAdd = new System.Windows.Forms.CheckBox();
            this.checkMemberUpdate = new System.Windows.Forms.CheckBox();
            this.checkMemberDelete = new System.Windows.Forms.CheckBox();
            this.checkReturn = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearCheckBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Filter_LogsViews
            // 
            this.btn_Filter_LogsViews.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Filter_LogsViews.BackColor = System.Drawing.Color.Lime;
            this.btn_Filter_LogsViews.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filter_LogsViews.Location = new System.Drawing.Point(207, 65);
            this.btn_Filter_LogsViews.Name = "btn_Filter_LogsViews";
            this.btn_Filter_LogsViews.Size = new System.Drawing.Size(75, 23);
            this.btn_Filter_LogsViews.TabIndex = 11;
            this.btn_Filter_LogsViews.Text = "Filter";
            this.btn_Filter_LogsViews.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Logs_Description,
            this.Column_Log_Type,
            this.Column_Log_Date});
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 320);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column_Logs_Description
            // 
            this.Column_Logs_Description.HeaderText = "Logs Description";
            this.Column_Logs_Description.Name = "Column_Logs_Description";
            this.Column_Logs_Description.ReadOnly = true;
            // 
            // Column_Log_Type
            // 
            this.Column_Log_Type.FillWeight = 50F;
            this.Column_Log_Type.HeaderText = "Log Type";
            this.Column_Log_Type.Name = "Column_Log_Type";
            this.Column_Log_Type.ReadOnly = true;
            // 
            // Column_Log_Date
            // 
            this.Column_Log_Date.FillWeight = 50F;
            this.Column_Log_Date.HeaderText = "Date";
            this.Column_Log_Date.Name = "Column_Log_Date";
            this.Column_Log_Date.ReadOnly = true;
            // 
            // checkBookAdd
            // 
            this.checkBookAdd.AutoSize = true;
            this.checkBookAdd.Location = new System.Drawing.Point(6, 19);
            this.checkBookAdd.Name = "checkBookAdd";
            this.checkBookAdd.Size = new System.Drawing.Size(73, 17);
            this.checkBookAdd.TabIndex = 13;
            this.checkBookAdd.Text = "Book Add";
            this.checkBookAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBookAdd.UseVisualStyleBackColor = true;
            // 
            // checkBookUpdate
            // 
            this.checkBookUpdate.AutoSize = true;
            this.checkBookUpdate.Location = new System.Drawing.Point(142, 19);
            this.checkBookUpdate.Name = "checkBookUpdate";
            this.checkBookUpdate.Size = new System.Drawing.Size(89, 17);
            this.checkBookUpdate.TabIndex = 14;
            this.checkBookUpdate.Text = "Book Update";
            this.checkBookUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBookDelete
            // 
            this.checkBookDelete.AutoSize = true;
            this.checkBookDelete.Location = new System.Drawing.Point(281, 19);
            this.checkBookDelete.Name = "checkBookDelete";
            this.checkBookDelete.Size = new System.Drawing.Size(85, 17);
            this.checkBookDelete.TabIndex = 15;
            this.checkBookDelete.Text = "Book Delete";
            this.checkBookDelete.UseVisualStyleBackColor = true;
            // 
            // checkBorrow
            // 
            this.checkBorrow.AutoSize = true;
            this.checkBorrow.Location = new System.Drawing.Point(418, 19);
            this.checkBorrow.Name = "checkBorrow";
            this.checkBorrow.Size = new System.Drawing.Size(59, 17);
            this.checkBorrow.TabIndex = 16;
            this.checkBorrow.Text = "Borrow";
            this.checkBorrow.UseVisualStyleBackColor = true;
            // 
            // checkMemberAdd
            // 
            this.checkMemberAdd.AutoSize = true;
            this.checkMemberAdd.Location = new System.Drawing.Point(6, 42);
            this.checkMemberAdd.Name = "checkMemberAdd";
            this.checkMemberAdd.Size = new System.Drawing.Size(86, 17);
            this.checkMemberAdd.TabIndex = 17;
            this.checkMemberAdd.Text = "Member Add";
            this.checkMemberAdd.UseVisualStyleBackColor = true;
            // 
            // checkMemberUpdate
            // 
            this.checkMemberUpdate.AutoSize = true;
            this.checkMemberUpdate.Location = new System.Drawing.Point(142, 42);
            this.checkMemberUpdate.Name = "checkMemberUpdate";
            this.checkMemberUpdate.Size = new System.Drawing.Size(102, 17);
            this.checkMemberUpdate.TabIndex = 18;
            this.checkMemberUpdate.Text = "Member Update";
            this.checkMemberUpdate.UseVisualStyleBackColor = true;
            // 
            // checkMemberDelete
            // 
            this.checkMemberDelete.AutoSize = true;
            this.checkMemberDelete.Location = new System.Drawing.Point(281, 42);
            this.checkMemberDelete.Name = "checkMemberDelete";
            this.checkMemberDelete.Size = new System.Drawing.Size(98, 17);
            this.checkMemberDelete.TabIndex = 19;
            this.checkMemberDelete.Text = "Member Delete";
            this.checkMemberDelete.UseVisualStyleBackColor = true;
            // 
            // checkReturn
            // 
            this.checkReturn.AutoSize = true;
            this.checkReturn.Location = new System.Drawing.Point(418, 42);
            this.checkReturn.Name = "checkReturn";
            this.checkReturn.Size = new System.Drawing.Size(58, 17);
            this.checkReturn.TabIndex = 20;
            this.checkReturn.Text = "Return";
            this.checkReturn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.buttonClearCheckBox);
            this.groupBox1.Controls.Add(this.checkBookAdd);
            this.groupBox1.Controls.Add(this.checkReturn);
            this.groupBox1.Controls.Add(this.btn_Filter_LogsViews);
            this.groupBox1.Controls.Add(this.checkMemberDelete);
            this.groupBox1.Controls.Add(this.checkBookUpdate);
            this.groupBox1.Controls.Add(this.checkMemberUpdate);
            this.groupBox1.Controls.Add(this.checkBookDelete);
            this.groupBox1.Controls.Add(this.checkMemberAdd);
            this.groupBox1.Controls.Add(this.checkBorrow);
            this.groupBox1.Location = new System.Drawing.Point(169, 12);
            this.groupBox1.MinimumSize = new System.Drawing.Size(482, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Type";
            // 
            // buttonClearCheckBox
            // 
            this.buttonClearCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearCheckBox.BackColor = System.Drawing.Color.Red;
            this.buttonClearCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearCheckBox.Location = new System.Drawing.Point(389, 65);
            this.buttonClearCheckBox.Name = "buttonClearCheckBox";
            this.buttonClearCheckBox.Size = new System.Drawing.Size(87, 23);
            this.buttonClearCheckBox.TabIndex = 21;
            this.buttonClearCheckBox.Text = "Clear Selection";
            this.buttonClearCheckBox.UseVisualStyleBackColor = false;
            // 
            // LogsSearchLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogsSearchLayoutForm";
            this.Text = "LogsSearchLayoutForm";
            this.Load += new System.EventHandler(this.LogsSearchLayoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Filter_LogsViews;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Logs_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Log_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Log_Date;
        private System.Windows.Forms.CheckBox checkBookAdd;
        private System.Windows.Forms.CheckBox checkBookUpdate;
        private System.Windows.Forms.CheckBox checkBookDelete;
        private System.Windows.Forms.CheckBox checkBorrow;
        private System.Windows.Forms.CheckBox checkMemberAdd;
        private System.Windows.Forms.CheckBox checkMemberUpdate;
        private System.Windows.Forms.CheckBox checkMemberDelete;
        private System.Windows.Forms.CheckBox checkReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClearCheckBox;
    }
}