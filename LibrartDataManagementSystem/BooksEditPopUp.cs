using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrartDataManagementSystem.Scripts;

namespace LibrartDataManagementSystem
{
    public partial class BooksEditPopUp : Form
    {
        private string _id;
        private BooksController _booksController = new BooksController();
        private TextBox[] _inputs;
        private BooksSearchLayoutFormcs _searchBookForm = new BooksSearchLayoutFormcs();
        public BooksEditPopUp(string bookID)
        {
            _id = bookID;
            InitializeComponent();

            _inputs = new TextBox[5] {
                txtBx_BookTitle_BookAdd, txtBx_BookAuthor_BookAdd, txtBx_BookGenre_BookAdd,
                txtBx_BookPublisher_BookAdd, txtBx_NumOfQuantity_BookAdd };
        }

        /// <summary>
        /// Accept number only
        /// </summary>
        private void txtBx_NumOfQuantity_BookAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// keeps the value 1-99 only
        /// </summary>
        private void txtBx_NumOfQuantity_BookAdd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if ((int.Parse(txtBx_NumOfQuantity_BookAdd.Text) > 99) &&
                    txtBx_NumOfQuantity_BookAdd.Text.Length > 0)
                {
                    txtBx_NumOfQuantity_BookAdd.Text = "99";
                }
            }
            catch
            {
                txtBx_NumOfQuantity_BookAdd.Text = "1";
            }
        }

        /// <summary>
        /// initialize values
        /// </summary>
        private void BooksEditPopUp_Load(object sender, EventArgs e)
        {
            _booksController.FillInputs(txtBx_BookTitle_BookAdd, txtBx_BookAuthor_BookAdd,
                txtBx_BookGenre_BookAdd, dtp_BookYearPublishe_BookAdd, txtBx_BookPublisher_BookAdd,
                txtBx_NumOfQuantity_BookAdd, _id);
        }

        /// <summary>
        /// when update button is clicked check if input is complete and update the book
        /// </summary>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string prompt = "Do you wish to update the book?";
            bool success = false;
            if (_booksController.isInputComplete(_inputs))
            {
                if(MessageBox.Show(prompt, "Confirm", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    success = _booksController.UpdateBooks(txtBx_BookTitle_BookAdd, txtBx_BookAuthor_BookAdd,
                txtBx_BookGenre_BookAdd, dtp_BookYearPublishe_BookAdd, txtBx_BookPublisher_BookAdd,
                txtBx_NumOfQuantity_BookAdd, _id);
                }
            }
            if(success)
            {
                MessageBox.Show("Successfully Updated!", "Success!");
            }
            this.Close();
        }
    }
}
