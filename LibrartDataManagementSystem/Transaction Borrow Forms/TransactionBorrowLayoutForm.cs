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
        LDMS_DataBaseController _LDMS_DataBaseControlle = new LDMS_DataBaseController();
        List<List<string>> demoListOfListOfString;
        BooksController _booksController = new BooksController();
        MembersController _MembersController = new MembersController();


        Member_Search_Controller searchMemberForm;

        Info_TBL_BORROWED_BOOK tbl_Infos; 

        private int numberOfAvableBooks = 0;
        private int numberOfCopiesTaken = 0;

        public TransactionBorrowLayoutForm()
        {
            InitializeComponent();

            searchMemberForm = new Member_Search_Controller(
            combBx_Borrower_First_Name_TransactionBorrow,
            combBx_Borrower_Last_Name_TransactionBorrow,
            combBx_Borrower_Gender_TransactionBorrow,
            dtGrdVw_Member_TransactionBorrow,
            txtBx_SearchMember_TransactionBorrow);

            //testDemolangMember();
            //testDemolangBooks();
            //demoTestSamembersTable();
        }
        // inayos layout

        private void demoTestSamembersTable()
        {
            DataGridView tableDataGrid = dtGrdVw_Member_TransactionBorrow;
            List<List<string>> tbl_borrower_2D_List = _LDMS_DataBaseControlle.select_DBMethod_BORROWER();

            tableDataGrid.Rows.Clear();
            foreach (List<string> tbl_borrower_row in tbl_borrower_2D_List)
            {
                int outerIndex = tableDataGrid.Rows.Add();
                tableDataGrid.Rows[outerIndex].Cells["Column_Borrower_ID"].Value = tbl_borrower_row[0];
                tableDataGrid.Rows[outerIndex].Cells["Column_Borrower_First_Name"].Value = tbl_borrower_row[1];
                tableDataGrid.Rows[outerIndex].Cells["Column_Borrower_Middle_Name"].Value = tbl_borrower_row[2];
                tableDataGrid.Rows[outerIndex].Cells["Column_Borrower_Last_Name"].Value = tbl_borrower_row[3];
                tableDataGrid.Rows[outerIndex].Cells["Column_Borrower_Gender"].Value = tbl_borrower_row[4];
                tableDataGrid.Rows[outerIndex].Cells["Column_Borrower_Address"].Value = tbl_borrower_row[5];
                tableDataGrid.Rows[outerIndex].Cells["Column_Borrower_Conatact_Number"].Value = tbl_borrower_row[6];
                tableDataGrid.Rows[outerIndex].Cells["Column_Borrower_BirthDate"].Value = tbl_borrower_row[7];
                tableDataGrid.Rows[outerIndex].Cells["Column_Borrower_Type_Valid_ID"].Value = tbl_borrower_row[8];
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void TransactionBorrowLayoutForm_Load(object sender, EventArgs e)
        {
            

            ///////////
            searchMemberForm.event_FormLoad();
            ///////////////
            ///

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
            GenerateTable();

            dtp_Date_Borrowed_BorrowLayout.MinDate = DateTime.Now;
            dtp_Due_Date_BorrowLayout.MinDate = DateTime.Now;
            dtp_Date_Borrowed_BorrowLayout.MaxDate = DateTime.Now;
            dtp_Due_Date_BorrowLayout.MaxDate = DateTime.Now.AddDays(7);
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
                txtBx_FirstName_BorrowLayout.Text = myRow.Cells[1].Value.ToString();
                txtBx_MiddleName_BorrowLayout.Text = myRow.Cells[2].Value.ToString();
                txtBx_LastName_BorrowLayout.Text = myRow.Cells[3].Value.ToString();
                txtBx_Gender_BorrowLayout.Text = myRow.Cells[4].Value.ToString();
                txtBx_Address_BorrowLayout.Text = myRow.Cells[5].Value.ToString();
                txtBx_ContactNumber_BorrowLayout.Text = myRow.Cells[6].Value.ToString();
                txtBx_Age_BorrowLayout.Text = myRow.Cells[7].Value.ToString();
                txtBx_TypeValidID_BorrowLayout.Text = myRow.Cells[8].Value.ToString();

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

        private void btn_IssueBorrowBook_Click(object sender, EventArgs e)
        {
            //demmoInsertIssue();
            string prompt = "Confirm Details:\n" +
                $"Member ID: {txtBx_Borrower_ID_BorrowLayout.Text}\n" +
                $"Member Name: \"{txtBx_LastName_BorrowLayout.Text}, {txtBx_FirstName_BorrowLayout.Text} " +
                $"{txtBx_MiddleName_BorrowLayout.Text}\"\n" +
                $"Borrowing a book:\n" +
                $"Book ID: {txt_Book_ID_BorrowLayout.Text}\n" +
                $"Book Title: \"{combBx_Book_Title_BorrowLayout.Text}\" with {quantityCount.Value} copies\n" +
                $"Is this the correct details?";
            if (txtBx_Borrower_ID_BorrowLayout.Text.Trim() != "" && txt_Book_ID_BorrowLayout.Text.Trim() != "")
            {
                DialogResult dialogResult = MessageBox.Show(prompt, "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    insert_Borrowed_Book();
                    searchMemberForm.event_refresh();
                    GenerateTable();
                }
            }
        }
        private void demmoInsertIssue()
        {
            insert_Borrowed_Book();            
        }

        private void insert_Borrowed_Book()
        {
            //tbl_Infos.Book_ID = int.Parse(txt_Book_ID_BorrowLayout.Text);
            //tbl_Infos.Borrower_ID = int.Parse(txtBx_Borrower_ID_BorrowLayout.Text);
            tbl_Infos = new Info_TBL_BORROWED_BOOK(int.Parse(txt_Book_ID_BorrowLayout.Text), int.Parse(txtBx_Borrower_ID_BorrowLayout.Text));
            tbl_Infos.Borrowed_Book_Date_Borrowed = dtp_Date_Borrowed_BorrowLayout.Value.ToString("MM-dd-yyyy");
            tbl_Infos.Borrowed_Book_Due_Date = dtp_Due_Date_BorrowLayout.Value.ToString("MM-dd-yyyy");
            tbl_Infos.Borrowed_Book_Due_Status = "Not Overdue";
            tbl_Infos.Borrowed_Book_Date_Returned = "";
            tbl_Infos.Borrowed_Book_Number_of_Copies = int.Parse(quantityCount.Value.ToString());


            int num_Qntty = int.Parse(_LDMS_DataBaseControlle.select_DBMethod_return_a_Cell(Info_TBL_BOOK.Const_Names.table_Name,
                                                                tbl_Infos.get_Foreign_Key_Book_ID(),
                                                                Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST));

            int number_of_Books_Left = num_Qntty - tbl_Infos.Borrowed_Book_Number_of_Copies;

            bool isSuccess;



            if ((number_of_Books_Left >= 0))
            {
                isSuccess = _LDMS_DataBaseControlle.insert_DBMethod_BORROWED_BOOK(tbl_Infos);
            }
            else
            {
                isSuccess = false;

                MessageBox.Show("Cannot Borrow the book!!! No Avalable copies");
            }


            //(Book_ID, Borrower_ID, Borrowed_Book_Date_Borrowed, Borrowed_Book_Due_Date, Borrowed_Book_Due_Status, Borrowed_Book_Date_Returned, Borrowed_Book_Number_of_Copies);
            if (isSuccess)
            {
                MessageBox.Show("Succes Issue!!!");
            }
            else
            {
                MessageBox.Show("Not Succes Issue!!!");
            }
        }

        private void btn_Member_Search_TransactionBorrow_Click(object sender, EventArgs e)
        {
            searchMemberForm.event_Click_Searh();
        }

        private void combx_Search_Filters_Change(object sender, EventArgs e)
        {
            searchMemberForm.event_DropdownChange();
        }

        private void dtGrdVw_Book_TransactionBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtGrdVw_Book_TransactionBorrow.CurrentCellAddress.Y;
            if (row > -1)
            {
                //MessageBox.Show("Books!!");
                int quantity = int.Parse(dtGrdVw_Book_TransactionBorrow.Rows[row]
                    .Cells["Column_Book_Number_Of_Quantity"]
                    .Value
                    .ToString());

                if (quantity > 0)
                {
                    quantityCount.Maximum = quantity;
                    DataGridViewRow myRow = dtGrdVw_Book_TransactionBorrow.Rows[row];

                    txt_Book_ID_BorrowLayout.Text = myRow.Cells[0].Value.ToString();
                    combBx_Book_Title_BorrowLayout.Text = myRow.Cells[1].Value.ToString();
                    txt_Book_Author_BorrowLayout.Text = myRow.Cells[2].Value.ToString();

                    numberOfAvableBooks = int.Parse(myRow
                        .Cells["Column_Book_Number_Of_Quantity"].Value.ToString());
                }
                else
                {
                    MessageBox.Show("This book is out of stock");
                }
            }
        }
    }
}
