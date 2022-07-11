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
    public partial class TransactionBorrowLayoutForm : Form
    {

        List<List<string>> demoListOfListOfString;
        BooksController _booksController = new BooksController();

        public TransactionBorrowLayoutForm()
        {
            InitializeComponent();

            testDemolangMember();
            testDemolangBooks();
        }
        // inayos layout


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void TransactionBorrowLayoutForm_Load(object sender, EventArgs e)
        {
            // books
            _booksController.FillDropdown(combBx_Book_Author_TransactionBorrow, "Book_Author");
            _booksController.FillDropdown(combBx_Book_Genre_TransactionBorrow, "Book_Genre");
            _booksController.FillDropdown(combBx_Book_Year_Published_TransactionBorrow, "Book_Year_Published");

            combBx_Book_Author_TransactionBorrow.SelectedIndex = 0;
            combBx_Book_Genre_TransactionBorrow.SelectedIndex = 0;
            combBx_Book_Year_Published_TransactionBorrow.SelectedIndex = 0;

            // fill the table
            _booksController.FillTable(
                dtGrdVw_Book_TransactionBorrow, txtBx_SearchBook_TransactionBorrow.Text,
                combBx_Book_Author_TransactionBorrow.SelectedItem.ToString(),
                combBx_Book_Genre_TransactionBorrow.SelectedItem.ToString(),
                combBx_Book_Year_Published_TransactionBorrow.SelectedItem.ToString());
            _booksController.FillQuantityColor(dtGrdVw_Book_TransactionBorrow);
            // end of books
        }

        // Books
        /// <summary>
        /// Generate table and dropdown
        /// </summary>
        /// <param name="withDropdown">generate dropdown list if true</param>
        public void GenerateTable(bool withDropdown = true, bool fromOtherForm = false)
        {
            if (withDropdown)
            {
                int authorIndex = combBx_Book_Author_TransactionBorrow.SelectedIndex;
                int genreIndex = combBx_Book_Genre_TransactionBorrow.SelectedIndex;
                int yearIndex = combBx_Book_Year_Published_TransactionBorrow.SelectedIndex;
                _booksController.FillDropdown(combBx_Book_Author_TransactionBorrow, "Book_Author");
                _booksController.FillDropdown(combBx_Book_Genre_TransactionBorrow, "Book_Genre");
                _booksController.FillDropdown(combBx_Book_Year_Published_TransactionBorrow, "Book_Year_Published"); ;

                combBx_Book_Author_TransactionBorrow.SelectedIndex = authorIndex;
                combBx_Book_Genre_TransactionBorrow.SelectedIndex = genreIndex;
                combBx_Book_Year_Published_TransactionBorrow.SelectedIndex = yearIndex;
            }

            _booksController.FillTable(
                dtGrdVw_Book_TransactionBorrow, txtBx_SearchBook_TransactionBorrow.Text,
                combBx_Book_Author_TransactionBorrow.SelectedItem.ToString(),
                combBx_Book_Genre_TransactionBorrow.SelectedItem.ToString(),
                combBx_Book_Year_Published_TransactionBorrow.SelectedItem.ToString());
            _booksController.FillQuantityColor(dtGrdVw_Book_TransactionBorrow);
        }
        /// <summary>
        /// search button is pressed for the books
        /// </summary>
        private void btn_Book_Search_TransactionBorrow_Click(object sender, EventArgs e)
        {
            GenerateTable(false);
        }
        private void DropdownChange(object sender, EventArgs e)
        {
            if (combBx_Book_Author_TransactionBorrow.SelectedItem != null &&
                combBx_Book_Genre_TransactionBorrow.SelectedItem != null &&
                combBx_Book_Year_Published_TransactionBorrow.SelectedItem != null)
            {
                GenerateTable(false);
            }
        }
        // End Books

        private void testDemolangMember()
        {
            dtGrdVw_Member_TransactionBorrow.Rows.Clear();

            demoListOfListOfString = generate2DListStringMember();

            foreach (List<string> infos in demoListOfListOfString)
            {
                int outerIndex = dtGrdVw_Member_TransactionBorrow.Rows.Add();
                int innerIndex = 0;
                foreach (string info in infos)
                {
                    dtGrdVw_Member_TransactionBorrow.Rows[outerIndex].Cells[innerIndex].Value = info;
                    innerIndex++;
                }
            }


        }


        private List<List<string>> generate2DListStringMember()
        {
            List<List<string>> list2dString = new List<List<string>>();
            List<String> rowListString = new List<string>();

            rowListString.Add("Member-ID-12345");
            rowListString.Add("Tan");
            rowListString.Add("Frederick");
            rowListString.Add("B.");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");

            list2dString.Add(rowListString);

            return list2dString;
        }

        private void testDemolangBooks()
        {
            dtGrdVw_Book_TransactionBorrow.Rows.Clear();

            demoListOfListOfString = generate2DListStringBook();

            foreach (List<string> infos in demoListOfListOfString)
            {
                int outerIndex = dtGrdVw_Book_TransactionBorrow.Rows.Add();
                int innerIndex = 0;
                foreach (string info in infos)
                {
                    dtGrdVw_Book_TransactionBorrow.Rows[outerIndex].Cells[innerIndex].Value = info;
                    innerIndex++;
                }
            }


        }

        private List<List<string>> generate2DListStringBook()
        {
            List<List<string>> list2dString = new List<List<string>>();
            List<String> rowListString = new List<string>();

            rowListString.Add("Book-ID-54321");
            rowListString.Add("Book of Life");
            rowListString.Add("Master Sensei");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            
            list2dString.Add(rowListString);

            return list2dString;
        }

        private void dtGrdVw_Member_TransactionBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow myRow = this.dtGrdVw_Member_TransactionBorrow.Rows[e.RowIndex];

                txtBx_Borrower_ID_BorrowLayout.Text = myRow.Cells[0].Value.ToString();
                txtBx_LastName_BorrowLayout.Text = myRow.Cells[1].Value.ToString();
                txtBx_FirstName_BorrowLayout.Text = myRow.Cells[2].Value.ToString();
                txtBx_MiddleName_BorrowLayout.Text = myRow.Cells[3].Value.ToString();
                txtBx_Address_BorrowLayout.Text = myRow.Cells[4].Value.ToString();
                txtBx_ContactNumber_BorrowLayout.Text = myRow.Cells[5].Value.ToString();
                txtBx_Age_BorrowLayout.Text = myRow.Cells[6].Value.ToString();
                txtBx_TypeValidID_BorrowLayout.Text = myRow.Cells[7].Value.ToString();

                //*/

            }

        }

        private void dtp_Date_Borrowed_BorrowLayout_ValueChanged(object sender, EventArgs e)
        {
            //dtp_Date_Borrowed_BorrowLayout
        }

        private void dtp_Due_Date_BorrowLayout_ValueChanged(object sender, EventArgs e)
        {
            //dtp_Due_Date_BorrowLayout
        }

        private void dtGrdVw_Book_TransactionBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MessageBox.Show("Books!!");

                DataGridViewRow myRow = this.dtGrdVw_Book_TransactionBorrow.Rows[e.RowIndex];

                txt_Book_ID_BorrowLayout.Text = myRow.Cells[0].Value.ToString();
                combBx_Book_Title_BorrowLayout.Text = myRow.Cells[1].Value.ToString();
                txt_Book_Author_BorrowLayout.Text = myRow.Cells[2].Value.ToString();


                //combBx_NumCopies__BorrowLayout.Text = myRow.Cells[""].Value.ToString();

                //*/

            }
        }
    }
}
