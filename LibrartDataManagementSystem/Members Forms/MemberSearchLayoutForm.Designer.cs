
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
            this.btn_Member_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combBx_Borrower_Last_Name_MemberSearch = new System.Windows.Forms.ComboBox();
            this.txtBx_MemberSearch = new System.Windows.Forms.TextBox();
            this.combBx_Borrower_Gender_MemberSearch = new System.Windows.Forms.ComboBox();
            this.combBx_Borrower_BirthDate_MemberSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.dtGrdVw_MemberSearch = new System.Windows.Forms.DataGridView();
            this.Column_Borrower_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Middle_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Conatact_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Type_Valid_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_MemberSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteMemberSearch
            // 
            this.btn_DeleteMemberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteMemberSearch.Location = new System.Drawing.Point(476, 483);
            this.btn_DeleteMemberSearch.Name = "btn_DeleteMemberSearch";
            this.btn_DeleteMemberSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteMemberSearch.TabIndex = 5;
            this.btn_DeleteMemberSearch.Text = "Delete";
            this.btn_DeleteMemberSearch.UseVisualStyleBackColor = true;
            this.btn_DeleteMemberSearch.Click += new System.EventHandler(this.btn_DeleteMemberSearch_Click);
            // 
            // btn_EditMemberSearch
            // 
            this.btn_EditMemberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditMemberSearch.Location = new System.Drawing.Point(315, 483);
            this.btn_EditMemberSearch.Name = "btn_EditMemberSearch";
            this.btn_EditMemberSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_EditMemberSearch.TabIndex = 4;
            this.btn_EditMemberSearch.Text = "Edit";
            this.btn_EditMemberSearch.UseVisualStyleBackColor = true;
            this.btn_EditMemberSearch.Click += new System.EventHandler(this.btn_EditMemberSearch_Click);
            // 
            // btn_Member_Search
            // 
            this.btn_Member_Search.Location = new System.Drawing.Point(572, 14);
            this.btn_Member_Search.Name = "btn_Member_Search";
            this.btn_Member_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Member_Search.TabIndex = 31;
            this.btn_Member_Search.Text = "Search";
            this.btn_Member_Search.UseVisualStyleBackColor = true;
            this.btn_Member_Search.Click += new System.EventHandler(this.btn_Member_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search Member";
            // 
            // combBx_Borrower_Last_Name_MemberSearch
            // 
            this.combBx_Borrower_Last_Name_MemberSearch.FormattingEnabled = true;
            this.combBx_Borrower_Last_Name_MemberSearch.Location = new System.Drawing.Point(302, 61);
            this.combBx_Borrower_Last_Name_MemberSearch.Name = "combBx_Borrower_Last_Name_MemberSearch";
            this.combBx_Borrower_Last_Name_MemberSearch.Size = new System.Drawing.Size(119, 21);
            this.combBx_Borrower_Last_Name_MemberSearch.TabIndex = 24;
            this.combBx_Borrower_Last_Name_MemberSearch.SelectedIndexChanged += new System.EventHandler(this.combBx_Borrower_Last_Name_MemberSearch_SelectedIndexChanged);
            // 
            // txtBx_MemberSearch
            // 
            this.txtBx_MemberSearch.Location = new System.Drawing.Point(306, 17);
            this.txtBx_MemberSearch.Name = "txtBx_MemberSearch";
            this.txtBx_MemberSearch.Size = new System.Drawing.Size(260, 20);
            this.txtBx_MemberSearch.TabIndex = 23;
            // 
            // combBx_Borrower_Gender_MemberSearch
            // 
            this.combBx_Borrower_Gender_MemberSearch.FormattingEnabled = true;
            this.combBx_Borrower_Gender_MemberSearch.Location = new System.Drawing.Point(429, 61);
            this.combBx_Borrower_Gender_MemberSearch.Name = "combBx_Borrower_Gender_MemberSearch";
            this.combBx_Borrower_Gender_MemberSearch.Size = new System.Drawing.Size(66, 21);
            this.combBx_Borrower_Gender_MemberSearch.TabIndex = 32;
            this.combBx_Borrower_Gender_MemberSearch.SelectedIndexChanged += new System.EventHandler(this.combBx_Borrower_Last_Name_MemberSearch_SelectedIndexChanged);
            // 
            // combBx_Borrower_BirthDate_MemberSearch
            // 
            this.combBx_Borrower_BirthDate_MemberSearch.FormattingEnabled = true;
            this.combBx_Borrower_BirthDate_MemberSearch.Location = new System.Drawing.Point(503, 61);
            this.combBx_Borrower_BirthDate_MemberSearch.Name = "combBx_Borrower_BirthDate_MemberSearch";
            this.combBx_Borrower_BirthDate_MemberSearch.Size = new System.Drawing.Size(119, 21);
            this.combBx_Borrower_BirthDate_MemberSearch.TabIndex = 33;
            this.combBx_Borrower_BirthDate_MemberSearch.SelectedIndexChanged += new System.EventHandler(this.combBx_Borrower_Last_Name_MemberSearch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Bithdate";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 20);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 36;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // grpMembers
            // 
            this.grpMembers.Controls.Add(this.dtGrdVw_MemberSearch);
            this.grpMembers.Location = new System.Drawing.Point(12, 100);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(903, 255);
            this.grpMembers.TabIndex = 37;
            this.grpMembers.TabStop = false;
            this.grpMembers.Text = "Members List";
            // 
            // dtGrdVw_MemberSearch
            // 
            this.dtGrdVw_MemberSearch.AllowUserToAddRows = false;
            this.dtGrdVw_MemberSearch.AllowUserToDeleteRows = false;
            this.dtGrdVw_MemberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdVw_MemberSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVw_MemberSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_MemberSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Borrower_ID,
            this.Column_Borrower_First_Name,
            this.Column_Borrower_Middle_Name,
            this.Column_Borrower_Last_Name,
            this.Column_Borrower_Gender,
            this.Column_Borrower_Address,
            this.Column_Borrower_Conatact_Number,
            this.Column_Borrower_BirthDate,
            this.Column_Borrower_Type_Valid_ID});
            this.dtGrdVw_MemberSearch.Location = new System.Drawing.Point(18, 28);
            this.dtGrdVw_MemberSearch.Name = "dtGrdVw_MemberSearch";
            this.dtGrdVw_MemberSearch.ReadOnly = true;
            this.dtGrdVw_MemberSearch.Size = new System.Drawing.Size(866, 200);
            this.dtGrdVw_MemberSearch.TabIndex = 7;
            this.dtGrdVw_MemberSearch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVw_MemberSearch_CellContentDoubleClick);
            // 
            // Column_Borrower_ID
            // 
            this.Column_Borrower_ID.HeaderText = "Borrower ID";
            this.Column_Borrower_ID.Name = "Column_Borrower_ID";
            this.Column_Borrower_ID.ReadOnly = true;
            // 
            // Column_Borrower_First_Name
            // 
            this.Column_Borrower_First_Name.HeaderText = "First Name";
            this.Column_Borrower_First_Name.Name = "Column_Borrower_First_Name";
            this.Column_Borrower_First_Name.ReadOnly = true;
            // 
            // Column_Borrower_Middle_Name
            // 
            this.Column_Borrower_Middle_Name.HeaderText = "Middle Name";
            this.Column_Borrower_Middle_Name.Name = "Column_Borrower_Middle_Name";
            this.Column_Borrower_Middle_Name.ReadOnly = true;
            // 
            // Column_Borrower_Last_Name
            // 
            this.Column_Borrower_Last_Name.HeaderText = "Last Name";
            this.Column_Borrower_Last_Name.Name = "Column_Borrower_Last_Name";
            this.Column_Borrower_Last_Name.ReadOnly = true;
            // 
            // Column_Borrower_Gender
            // 
            this.Column_Borrower_Gender.HeaderText = "Gender";
            this.Column_Borrower_Gender.Name = "Column_Borrower_Gender";
            this.Column_Borrower_Gender.ReadOnly = true;
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
            // Column_Borrower_BirthDate
            // 
            this.Column_Borrower_BirthDate.HeaderText = "Birthdate";
            this.Column_Borrower_BirthDate.Name = "Column_Borrower_BirthDate";
            this.Column_Borrower_BirthDate.ReadOnly = true;
            // 
            // Column_Borrower_Type_Valid_ID
            // 
            this.Column_Borrower_Type_Valid_ID.HeaderText = "Type Of Valid ID";
            this.Column_Borrower_Type_Valid_ID.Name = "Column_Borrower_Type_Valid_ID";
            this.Column_Borrower_Type_Valid_ID.ReadOnly = true;
            // 
            // MemberSearchLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(927, 534);
            this.Controls.Add(this.grpMembers);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combBx_Borrower_BirthDate_MemberSearch);
            this.Controls.Add(this.combBx_Borrower_Gender_MemberSearch);
            this.Controls.Add(this.btn_DeleteMemberSearch);
            this.Controls.Add(this.btn_EditMemberSearch);
            this.Controls.Add(this.txtBx_MemberSearch);
            this.Controls.Add(this.btn_Member_Search);
            this.Controls.Add(this.combBx_Borrower_Last_Name_MemberSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberSearchLayoutForm";
            this.Text = "MemberSearchLayoutForm";
            this.Load += new System.EventHandler(this.MemberSearchLayoutForm_Load);
            this.grpMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_MemberSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_DeleteMemberSearch;
        private System.Windows.Forms.Button btn_EditMemberSearch;
        private System.Windows.Forms.Button btn_Member_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combBx_Borrower_Last_Name_MemberSearch;
        private System.Windows.Forms.TextBox txtBx_MemberSearch;
        private System.Windows.Forms.ComboBox combBx_Borrower_Gender_MemberSearch;
        private System.Windows.Forms.ComboBox combBx_Borrower_BirthDate_MemberSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.DataGridView dtGrdVw_MemberSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Middle_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Conatact_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Type_Valid_ID;
    }
}