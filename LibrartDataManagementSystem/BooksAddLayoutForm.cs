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
    public partial class BooksAddLayoutForm : Form
    {
        private LDMS_DataBaseController _dabaBasecontroller = new LDMS_DataBaseController();
        private TextBox[] _requiredInputs;
        private BooksController _bookController = new BooksController();

        public BooksAddLayoutForm()
        {
            InitializeComponent();
            // initialize require input list
            _requiredInputs = new TextBox[5] {
                txtBx_BookTitle_BookAdd, txtBx_BookAuthor_BookAdd, txtBx_BookGenre_BookAdd,
                txtBx_BookPublisher_BookAdd, txtBx_NumOfQuantity_BookAdd };
        }

        // Validations method
        /// <summary>
        /// check if the pressed key is not a digit or backspace then ignore the key
        /// and dont put in the input
        /// </summary>
        private void txtBx_NumOfQuantity_BookAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// keep the value at 99 max
        /// </summary>
        private void txtBx_NumOfQuantity_BookAdd_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int.Parse(txtBx_NumOfQuantity_BookAdd.Text) > 99) &&
                txtBx_NumOfQuantity_BookAdd.Text.Length > 0)
            {
                txtBx_NumOfQuantity_BookAdd.Text = "99";
            }
        }

        /// <summary>
        /// add the inputted details of book to database
        /// </summary>
        private void btn_BookAdd_Click(object sender, EventArgs e)
        {
            if(_bookController.isInputComplete(_requiredInputs))
            {
                bool confirmedAdd = false;
                List<string> existingBooks = _bookController.CheckIfBookExist(txtBx_BookTitle_BookAdd.Text, 
                    txtBx_BookAuthor_BookAdd.Text);
                if (existingBooks.Count > 0)
                {
                    foreach (string book in existingBooks)
                    {
                        if (!confirmedAdd)
                        {
                            string prompt = $"{_bookController.GetBookTitleByID(book)} is existing with the id of " +
                                $"{book} do you wish to add this book to existing one? By pressing No " +
                                $"the inputted books will be added as a new book.";
                            if (MessageBox.Show(prompt, "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                                System.Windows.Forms.DialogResult.Yes)
                            {
                                // update method here
                                MessageBox.Show("Updated Message Here");
                                confirmedAdd = true;
                            }
                        }
                    }
                }
                if(!confirmedAdd)
                {
                    bool success = _bookController.AddBooks(txtBx_BookTitle_BookAdd.Text, txtBx_BookAuthor_BookAdd.Text,
                        txtBx_BookGenre_BookAdd.Text, dtp_BookYearPublishe_BookAdd.Text,
                        txtBx_BookPublisher_BookAdd.Text, txtBx_NumOfQuantity_BookAdd.Text);
                    if (success)
                    {
                        MessageBox.Show($"{txtBx_BookTitle_BookAdd.Text} is successfully added!", "Success!");
                        if (checkResetAfterSubmit.Checked)
                        {
                            _bookController.ClearInputs(_requiredInputs);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// clear all the inputs
        /// </summary>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            _bookController.ClearInputs(_requiredInputs);
        }
    }
}
