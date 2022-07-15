using System;
using System.Collections.Generic;
using System.Globalization;
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
        /// update the due status
        /// </summary>
        public void UpdateDueStatus()
        {
            string query = "SELECT `Borrowed_Book_ID`, `Borrowed_Book_Due_Date` FROM `tbl_borrowed_book` " +
                "WHERE `Borrowed_Book_Due_Status` != \"Returned\"";
            List<List<string>> results = _dbController.select_DBMethod_return_2DList_Table_Records(query);

            foreach (List<string> result in results)
            {
                TimeSpan timeSpanFromDue = DateTime.ParseExact(result[1], "MM-dd-yyyy", CultureInfo.InvariantCulture)
                    .AddDays(1)
                    .Subtract(DateTime.Now);
                if(!(timeSpanFromDue > TimeSpan.Zero)) // check if it's already past due date
                {
                    ChangeDueStatus(result[0], "Overdue");
                }
            }
        }

        public bool SubtractQuantity(string transacID, int value)
        {
            int finalQuantity = GetQuantity(transacID) - value;
            string query = $"UPDATE `tbl_borrowed_book` " +
                $"SET `Borrowed_Book_Number_of_Copies`='{finalQuantity}' " +
                $"WHERE `Borrowed_Book_ID` = {transacID}";

            return _dbController.update_DBMethod(query);
        }

        /// <summary>
        /// get the quantity
        /// </summary>
        /// <param name="transacID">reference of id</param>
        /// <returns>quantity value</returns>
        public int GetQuantity(string transacID)
        {
            string query = $"SELECT `Borrowed_Book_Number_of_Copies` FROM `tbl_borrowed_book` WHERE " +
                $"`Borrowed_Book_ID` = \"{transacID}\"";

            List<List<string>> results = _dbController.select_DBMethod_return_2DList_Table_Records(query);

            return int.Parse(results[0][0]);
        }

        /// <summary>
        /// get the id of book
        /// </summary>
        /// <param name="transacID">reference of transac id</param>
        /// <returns>return the id of book</returns>
        public string GetBookID(string transacID)
        {
            string query = $"SELECT `Book_ID` FROM `tbl_borrowed_book` WHERE " +
                $"`Borrowed_Book_ID` = \"{transacID}\"";
            List<List<string>> results = _dbController.select_DBMethod_return_2DList_Table_Records(query);

            return results[0][0];
        }

        public string GetMemberID(string transacID)
        {
            string query = $"SELECT `Borrower_ID` FROM `tbl_borrowed_book` WHERE " +
                $"`Borrowed_Book_ID` = \"{transacID}\"";
            List<List<string>> results = _dbController.select_DBMethod_return_2DList_Table_Records(query);

            return results[0][0];
        }

        public bool GenerateReturnDate(string transacID)
        {
            string query = "UPDATE `tbl_borrowed_book` SET " +
                $"`Borrowed_Book_Date_Returned`='{DateTime.Now.ToString("MM-dd-yyyy")}' " +
                $"WHERE `Borrowed_Book_ID` = \"{transacID}\"";
            return _dbController.update_DBMethod(query);
        }

        /// <summary>
        /// change the due status
        /// </summary>
        /// <param name="id">reference of id</param>
        /// <param name="due">what to change</param>
        public void ChangeDueStatus(string id, string due)
        {
            string query = "UPDATE `tbl_borrowed_book` SET " +
                $"`Borrowed_Book_Due_Status`='{due}' WHERE `Borrowed_Book_ID` = \"{id}\"";
            _dbController.update_DBMethod(query);
        }

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
            string bookID, string status, CheckBox returned)
        {
            table.Rows.Clear();

            search = search.Trim();

            string query = FillQuery(search, fName, lName, bookID, status, returned);

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


        /// <summary>
        /// fill the dropdown
        /// </summary>
        /// <param name="fName">reference of first name dropdown</param>
        /// <param name="lName">reference of last name dropdown</param>
        /// <param name="bookID">reference of bookid name dropdown</param>
        public void FillDropDown(ComboBox fName, ComboBox lName, ComboBox bookID)
        {
            string query = "SELECT tbl_borrower.Borrower_First_Name, tbl_borrower.Borrower_Last_Name," +
                "tbl_book.Book_ID FROM `tbl_borrowed_book` INNER JOIN `tbl_book` ON " +
                "tbl_borrowed_book.Book_ID = tbl_book.Book_ID INNER JOIN `tbl_borrower` ON " +
                "tbl_borrowed_book.Borrower_ID = tbl_borrower.Borrower_ID";

            List<List<string>> results = _dbController.select_DBMethod_return_2DList_Table_Records(query);

            fName.Items.Clear(); lName.Items.Clear(); bookID.Items.Clear();
            fName.Items.Add("All"); lName.Items.Add("All"); bookID.Items.Add("All");
            // fill the comboboxes
            foreach (List<string> result in results)
            {
                fName.Items.Add(result[0]);
                lName.Items.Add(result[1]);
                bookID.Items.Add(result[2]);
            }
            fName.SelectedIndex = 0; lName.SelectedIndex = 0; bookID.SelectedIndex = 0;
        }

        /// <summary>
        /// fill the details
        /// </summary>
        public void FillDetails(string id, Label transacID, Label borrowerID, Label borrowerName, 
            Label bookID, Label bookTitle, Label dateBorrowed, Label dueDate, Label dueStatus, 
            Label quantity, Label dateReturned)
        {
            string query = "SELECT tbl_borrowed_book.Borrowed_Book_ID, tbl_borrower.Borrower_ID, " +
                "tbl_borrower.Borrower_First_Name, tbl_borrower.Borrower_Middle_Name, " +
                "tbl_borrower.Borrower_Last_Name, tbl_book.Book_ID, tbl_book.Book_Title, " +
                "tbl_borrowed_book.Borrowed_Book_Date_Borrowed, tbl_borrowed_book.Borrowed_Book_Due_Date, " +
                "tbl_borrowed_book.Borrowed_Book_Due_Status, tbl_borrowed_book.Borrowed_Book_Number_of_Copies," +
                "tbl_borrowed_book.Borrowed_Book_Date_Returned " +
                "FROM `tbl_borrowed_book` INNER JOIN `tbl_book` ON " +
                "tbl_borrowed_book.Book_ID = tbl_book.Book_ID INNER JOIN `tbl_borrower` ON " +
                $"tbl_borrowed_book.Borrower_ID = tbl_borrower.Borrower_ID WHERE `Borrowed_Book_ID` = \"{id}\"";

            List<List<string>> results = _dbController.select_DBMethod_return_2DList_Table_Records(query);

            List<string> result = results[0];

            transacID.Text = result[0];
            borrowerID.Text = result[1];
            borrowerName.Text = $"{result[4]}, {result[2]} {result[3]}";
            bookID.Text = result[5];
            bookTitle.Text = result[6];
            dateBorrowed.Text = result[7];
            dueDate.Text = result[8];
            dueStatus.Text = result[9];
            quantity.Text = result[10];
            dateReturned.Text = result[11];
        }

        /// <summary>
        /// fill the needed query
        /// </summary>
        /// <param name="search">what to search text</param>
        /// <param name="fName">fname dropdown text</param>
        /// <param name="lName">lname dropdown text</param>
        /// <param name="bookID">bookid drodown text</param>
        /// <param name="returned">checkbox of to show returned</param>
        /// <returns>return the string query</returns>
        private string FillQuery(string search, string fName, string lName,
            string bookID, string status, CheckBox returned)
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
            string statusQuery = "";
            string returnQuery = "";

            if(search != "")
            {
                whereQuery = "WHERE ";
                searchQuery = $"(tbl_borrower.Borrower_First_Name REGEXP \".*{search}.*\" OR " +
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
            if (status != "All")
            {
                if (whereQuery != "")
                {
                    statusQuery = $"AND tbl_borrowed_book.Borrowed_Book_Due_Status = \"{status}\" ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    statusQuery = $"tbl_borrowed_book.Borrowed_Book_Due_Status = \"{status}\" ";
                }
            }
            if (!returned.Checked)
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
            return query + whereQuery + searchQuery + fNameQuery + lNameQuery + bookIDQuery + statusQuery + returnQuery;
        }
    }
}
