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
        private void BooksAddLayoutForm_Load(object sender, EventArgs e)
        {

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

        private void btn_BookAdd_Click(object sender, EventArgs e)
        {
            if(_bookController.isInputComplete(_requiredInputs))
            {
                _bookController.AddBooks(txtBx_BookTitle_BookAdd.Text, txtBx_BookAuthor_BookAdd.Text,
                    txtBx_BookGenre_BookAdd.Text, dtp_BookYearPublishe_BookAdd.Text,
                    txtBx_BookPublisher_BookAdd.Text, txtBx_NumOfQuantity_BookAdd.Text);
            }
        }
    }
}
