using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrartDataManagementSystem.Scripts
{
    class BorrowersController
    {
        LDMS_DataBaseController _dbController = new LDMS_DataBaseController();

        /// <summary>
        /// fill the table of the borrowers
        /// </summary>
        /// <param name="table">the table to fill</param>
        /// <param name="search">what to search text</param>
        /// <param name="fName">fname dropdown text</param>
        /// <param name="lName">lname dropdown text</param>
        /// <param name="bookID">bookid drodown text</param>
        /// <param name="returned">checkbox of to show returned</param>
        public void FillTable(DataGridView table, string search, string fName, string lName,
            string bookID, CheckBox returned)
        {
            table.Rows.Clear();

            search = search.Trim();

            string query = FillQuery(search, fName, lName, bookID, returned);

            List<List<string>> results = _dbController.select_DBMethod_return_2DList_Table_Records(query);

            // fill the table
            foreach (List<string> result in results)
            {
                int row = table.Rows.Add();
                table.Rows[row].Cells["Column_Borrowed_Book_ID"].Value = result[0];
                table.Rows[row].Cells["Column_Borrower_Name"].Value = 
                    $"{result[3]}, {result[1]} {result[2]}";
                table.Rows[row].Cells["Column_Book_Title"].Value = result[4];
                table.Rows[row].Cells["Column_Borrowed_Book_Due_Date"].Value = result[5];
                table.Rows[row].Cells["Column_Borrowed_Book_Due_Status"].Value = result[6];
                table.Rows[row].Cells["Column_Borrowed_Book_Number_of_Copies"].Value = result[7];
            }
        }

        private string FillQuery(string search, string fName, string lName,
            string bookID, CheckBox returned)
        {
            // initialize all needed query
            string query = "SELECT tbl_borrowed_book.Borrowed_Book_ID, tbl_borrower.Borrower_First_Name, " +
                "tbl_borrower.Borrower_Middle_Name, tbl_borrower.Borrower_Last_Name, tbl_book.Book_Title, " +
                "tbl_borrowed_book.Borrowed_Book_Due_Date, tbl_borrowed_book.Borrowed_Book_Due_Status, " +
                "tbl_borrowed_book.Borrowed_Book_Number_of_Copies FROM `tbl_borrowed_book` " +
                "INNER JOIN `tbl_book` ON tbl_borrowed_book.Book_ID = tbl_book.Book_ID INNER JOIN " +
                "`tbl_borrower` ON tbl_borrowed_book.Borrower_ID = tbl_borrower.Borrower_ID ";
            string whereQuery = "";
            string searchQuery = "";
            string fNameQuery = "";
            string lNameQuery = "";
            string bookIDQuery = "";
            string returnQuery = "";

            if(search != "")
            {
                whereQuery = "WHERE ";
                searchQuery = $"((tbl_borrower.Borrower_First_Name REGEXP \".*{search}.*\" OR " +
                    $"tbl_borrower.Borrower_Middle_Name REGEXP \".*{search}.*\" OR " +
                    $"tbl_borrower.Borrower_Last_Name REGEXP \".*{search}.*\" OR tbl_book.Book_Title " +
                    $"REGEXP \".*{search}.*\") ";
            }
            if(fName != "All")
            {
                if (whereQuery != "")
                {
                    fNameQuery = $"AND tbl_borrower.Borrower_First_Name = \"{fName}\" ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    fNameQuery = $"tbl_borrower.Borrower_First_Name = \"{fName}\" ";
                }
            }
            if (lName != "All")
            {
                if (whereQuery != "")
                {
                    lNameQuery = $"AND tbl_borrower.Borrower_Last_Name = \"{lName}\" ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    lNameQuery = $"tbl_borrower.Borrower_Last_Name = \"{lName}\" ";
                }
            }
            if (bookID != "All")
            {
                if (whereQuery != "")
                {
                    bookIDQuery = $"AND tbl_book.Book_ID = \"{bookID}\" ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    bookIDQuery = $"tbl_borrower.Borrower_Last_Name = \"{bookID}\" ";
                }
            }
            if(returned.Checked)
            {
                if(whereQuery != "")
                {
                    returnQuery = $"AND NOT tbl_borrowed_book.Borrowed_Book_Due_Status = \"Returned\"";
                }
                else
                {
                    whereQuery = "WHERE ";
                    returnQuery = "NOT tbl_borrowed_book.Borrowed_Book_Due_Status = \"Returned\"";
                }
            }
            return query + whereQuery + searchQuery + fNameQuery + lNameQuery + bookIDQuery + returnQuery;
        }
    }
}
