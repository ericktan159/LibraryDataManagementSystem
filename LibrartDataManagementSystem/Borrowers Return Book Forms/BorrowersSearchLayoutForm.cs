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
using LibrartDataManagementSystem.Borrowers_Return_Book_Forms;
using System.Globalization;

namespace LibrartDataManagementSystem
{
    public partial class BorrowersSearchLayoutForm : Form
    {
        BorrowersController _borrowersController = new BorrowersController();
        private LogController _logController = new LogController();
        BooksController _booksController = new BooksController();

        public BorrowersSearchLayoutForm()
        {
            InitializeComponent();
        }

        private void BorrowersSearchLayoutForm_Load(object sender, EventArgs e)
        {
            combBx_Borrowed_Book_Due_Status.SelectedIndex = 0;
            buttonRefresh.PerformClick();
        }

        /// <summary>
        /// if they choose returned automatically check the checkReturned
        /// </summary>
        private void combBx_Borrowed_Book_Due_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combBx_Borrowed_Book_Due_Status.SelectedItem.ToString() == "Returned")
            {
                checkReturned.Checked = true;
            }
            TableFill();
        }

        /// <summary>
        /// if they uncheck and the dropdown is in the returned dropdownlist
        /// change the index of dropdown
        /// </summary>
        private void checkReturned_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkReturned.Checked && combBx_Borrowed_Book_Due_Status.SelectedItem.ToString()
                == "Returned")
            {
                combBx_Borrowed_Book_Due_Status.SelectedIndex = 0;
            }
            buttonRefresh.PerformClick();
        }

        private void TableFill()
        {
            _borrowersController.FillTable(dtGrdVw_BorrwerSearch, txtBx_BorrowerSearch.Text,
                combBx_Borrower_First_Name_BorrowerSearch.Text, combBx_Borrower_Last_Name_BorrowerSearch.Text,
                combBx_Book_ID_BorrowerSearch.Text, combBx_Borrowed_Book_Due_Status.Text, checkReturned);
        }

        private void btn_Borrower_Search_Click(object sender, EventArgs e)
        {
            TableFill();
        }

        private void DropDownChange(object sender, EventArgs e)
        {
            TableFill();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            _borrowersController.UpdateDueStatus();
            _borrowersController.FillDropDown(combBx_Borrower_First_Name_BorrowerSearch,
                combBx_Borrower_Last_Name_BorrowerSearch, combBx_Book_ID_BorrowerSearch);
            TableFill();

            //DateTime time = DateTime.ParseExact("07-17-2022", "MM-dd-yyyy", CultureInfo.InvariantCulture);
            //Console.WriteLine(time);
            //TimeSpan time = DateTime.ParseExact("07-14-2022", "MM-dd-yyyy", CultureInfo.InvariantCulture)
            //    .AddDays(1)
            //    .Subtract(DateTime.Now);
            //Console.WriteLine((time > TimeSpan.Zero));
        }

        private void dtGrdVw_BorrwerSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtGrdVw_BorrwerSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_BorrwerSearch.Rows[rowIndex].Cells["Column_Borrowed_Book_ID"].Value.ToString();

            BorrowersDetailPopup detailPopup = new BorrowersDetailPopup(id);
            detailPopup.ShowDialog();
        }

        private void btn_ReturnBook_BorrowerSearch_Click(object sender, EventArgs e)
        {
            int rowIndex = dtGrdVw_BorrwerSearch.CurrentCellAddress.Y;
            if (rowIndex > -1)
            {
                string id = dtGrdVw_BorrwerSearch.Rows[rowIndex].Cells["Column_Borrowed_Book_ID"].Value.ToString();
                int quantity = int.Parse(dtGrdVw_BorrwerSearch.Rows[rowIndex]
                    .Cells["Column_Borrowed_Book_Number_of_Copies"].Value.ToString());
                string status = dtGrdVw_BorrwerSearch.Rows[rowIndex]
                    .Cells["Column_Borrowed_Book_Due_Status"].Value.ToString();
                if (status != "Returned")
                {
                    if (quantity > 1)
                    {
                        BorrowersReturnPopup returnPopup = new BorrowersReturnPopup(id);
                        returnPopup.ShowDialog();
                    }
                    else
                    {
                        string prompt = "Confirm Returning Books?";
                        DialogResult dialogResult = MessageBox.Show(prompt, "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            _borrowersController.ChangeDueStatus(id, "Returned");
                            _borrowersController.GenerateReturnDate(id);
                            _booksController.AddBookQuantity(_borrowersController.GetBookID(id), 1);
                            if (!_logController.LogReturnBorrow(id, _borrowersController.GetBookID(id),
                                _borrowersController.GetMemberID(id), "All", 2))
                            {
                                MessageBox.Show("Error at making logs please input log manually", "Error");
                            }
                        }
                    }
                    buttonRefresh.PerformClick();
                }
                else
                {
                    MessageBox.Show("You can't return a book that's already returned!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
