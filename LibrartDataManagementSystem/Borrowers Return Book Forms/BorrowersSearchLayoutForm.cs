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
    public partial class BorrowersSearchLayoutForm : Form
    {
        BorrowersController _borrowersController = new BorrowersController();

        public BorrowersSearchLayoutForm()
        {
            InitializeComponent();
        }

        private void BorrowersSearchLayoutForm_Load(object sender, EventArgs e)
        {
            combBx_Borrowed_Book_Due_Status.SelectedIndex = 0;
            combBx_Book_ID_BorrowerSearch.SelectedIndex = 0;
            combBx_Borrower_First_Name_BorrowerSearch.SelectedIndex = 0;
            combBx_Borrower_Last_Name_BorrowerSearch.SelectedIndex = 0;
            TableFill();
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
        }

        private void TableFill()
        {
            _borrowersController.FillTable(dtGrdVw_BorrwerSearch, txtBx_BorrowerSearch.Text,
                combBx_Borrower_First_Name_BorrowerSearch.Text, combBx_Borrower_Last_Name_BorrowerSearch.Text,
                combBx_Book_ID_BorrowerSearch.Text, checkReturned);
        }

        private void btn_Borrower_Search_Click(object sender, EventArgs e)
        {
            TableFill();
        }
    }
}
