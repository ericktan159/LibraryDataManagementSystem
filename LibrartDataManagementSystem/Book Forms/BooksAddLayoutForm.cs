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
using System.Globalization;

namespace LibrartDataManagementSystem
{
    public partial class BooksAddLayoutForm : Form
    {
        private LDMS_DataBaseController _dabaBasecontroller = new LDMS_DataBaseController();
        private TextBox[] _requiredInputs;
        private BooksController _bookController = new BooksController();
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

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
            try
            {
                if (int.Parse(txtBx_NumOfQuantity_BookAdd.Text) > 99)
                {
                    txtBx_NumOfQuantity_BookAdd.Text = "99";
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// add the inputted details of book to database
        /// </summary>
        private void btn_BookAdd_Click(object sender, EventArgs e)
        {
            if(txtBx_NumOfQuantity_BookAdd.Text.Trim() == "")
            {
                txtBx_NumOfQuantity_BookAdd.Text = "1";
            }
            if(_bookController.isInputComplete(_requiredInputs)) // check if input is complete
            {
                bool confirmedAdd = false;
                List<string> existingBooks = _bookController.CheckIfBookExist(txtBx_BookTitle_BookAdd.Text, 
                    txtBx_BookAuthor_BookAdd.Text, txtBx_BookGenre_BookAdd.Text, txtBx_BookPublisher_BookAdd.Text,
                    dtp_BookYearPublishe_BookAdd.Text);
                if (existingBooks.Count > 0) // check if any book with the inputted value existed
                {
                    foreach (string book in existingBooks) // iterate too all existed book
                    {
                        if (!confirmedAdd)
                        {
                            string prompt = $"{ti.ToTitleCase(_bookController.GetBookTitle(book))} " +
                                $"is existing. Same with author and everything.\n\n" +
                                $"Do you wish to add this book to existing one? By pressing No " +
                                $"the inputted books will be added as a new book.";
                            DialogResult dialog = MessageBox.Show(prompt, "Confirm",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (dialog == DialogResult.Yes) // update the books quantity
                            {
                                // update method here
                                bool success = _bookController.AddBookQuantity(book,
                                    int.Parse(txtBx_NumOfQuantity_BookAdd.Text));
                                if(success)
                                {
                                    MessageBox.Show($"Successfully added " +
                                        $"{ti.ToTitleCase(txtBx_BookTitle_BookAdd.Text)} " +
                                        $"to an existing book!", "Success");
                                }

                                if (checkResetAfterSubmit.Checked)
                                {
                                    _bookController.ClearInputs(_requiredInputs);
                                }

                                confirmedAdd = true;

                            }
                            else if (dialog == DialogResult.Cancel)
                            {
                                confirmedAdd = true;
                            }
                        }
                    }
                }

                // if the book does not exist or it isn't add to the existing one
                if(!confirmedAdd)
                {
                    if (MessageBox.Show("Do you wish to add this book?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool success = _bookController.AddBooks(txtBx_BookTitle_BookAdd.Text,
                            txtBx_BookAuthor_BookAdd.Text,
                            txtBx_BookGenre_BookAdd.Text, dtp_BookYearPublishe_BookAdd.Text,
                            txtBx_BookPublisher_BookAdd.Text, txtBx_NumOfQuantity_BookAdd.Text);
                        if (success)
                        {
                            MessageBox.Show($"{ti.ToTitleCase(txtBx_BookTitle_BookAdd.Text)} is successfully added!", "Success!");
                            if (checkResetAfterSubmit.Checked)
                            {
                                _bookController.ClearInputs(_requiredInputs);
                            }
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

        private void BooksAddLayoutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
