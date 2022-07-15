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

namespace LibrartDataManagementSystem.Borrowers_Return_Book_Forms
{
    public partial class BorrowersReturnPopup : Form
    {
        private BorrowersController _borrowersController = new BorrowersController();
        private BooksController _booksController = new BooksController();
        private string _id;
        public BorrowersReturnPopup(string id)
        {
            _id = id;
            InitializeComponent();
        }

        private void BorrowersReturnPopup_Load(object sender, EventArgs e)
        {
            quantityCount.Maximum = _borrowersController.GetQuantity(_id);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReturnAll_Click(object sender, EventArgs e)
        {
            string prompt = "Confirm to return all?";
            DialogResult dialogResult = MessageBox.Show(prompt, "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _borrowersController.ChangeDueStatus(_id, "Returned");
                _borrowersController.GenerateReturnDate(_id);
                _booksController.AddBookQuantity(_borrowersController.GetBookID(_id),
                    _borrowersController.GetQuantity(_id));
                MessageBox.Show("Successfully returned", "Success");
                this.Close();
            }
        }
    }
}
