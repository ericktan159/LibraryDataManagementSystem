
namespace LibrartDataManagementSystem
{
    partial class BooksEditPopUp
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
            this.label_maxBooks = new System.Windows.Forms.Label();
            this.dtp_BookYearPublishe_BookAdd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBx_NumOfQuantity_BookAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_BookPublisher_BookAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_BookGenre_BookAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_BookAuthor_BookAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_BookTitle_BookAdd = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_maxBooks
            // 
            this.label_maxBooks.AutoSize = true;
            this.label_maxBooks.ForeColor = System.Drawing.Color.Red;
            this.label_maxBooks.Location = new System.Drawing.Point(132, 211);
            this.label_maxBooks.Name = "label_maxBooks";
            this.label_maxBooks.Size = new System.Drawing.Size(41, 13);
            this.label_maxBooks.TabIndex = 29;
            this.label_maxBooks.Text = "99 max";
            // 
            // dtp_BookYearPublishe_BookAdd
            // 
            this.dtp_BookYearPublishe_BookAdd.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtp_BookYearPublishe_BookAdd.CustomFormat = "yyyy";
            this.dtp_BookYearPublishe_BookAdd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_BookYearPublishe_BookAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BookYearPublishe_BookAdd.Location = new System.Drawing.Point(127, 115);
            this.dtp_BookYearPublishe_BookAdd.Name = "dtp_BookYearPublishe_BookAdd";
            this.dtp_BookYearPublishe_BookAdd.ShowUpDown = true;
            this.dtp_BookYearPublishe_BookAdd.Size = new System.Drawing.Size(59, 20);
            this.dtp_BookYearPublishe_BookAdd.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Number of Quantity";
            // 
            // txtBx_NumOfQuantity_BookAdd
            // 
            this.txtBx_NumOfQuantity_BookAdd.Location = new System.Drawing.Point(127, 188);
            this.txtBx_NumOfQuantity_BookAdd.Name = "txtBx_NumOfQuantity_BookAdd";
            this.txtBx_NumOfQuantity_BookAdd.Size = new System.Drawing.Size(59, 20);
            this.txtBx_NumOfQuantity_BookAdd.TabIndex = 24;
            this.txtBx_NumOfQuantity_BookAdd.Text = "1";
            this.txtBx_NumOfQuantity_BookAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_NumOfQuantity_BookAdd_KeyPress);
            this.txtBx_NumOfQuantity_BookAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBx_NumOfQuantity_BookAdd_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Publisher";
            // 
            // txtBx_BookPublisher_BookAdd
            // 
            this.txtBx_BookPublisher_BookAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_BookPublisher_BookAdd.Location = new System.Drawing.Point(127, 151);
            this.txtBx_BookPublisher_BookAdd.Name = "txtBx_BookPublisher_BookAdd";
            this.txtBx_BookPublisher_BookAdd.Size = new System.Drawing.Size(532, 20);
            this.txtBx_BookPublisher_BookAdd.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Year Published";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Genre";
            // 
            // txtBx_BookGenre_BookAdd
            // 
            this.txtBx_BookGenre_BookAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_BookGenre_BookAdd.Location = new System.Drawing.Point(127, 77);
            this.txtBx_BookGenre_BookAdd.Name = "txtBx_BookGenre_BookAdd";
            this.txtBx_BookGenre_BookAdd.Size = new System.Drawing.Size(121, 20);
            this.txtBx_BookGenre_BookAdd.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Author";
            // 
            // txtBx_BookAuthor_BookAdd
            // 
            this.txtBx_BookAuthor_BookAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_BookAuthor_BookAdd.Location = new System.Drawing.Point(127, 45);
            this.txtBx_BookAuthor_BookAdd.Name = "txtBx_BookAuthor_BookAdd";
            this.txtBx_BookAuthor_BookAdd.Size = new System.Drawing.Size(532, 20);
            this.txtBx_BookAuthor_BookAdd.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Book Title";
            // 
            // txtBx_BookTitle_BookAdd
            // 
            this.txtBx_BookTitle_BookAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_BookTitle_BookAdd.Location = new System.Drawing.Point(127, 6);
            this.txtBx_BookTitle_BookAdd.Name = "txtBx_BookTitle_BookAdd";
            this.txtBx_BookTitle_BookAdd.Size = new System.Drawing.Size(532, 20);
            this.txtBx_BookTitle_BookAdd.TabIndex = 17;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(319, 249);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 23);
            this.buttonUpdate.TabIndex = 30;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // BooksEditPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 284);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label_maxBooks);
            this.Controls.Add(this.dtp_BookYearPublishe_BookAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBx_NumOfQuantity_BookAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBx_BookPublisher_BookAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBx_BookGenre_BookAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_BookAuthor_BookAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_BookTitle_BookAdd);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(687, 323);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(687, 323);
            this.Name = "BooksEditPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.BooksEditPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_maxBooks;
        private System.Windows.Forms.DateTimePicker dtp_BookYearPublishe_BookAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBx_NumOfQuantity_BookAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBx_BookPublisher_BookAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_BookGenre_BookAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_BookAuthor_BookAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_BookTitle_BookAdd;
        private System.Windows.Forms.Button buttonUpdate;
    }
}