
namespace LibrartDataManagementSystem
{
    partial class BooksSearchLayoutFormcs
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
            this.txtBx_BookSearch = new System.Windows.Forms.TextBox();
            this.combBx_Book_Author = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGrdVw_BookSearch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combBx_Book_Genre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combBx_Book_Year_Published = new System.Windows.Forms.ComboBox();
            this.btn_Book_Search = new System.Windows.Forms.Button();
            this.btn_EditBookSearch = new System.Windows.Forms.Button();
            this.btn_DeleteBookSerach = new System.Windows.Forms.Button();
            this.Column_Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Book_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Book_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Book_Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Book_Year_published = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Book_Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Book_Number_Of_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_BookSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBx_BookSearch
            // 
            this.txtBx_BookSearch.Location = new System.Drawing.Point(206, 41);
            this.txtBx_BookSearch.Name = "txtBx_BookSearch";
            this.txtBx_BookSearch.Size = new System.Drawing.Size(260, 20);
            this.txtBx_BookSearch.TabIndex = 0;
            // 
            // combBx_Book_Author
            // 
            this.combBx_Book_Author.FormattingEnabled = true;
            this.combBx_Book_Author.Location = new System.Drawing.Point(155, 85);
            this.combBx_Book_Author.Name = "combBx_Book_Author";
            this.combBx_Book_Author.Size = new System.Drawing.Size(121, 21);
            this.combBx_Book_Author.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // dtGrdVw_BookSearch
            // 
            this.dtGrdVw_BookSearch.AllowUserToAddRows = false;
            this.dtGrdVw_BookSearch.AllowUserToDeleteRows = false;
            this.dtGrdVw_BookSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdVw_BookSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw_BookSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Book_ID,
            this.Column_Book_Title,
            this.Column_Book_Author,
            this.Column_Book_Genre,
            this.Column_Book_Year_published,
            this.Column_Book_Publisher,
            this.Column_Book_Number_Of_Quantity});
            this.dtGrdVw_BookSearch.Location = new System.Drawing.Point(21, 29);
            this.dtGrdVw_BookSearch.Name = "dtGrdVw_BookSearch";
            this.dtGrdVw_BookSearch.ReadOnly = true;
            this.dtGrdVw_BookSearch.Size = new System.Drawing.Size(745, 235);
            this.dtGrdVw_BookSearch.TabIndex = 3;
            this.dtGrdVw_BookSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVw_BookSearch_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_DeleteBookSerach);
            this.panel1.Controls.Add(this.btn_EditBookSearch);
            this.panel1.Controls.Add(this.dtGrdVw_BookSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 378);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Genre";
            // 
            // combBx_Book_Genre
            // 
            this.combBx_Book_Genre.FormattingEnabled = true;
            this.combBx_Book_Genre.Location = new System.Drawing.Point(294, 84);
            this.combBx_Book_Genre.Name = "combBx_Book_Genre";
            this.combBx_Book_Genre.Size = new System.Drawing.Size(121, 21);
            this.combBx_Book_Genre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year Published";
            // 
            // combBx_Book_Year_Published
            // 
            this.combBx_Book_Year_Published.FormattingEnabled = true;
            this.combBx_Book_Year_Published.Location = new System.Drawing.Point(421, 85);
            this.combBx_Book_Year_Published.Name = "combBx_Book_Year_Published";
            this.combBx_Book_Year_Published.Size = new System.Drawing.Size(121, 21);
            this.combBx_Book_Year_Published.TabIndex = 8;
            // 
            // btn_Book_Search
            // 
            this.btn_Book_Search.Location = new System.Drawing.Point(472, 38);
            this.btn_Book_Search.Name = "btn_Book_Search";
            this.btn_Book_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Book_Search.TabIndex = 10;
            this.btn_Book_Search.Text = "Search";
            this.btn_Book_Search.UseVisualStyleBackColor = true;
            // 
            // btn_EditBookSearch
            // 
            this.btn_EditBookSearch.Location = new System.Drawing.Point(260, 308);
            this.btn_EditBookSearch.Name = "btn_EditBookSearch";
            this.btn_EditBookSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_EditBookSearch.TabIndex = 4;
            this.btn_EditBookSearch.Text = "Edit";
            this.btn_EditBookSearch.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteBookSerach
            // 
            this.btn_DeleteBookSerach.Location = new System.Drawing.Point(370, 308);
            this.btn_DeleteBookSerach.Name = "btn_DeleteBookSerach";
            this.btn_DeleteBookSerach.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteBookSerach.TabIndex = 5;
            this.btn_DeleteBookSerach.Text = "Delete";
            this.btn_DeleteBookSerach.UseVisualStyleBackColor = true;
            // 
            // Column_Book_ID
            // 
            this.Column_Book_ID.HeaderText = "Book ID";
            this.Column_Book_ID.Name = "Column_Book_ID";
            this.Column_Book_ID.ReadOnly = true;
            // 
            // Column_Book_Title
            // 
            this.Column_Book_Title.HeaderText = "Book Title";
            this.Column_Book_Title.Name = "Column_Book_Title";
            this.Column_Book_Title.ReadOnly = true;
            // 
            // Column_Book_Author
            // 
            this.Column_Book_Author.HeaderText = "Author";
            this.Column_Book_Author.Name = "Column_Book_Author";
            this.Column_Book_Author.ReadOnly = true;
            // 
            // Column_Book_Genre
            // 
            this.Column_Book_Genre.HeaderText = "Genre";
            this.Column_Book_Genre.Name = "Column_Book_Genre";
            this.Column_Book_Genre.ReadOnly = true;
            // 
            // Column_Book_Year_published
            // 
            this.Column_Book_Year_published.HeaderText = "Year Published";
            this.Column_Book_Year_published.Name = "Column_Book_Year_published";
            this.Column_Book_Year_published.ReadOnly = true;
            // 
            // Column_Book_Publisher
            // 
            this.Column_Book_Publisher.HeaderText = "Publisher";
            this.Column_Book_Publisher.Name = "Column_Book_Publisher";
            this.Column_Book_Publisher.ReadOnly = true;
            // 
            // Column_Book_Number_Of_Quantity
            // 
            this.Column_Book_Number_Of_Quantity.HeaderText = "Number of Quantity";
            this.Column_Book_Number_Of_Quantity.Name = "Column_Book_Number_Of_Quantity";
            this.Column_Book_Number_Of_Quantity.ReadOnly = true;
            // 
            // BooksSearchLayoutFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 525);
            this.Controls.Add(this.btn_Book_Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combBx_Book_Year_Published);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combBx_Book_Genre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combBx_Book_Author);
            this.Controls.Add(this.txtBx_BookSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksSearchLayoutFormcs";
            this.Text = "BooksSearchLayoutFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw_BookSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_BookSearch;
        private System.Windows.Forms.ComboBox combBx_Book_Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGrdVw_BookSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combBx_Book_Genre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combBx_Book_Year_Published;
        private System.Windows.Forms.Button btn_Book_Search;
        private System.Windows.Forms.Button btn_DeleteBookSerach;
        private System.Windows.Forms.Button btn_EditBookSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Book_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Book_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Book_Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Book_Year_published;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Book_Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Book_Number_Of_Quantity;
    }
}