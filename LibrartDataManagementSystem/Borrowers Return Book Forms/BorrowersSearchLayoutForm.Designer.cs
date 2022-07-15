
namespace LibrartDataManagementSystem
{
    partial class BorrowersSearchLayoutForm
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
            this.btn_Borrower_Search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.combBx_Book_ID_BorrowerSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combBx_Borrower_First_Name_BorrowerSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combBx_Borrower_Last_Name_BorrowerSearch = new System.Windows.Forms.ComboBox();
            this.txtBx_BorrowerSearch = new System.Windows.Forms.TextBox();
            this.btn_ReturnBook_BorrowerSearch = new System.Windows.Forms.Button();
            this.dtGrdVw_BorrwerSearch = new System.Windows.Forms.DataGridView();
            this.Column_Borrowed_Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrower_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Book_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrowed_Book_Due_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrowed_Book_Due_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Borrowed_Book_Number_of_Copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.combBx_Borrowed_Book_Due_Status = new System.Windows.Forms.ComboBox();
            this.checkReturned = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_BorrwerSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Borrower_Search
            // 
            this.btn_Borrower_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Borrower_Search.BackColor = System.Drawing.Color.Aqua;
            this.btn_Borrower_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Borrower_Search.Location = new System.Drawing.Point(507, 9);
            this.btn_Borrower_Search.Name = "btn_Borrower_Search";
            this.btn_Borrower_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrower_Search.TabIndex = 19;
            this.btn_Borrower_Search.Text = "Search";
            this.btn_Borrower_Search.UseVisualStyleBackColor = false;
            this.btn_Borrower_Search.Click += new System.EventHandler(this.btn_Borrower_Search_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Book ID";
            // 
            // combBx_Book_ID_BorrowerSearch
            // 
            this.combBx_Book_ID_BorrowerSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combBx_Book_ID_BorrowerSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBx_Book_ID_BorrowerSearch.FormattingEnabled = true;
            this.combBx_Book_ID_BorrowerSearch.Items.AddRange(new object[] {
            "All"});
            this.combBx_Book_ID_BorrowerSearch.Location = new System.Drawing.Point(399, 56);
            this.combBx_Book_ID_BorrowerSearch.Name = "combBx_Book_ID_BorrowerSearch";
            this.combBx_Book_ID_BorrowerSearch.Size = new System.Drawing.Size(121, 21);
            this.combBx_Book_ID_BorrowerSearch.TabIndex = 17;
            this.combBx_Book_ID_BorrowerSearch.SelectedIndexChanged += new System.EventHandler(this.DropDownChange);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "First Name";
            // 
            // combBx_Borrower_First_Name_BorrowerSearch
            // 
            this.combBx_Borrower_First_Name_BorrowerSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combBx_Borrower_First_Name_BorrowerSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBx_Borrower_First_Name_BorrowerSearch.FormattingEnabled = true;
            this.combBx_Borrower_First_Name_BorrowerSearch.Items.AddRange(new object[] {
            "All"});
            this.combBx_Borrower_First_Name_BorrowerSearch.Location = new System.Drawing.Point(272, 56);
            this.combBx_Borrower_First_Name_BorrowerSearch.Name = "combBx_Borrower_First_Name_BorrowerSearch";
            this.combBx_Borrower_First_Name_BorrowerSearch.Size = new System.Drawing.Size(121, 21);
            this.combBx_Borrower_First_Name_BorrowerSearch.TabIndex = 15;
            this.combBx_Borrower_First_Name_BorrowerSearch.SelectedIndexChanged += new System.EventHandler(this.DropDownChange);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // combBx_Borrower_Last_Name_BorrowerSearch
            // 
            this.combBx_Borrower_Last_Name_BorrowerSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combBx_Borrower_Last_Name_BorrowerSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBx_Borrower_Last_Name_BorrowerSearch.FormattingEnabled = true;
            this.combBx_Borrower_Last_Name_BorrowerSearch.Items.AddRange(new object[] {
            "All"});
            this.combBx_Borrower_Last_Name_BorrowerSearch.Location = new System.Drawing.Point(134, 56);
            this.combBx_Borrower_Last_Name_BorrowerSearch.Name = "combBx_Borrower_Last_Name_BorrowerSearch";
            this.combBx_Borrower_Last_Name_BorrowerSearch.Size = new System.Drawing.Size(121, 21);
            this.combBx_Borrower_Last_Name_BorrowerSearch.TabIndex = 12;
            this.combBx_Borrower_Last_Name_BorrowerSearch.SelectedIndexChanged += new System.EventHandler(this.DropDownChange);
            // 
            // txtBx_BorrowerSearch
            // 
            this.txtBx_BorrowerSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBx_BorrowerSearch.Location = new System.Drawing.Point(241, 12);
            this.txtBx_BorrowerSearch.Name = "txtBx_BorrowerSearch";
            this.txtBx_BorrowerSearch.Size = new System.Drawing.Size(260, 20);
            this.txtBx_BorrowerSearch.TabIndex = 11;
            // 
            // btn_ReturnBook_BorrowerSearch
            // 
            this.btn_ReturnBook_BorrowerSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ReturnBook_BorrowerSearch.BackColor = System.Drawing.Color.Yellow;
            this.btn_ReturnBook_BorrowerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReturnBook_BorrowerSearch.Location = new System.Drawing.Point(731, 393);
            this.btn_ReturnBook_BorrowerSearch.Name = "btn_ReturnBook_BorrowerSearch";
            this.btn_ReturnBook_BorrowerSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_ReturnBook_BorrowerSearch.TabIndex = 5;
            this.btn_ReturnBook_BorrowerSearch.Text = "Return Book";
            this.btn_ReturnBook_BorrowerSearch.UseVisualStyleBackColor = false;
            // 
            // dtGrdVw_BorrwerSearch
            // 
            this.dtGrdVw_BorrwerSearch.AllowUserToAddRows = false;
            this.dtGrdVw_BorrwerSearch.AllowUserToDeleteRows = false;
            this.dtGrdVw_BorrwerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdVw_BorrwerSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVw_BorrwerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_BorrwerSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Borrowed_Book_ID,
            this.Column_Borrower_Name,
            this.Column_Book_Title,
            this.Column_Borrowed_Book_Due_Date,
            this.Column_Borrowed_Book_Due_Status,
            this.Column_Borrowed_Book_Number_of_Copies});
            this.dtGrdVw_BorrwerSearch.Location = new System.Drawing.Point(12, 86);
            this.dtGrdVw_BorrwerSearch.Name = "dtGrdVw_BorrwerSearch";
            this.dtGrdVw_BorrwerSearch.ReadOnly = true;
            this.dtGrdVw_BorrwerSearch.Size = new System.Drawing.Size(794, 301);
            this.dtGrdVw_BorrwerSearch.TabIndex = 3;
            // 
            // Column_Borrowed_Book_ID
            // 
            this.Column_Borrowed_Book_ID.HeaderText = "Transaction ID";
            this.Column_Borrowed_Book_ID.Name = "Column_Borrowed_Book_ID";
            this.Column_Borrowed_Book_ID.ReadOnly = true;
            // 
            // Column_Borrower_Name
            // 
            this.Column_Borrower_Name.HeaderText = "Name";
            this.Column_Borrower_Name.Name = "Column_Borrower_Name";
            this.Column_Borrower_Name.ReadOnly = true;
            // 
            // Column_Book_Title
            // 
            this.Column_Book_Title.HeaderText = "Book Title";
            this.Column_Book_Title.Name = "Column_Book_Title";
            this.Column_Book_Title.ReadOnly = true;
            // 
            // Column_Borrowed_Book_Due_Date
            // 
            this.Column_Borrowed_Book_Due_Date.HeaderText = "Due Date";
            this.Column_Borrowed_Book_Due_Date.Name = "Column_Borrowed_Book_Due_Date";
            this.Column_Borrowed_Book_Due_Date.ReadOnly = true;
            // 
            // Column_Borrowed_Book_Due_Status
            // 
            this.Column_Borrowed_Book_Due_Status.HeaderText = "Due Status";
            this.Column_Borrowed_Book_Due_Status.Name = "Column_Borrowed_Book_Due_Status";
            this.Column_Borrowed_Book_Due_Status.ReadOnly = true;
            // 
            // Column_Borrowed_Book_Number_of_Copies
            // 
            this.Column_Borrowed_Book_Number_of_Copies.HeaderText = "Number of Copies";
            this.Column_Borrowed_Book_Number_of_Copies.Name = "Column_Borrowed_Book_Number_of_Copies";
            this.Column_Borrowed_Book_Number_of_Copies.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Due Status";
            // 
            // combBx_Borrowed_Book_Due_Status
            // 
            this.combBx_Borrowed_Book_Due_Status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combBx_Borrowed_Book_Due_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBx_Borrowed_Book_Due_Status.FormattingEnabled = true;
            this.combBx_Borrowed_Book_Due_Status.Items.AddRange(new object[] {
            "All",
            "Not Overdue",
            "Overdue",
            "Returned"});
            this.combBx_Borrowed_Book_Due_Status.Location = new System.Drawing.Point(526, 56);
            this.combBx_Borrowed_Book_Due_Status.Name = "combBx_Borrowed_Book_Due_Status";
            this.combBx_Borrowed_Book_Due_Status.Size = new System.Drawing.Size(121, 21);
            this.combBx_Borrowed_Book_Due_Status.TabIndex = 21;
            this.combBx_Borrowed_Book_Due_Status.SelectedIndexChanged += new System.EventHandler(this.combBx_Borrowed_Book_Due_Status_SelectedIndexChanged);
            // 
            // checkReturned
            // 
            this.checkReturned.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkReturned.AutoSize = true;
            this.checkReturned.Location = new System.Drawing.Point(662, 58);
            this.checkReturned.Name = "checkReturned";
            this.checkReturned.Size = new System.Drawing.Size(100, 17);
            this.checkReturned.TabIndex = 23;
            this.checkReturned.Text = "Show Returned";
            this.checkReturned.UseVisualStyleBackColor = true;
            this.checkReturned.CheckedChanged += new System.EventHandler(this.checkReturned_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Silver;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Location = new System.Drawing.Point(12, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 24;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // BorrowersSearchLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 428);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.checkReturned);
            this.Controls.Add(this.dtGrdVw_BorrwerSearch);
            this.Controls.Add(this.btn_ReturnBook_BorrowerSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combBx_Borrowed_Book_Due_Status);
            this.Controls.Add(this.btn_Borrower_Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combBx_Book_ID_BorrowerSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combBx_Borrower_First_Name_BorrowerSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combBx_Borrower_Last_Name_BorrowerSearch);
            this.Controls.Add(this.txtBx_BorrowerSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowersSearchLayoutForm";
            this.Text = "BorrowersSearchLayoutForm";
            this.Load += new System.EventHandler(this.BorrowersSearchLayoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_BorrwerSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Borrower_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combBx_Book_ID_BorrowerSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combBx_Borrower_First_Name_BorrowerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combBx_Borrower_Last_Name_BorrowerSearch;
        private System.Windows.Forms.TextBox txtBx_BorrowerSearch;
        private System.Windows.Forms.Button btn_ReturnBook_BorrowerSearch;
        private System.Windows.Forms.DataGridView dtGrdVw_BorrwerSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combBx_Borrowed_Book_Due_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrowed_Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrower_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Book_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrowed_Book_Due_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrowed_Book_Due_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Borrowed_Book_Number_of_Copies;
        private System.Windows.Forms.CheckBox checkReturned;
        private System.Windows.Forms.Button buttonRefresh;
    }
}