
namespace LibrartDataManagementSystem
{
    partial class MemberSearchLayoutForm
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
            this.btn_DeleteMemberSearch = new System.Windows.Forms.Button();
            this.btn_EditMemberSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGrdVw_MemberSearch = new System.Windows.Forms.DataGridView();
            this.Column_Borrower_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Conatact_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Type_Valid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Member_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combBx_Borrower_First_Name_MemberSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combBx_Borrower_Last_Name_MemberSearch = new System.Windows.Forms.ComboBox();
            this.txtBx_MemberSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_MemberSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteMemberSearch
            // 
            this.btn_DeleteMemberSearch.Location = new System.Drawing.Point(370, 308);
            this.btn_DeleteMemberSearch.Name = "btn_DeleteMemberSearch";
            this.btn_DeleteMemberSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteMemberSearch.TabIndex = 5;
            this.btn_DeleteMemberSearch.Text = "Delete";
            this.btn_DeleteMemberSearch.UseVisualStyleBackColor = true;
            // 
            // btn_EditMemberSearch
            // 
            this.btn_EditMemberSearch.Location = new System.Drawing.Point(260, 308);
            this.btn_EditMemberSearch.Name = "btn_EditMemberSearch";
            this.btn_EditMemberSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_EditMemberSearch.TabIndex = 4;
            this.btn_EditMemberSearch.Text = "Edit";
            this.btn_EditMemberSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtGrdVw_MemberSearch);
            this.panel1.Controls.Add(this.btn_DeleteMemberSearch);
            this.panel1.Controls.Add(this.btn_EditMemberSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 378);
            this.panel1.TabIndex = 14;
            // 
            // dtGrdVw_MemberSearch
            // 
            this.dtGrdVw_MemberSearch.AllowUserToAddRows = false;
            this.dtGrdVw_MemberSearch.AllowUserToDeleteRows = false;
            this.dtGrdVw_MemberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdVw_MemberSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_MemberSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Borrower_ID,
            this.Column_Borrower_Last_Name,
            this.Column_Borrower_First_Name,
            this.Column_Borrower_Name,
            this.Column_Borrower_Address,
            this.Column_Borrower_Conatact_Number,
            this.Column_Borrower_Age,
            this.Column_Borrower_Type_Valid_ID});
            this.dtGrdVw_MemberSearch.Location = new System.Drawing.Point(31, 30);
            this.dtGrdVw_MemberSearch.Name = "dtGrdVw_MemberSearch";
            this.dtGrdVw_MemberSearch.ReadOnly = true;
            this.dtGrdVw_MemberSearch.Size = new System.Drawing.Size(843, 235);
            this.dtGrdVw_MemberSearch.TabIndex = 6;
            this.dtGrdVw_MemberSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVw_MemberSearch_CellContentClick);
            // 
            // Column_Borrower_ID
            // 
            this.Column_Borrower_ID.HeaderText = "Member ID";
            this.Column_Borrower_ID.Name = "Column_Borrower_ID";
            this.Column_Borrower_ID.ReadOnly = true;
            // 
            // Column_Borrower_Last_Name
            // 
            this.Column_Borrower_Last_Name.HeaderText = "Last Name";
            this.Column_Borrower_Last_Name.Name = "Column_Borrower_Last_Name";
            this.Column_Borrower_Last_Name.ReadOnly = true;
            // 
            // Column_Borrower_First_Name
            // 
            this.Column_Borrower_First_Name.HeaderText = "First Name";
            this.Column_Borrower_First_Name.Name = "Column_Borrower_First_Name";
            this.Column_Borrower_First_Name.ReadOnly = true;
            // 
            // Column_Borrower_Name
            // 
            this.Column_Borrower_Name.HeaderText = "Name";
            this.Column_Borrower_Name.Name = "Column_Borrower_Name";
            this.Column_Borrower_Name.ReadOnly = true;
            // 
            // Column_Borrower_Address
            // 
            this.Column_Borrower_Address.HeaderText = "Address";
            this.Column_Borrower_Address.Name = "Column_Borrower_Address";
            this.Column_Borrower_Address.ReadOnly = true;
            // 
            // Column_Borrower_Conatact_Number
            // 
            this.Column_Borrower_Conatact_Number.HeaderText = "Contact Number";
            this.Column_Borrower_Conatact_Number.Name = "Column_Borrower_Conatact_Number";
            this.Column_Borrower_Conatact_Number.ReadOnly = true;
            // 
            // Column_Borrower_Age
            // 
            this.Column_Borrower_Age.HeaderText = "Age";
            this.Column_Borrower_Age.Name = "Column_Borrower_Age";
            this.Column_Borrower_Age.ReadOnly = true;
            // 
            // Column_Borrower_Type_Valid_ID
            // 
            this.Column_Borrower_Type_Valid_ID.HeaderText = "Type Of Valid ID";
            this.Column_Borrower_Type_Valid_ID.Name = "Column_Borrower_Type_Valid_ID";
            this.Column_Borrower_Type_Valid_ID.ReadOnly = true;
            // 
            // btn_Member_Search
            // 
            this.btn_Member_Search.Location = new System.Drawing.Point(503, 27);
            this.btn_Member_Search.Name = "btn_Member_Search";
            this.btn_Member_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Member_Search.TabIndex = 31;
            this.btn_Member_Search.Text = "Search";
            this.btn_Member_Search.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "First Name";
            // 
            // combBx_Borrower_First_Name_MemberSearch
            // 
            this.combBx_Borrower_First_Name_MemberSearch.FormattingEnabled = true;
            this.combBx_Borrower_First_Name_MemberSearch.Location = new System.Drawing.Point(268, 74);
            this.combBx_Borrower_First_Name_MemberSearch.Name = "combBx_Borrower_First_Name_MemberSearch";
            this.combBx_Borrower_First_Name_MemberSearch.Size = new System.Drawing.Size(121, 21);
            this.combBx_Borrower_First_Name_MemberSearch.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search Member ID";
            // 
            // combBx_Borrower_Last_Name_MemberSearch
            // 
            this.combBx_Borrower_Last_Name_MemberSearch.FormattingEnabled = true;
            this.combBx_Borrower_Last_Name_MemberSearch.Location = new System.Drawing.Point(130, 74);
            this.combBx_Borrower_Last_Name_MemberSearch.Name = "combBx_Borrower_Last_Name_MemberSearch";
            this.combBx_Borrower_Last_Name_MemberSearch.Size = new System.Drawing.Size(121, 21);
            this.combBx_Borrower_Last_Name_MemberSearch.TabIndex = 24;
            // 
            // txtBx_MemberSearch
            // 
            this.txtBx_MemberSearch.Location = new System.Drawing.Point(237, 30);
            this.txtBx_MemberSearch.Name = "txtBx_MemberSearch";
            this.txtBx_MemberSearch.Size = new System.Drawing.Size(260, 20);
            this.txtBx_MemberSearch.TabIndex = 23;
            // 
            // MemberSearchLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBx_MemberSearch);
            this.Controls.Add(this.btn_Member_Search);
            this.Controls.Add(this.combBx_Borrower_Last_Name_MemberSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combBx_Borrower_First_Name_MemberSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberSearchLayoutForm";
            this.Text = "MemberSearchLayoutForm";
            this.Load += new System.EventHandler(this.MemberSearchLayoutForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_MemberSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_DeleteMemberSearch;
        private System.Windows.Forms.Button btn_EditMemberSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Member_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combBx_Borrower_First_Name_MemberSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combBx_Borrower_Last_Name_MemberSearch;
        private System.Windows.Forms.TextBox txtBx_MemberSearch;
        private System.Windows.Forms.DataGridView dtGrdVw_MemberSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Conatact_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Type_Valid_ID;
    }
}