using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace LibrartDataManagementSystem
{
    class General_Controller // wag nyo muna kalikutin. to be continued to. inaayos ko pa
    {





        LDMS_DataBaseController dbController = new LDMS_DataBaseController();
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        public bool isTextBoxeSComplete(TextBox[] inputs)
        {
            foreach (TextBox input in inputs)
            {
                if (input.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Inputs are incomplete");
                    return false;
                }
            }
            return true;
        }

        

        public void ClearTextBoxeS(TextBox[] inputs)
        {
            foreach (TextBox input in inputs)
            {
                input.Text = "";
            }
        }



        /*
        public List<List<string>> select_Search_results_From_DB(string table_name, string searchInput, List<string> searhFilterList)//string search, string author, string genre, string yearPublished)
        {
            tableDataGridView.Rows.Clear(); // clear datagridview table

            searchInput = searchInput.Trim(); // remove unecessary spaces

            // get the correct query
            string query = QuerySelectFill(search, author, genre, yearPublished);

            // get the database list
            List<List<string>> booksDetails = dbController.select_DBMethod_return_2DList_Table_Records(query);

            // fill the table
            foreach (List<string> bookDetails in booksDetails)
            {
                int outerIndex = tableDataGridView.Rows.Add();
                tableDataGridView.Rows[outerIndex].Cells["Column_Book_ID"].Value = bookDetails[0];
                tableDataGridView.Rows[outerIndex].Cells["Column_Book_Title"].Value = bookDetails[1];
                tableDataGridView.Rows[outerIndex].Cells["Column_Book_Author"].Value = bookDetails[2];
                tableDataGridView.Rows[outerIndex].Cells["Column_Book_Genre"].Value = bookDetails[3];
                tableDataGridView.Rows[outerIndex].Cells["Column_Book_Year_published"].Value = bookDetails[4];
                tableDataGridView.Rows[outerIndex].Cells["Column_Book_Publisher"].Value = bookDetails[5];
                tableDataGridView.Rows[outerIndex].Cells["Column_Book_Number_Of_Quantity"].Value = bookDetails[6];
            }
        }
        //*/


        public void fill_ComboBox_Filter(ComboBox dropDownObject, string table_Name, string searchFor, string orderBy = "ASC")
        {
            dropDownObject.Items.Clear();
            dropDownObject.Items.Add("All");

            List<string> resultList = dbController.select_DBMethod_return_A_Column_Of_Distinct_Records_OrderBy(table_Name, searchFor, searchFor, orderBy);
            foreach (string result in resultList)
            {
                dropDownObject.Items.Add(result);
            }
        }

        /////////////////

        public List<string> GetBookDetails(string id)
        {
            string query = $"SELECT * FROM `tbl_book` WHERE `Book_ID` = {id}";
            List<List<string>> results = dbController.select_DBMethod_return_2DList_Table_Records(query);
            return results[0];
        }


        public void FillDetails(Label[] labels, string id)
        {
            List<string> results = GetBookDetails(id);
            labels[0].Text = results[1];
            labels[1].Text = results[2];
            labels[2].Text = results[3];
            labels[3].Text = results[4];
            labels[4].Text = results[5];
            labels[5].Text = results[6];
        }














        public void FillInputs(TextBox title, TextBox author, TextBox genre, DateTimePicker yearPublished,
            TextBox publisher, TextBox quantity, string id)
        {
            List<string> results = GetBookDetails(id);
            title.Text = results[1];
            author.Text = results[2];
            genre.Text = results[3];
            yearPublished.Value = DateTime.ParseExact(results[4], "yyyy", CultureInfo.InvariantCulture);
            publisher.Text = results[5];
            quantity.Text = results[6];
        }



        public List<string> CheckIfBookExist(string bookTitle, string bookAuthor, string bookGenre,
            string bookPublisher, string yearPublished)
        {
            string query = $"SELECT * FROM `tbl_book` WHERE `Book_Title` = \"{bookTitle}\" AND " +
                $"`Book_Author` = \"{bookAuthor}\" AND `Book_Genre` = \"{bookGenre}\" AND " +
                $"`Book_Publisher` = \"{bookPublisher}\" AND `Book_Year_Published` = \"{yearPublished}\"";
            List<List<string>> books = dbController.select_DBMethod_return_2DList_Table_Records(query);
            List<string> result = new List<string>();
            foreach (List<string> book in books)
            {
                result.Add(book[0]);
            }
            return result;
        }

        public void fill_DataGridView_Books(DataGridView table, List<List<string>> books_2d_List_table)
        {
            foreach (List<string> book_row in books_2d_List_table)
            {
                int outerIndex = table.Rows.Add();
                table.Rows[outerIndex].Cells["Column_Book_ID"].Value = book_row[0];
                table.Rows[outerIndex].Cells["Column_Book_Title"].Value = book_row[1];
                table.Rows[outerIndex].Cells["Column_Book_Author"].Value = book_row[2];
                table.Rows[outerIndex].Cells["Column_Book_Genre"].Value = book_row[3];
                table.Rows[outerIndex].Cells["Column_Book_Year_published"].Value = book_row[4];
                table.Rows[outerIndex].Cells["Column_Book_Publisher"].Value = book_row[5];
                table.Rows[outerIndex].Cells["Column_Book_Number_Of_Quantity"].Value = book_row[6];
            }
        }




        public void fill_DataGridView_Members(DataGridView table, List<List<string>> members_2d_List_table)
        {
            foreach (List<string> member_row in members_2d_List_table)
            {
                int outerIndex = table.Rows.Add();
                table.Rows[outerIndex].Cells["Column_Borrower_ID"].Value = member_row[0];
                table.Rows[outerIndex].Cells["Column_Borrower_First_Name"].Value = member_row[1];
                table.Rows[outerIndex].Cells["Column_Borrower_Middle_Name"].Value = member_row[2];
                table.Rows[outerIndex].Cells["Column_Borrower_Last_Name"].Value = member_row[3];
                table.Rows[outerIndex].Cells["Column_Borrower_Gender"].Value = member_row[4];
                table.Rows[outerIndex].Cells["Column_Borrower_Address"].Value = member_row[5];
                table.Rows[outerIndex].Cells["Column_Borrower_Conatact_Number"].Value = member_row[6];
                table.Rows[outerIndex].Cells["Column_Borrower_BirthDate"].Value = member_row[7];
                table.Rows[outerIndex].Cells["Column_Borrower_Type_Valid_ID"].Value = member_row[8];
                
            }

        }

        
        







        /// <summary>
        /// fill the query for searching
        /// </summary>
        /// <param name="search">search text</param>
        /// <param name="author">author text</param>
        /// <param name="genre">genre text</param>
        /// <param name="yearPublished">year published text</param>
        /// <returns>refine query</returns>
        public string querry_Select_Where_Books(string search, string author, string genre, string yearPublished)
        {
            // initialize all needed query
            string query = "SELECT * FROM `tbl_book` ";
            string whereQuery = "";
            string searchQuery = "";
            string authorQuery = "";
            string genreQuery = "";
            string yearPublishedQuery = "";

            // fill the query
            if (search != "")
            {
                whereQuery = "WHERE ";
                searchQuery = $"(`Book_Title` REGEXP \".*{search}.*\" OR `Book_Author` REGEXP \".*{search}.*\" " +
                    $"OR `Book_Genre` REGEXP \".*{search}.*\") ";
            }
            if (author != "All")
            {
                if (whereQuery != "")
                {
                    authorQuery = $"AND `Book_Author` = \"{author}\" ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    authorQuery = $"`Book_Author` = \"{author}\" ";
                }
            }
            if (genre != "All")
            {
                if (whereQuery != "")
                {
                    genreQuery = $"AND `Book_Genre` = \"{genre}\" ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    genreQuery = $"`Book_Genre` = \"{genre}\" ";
                }
            }
            if (yearPublished != "All")
            {
                if (whereQuery != "")
                {
                    yearPublishedQuery = $"AND `Book_Year_Published` = \"{yearPublished}\" ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    yearPublishedQuery = $"`Book_Year_Published` = \"{yearPublished}\" ";
                }
            }
            query += whereQuery + searchQuery + authorQuery + genreQuery + yearPublishedQuery;
            return query;
        }

        

        /// <summary>
        /// get the title of book by using id
        /// </summary>
        /// <param name="id">get the id of book</param>
        /// <returns></returns>
        public string GetBookTitle(string id)
        {
            string query = $"SELECT * FROM `tbl_book` WHERE `Book_ID` = \"{id}\"";
            List<List<string>> book = dbController.select_DBMethod_return_2DList_Table_Records(query);
            return book[0][1];
        }

        /// <summary>
        /// add a quantity to the existing books
        /// </summary>
        /// <param name="bookID">reference to the id of database</param>
        /// <param name="quantity">quantity to add</param>
        /// <returns>return true if success</returns>
        public bool AddBookQuantity(string bookID, int quantity)
        {
            int currentQuantity =
                int.Parse(dbController.select_DBMethod_return_2DList_Table_Records("SELECT " +
                $"`Book_Number_Of_Quantity` FROM `tbl_book` WHERE `Book_ID` = " +
                $"\"{bookID}\"")[0][0]);
            string query = $"UPDATE `tbl_book` SET `Book_Number_Of_Quantity`='{currentQuantity + quantity}' " +
                $"WHERE `Book_ID` = \"{bookID}\"";
            bool success = dbController.insert_DBMethod(query);
            return success;
        }

        /// <summary>
        /// fill the quantity of books color cell to indicate whether it's there are many quantity
        /// low number of quantity or no quantity at all
        /// </summary>
        /// <param name="table"></param>
        public void FillQuantityColor(DataGridView table)
        {
            foreach (DataGridViewRow row in table.Rows)
            {
                DataGridViewCell cell = row.Cells["Column_Book_Number_Of_Quantity"];
                if (int.Parse(cell.Value.ToString()) > 5)
                {
                    cell.Style.BackColor = Color.Green;
                }
                else if (int.Parse(cell.Value.ToString()) > 0)
                {
                    cell.Style.BackColor = Color.Orange;
                }
                else
                {
                    cell.Style.BackColor = Color.Red;
                }
            }
        }

      
        

        /// <summary>
        /// fill the inputs with the value of books by ID
        /// </summary>
        /// <param name="title">textbox of title</param>
        /// <param name="author">textbox of author</param>
        /// <param name="genre">textbox of genre</param>
        /// <param name="yearPublished">year published input</param>
        /// <param name="publisher">textbox of publisher</param>
        /// <param name="quantity">textbox quantity</param>
        /// <param name="id">the id to search book</param>
        
        /// <summary>
        /// update the books
        /// </summary>
        /// <param name="title">textbox of title</param>
        /// <param name="author">textbox of author</param>
        /// <param name="genre">textbox of genre</param>
        /// <param name="yearPublished">year published input</param>
        /// <param name="publisher">textbox of publisher</param>
        /// <param name="quantity">textbox quantity</param>
        /// <param name="id">the id to search book</param>
        /// <returns>true if the update were successful</returns>
        public bool UpdateBooks(TextBox title, TextBox author, TextBox genre, DateTimePicker yearPublished,
            TextBox publisher, TextBox quantity, string id)
        {
            string query = $"UPDATE `tbl_book` SET `Book_Title`=\"{ti.ToTitleCase(title.Text)}\"," +
                $"`Book_Author`=\"{ti.ToTitleCase(author.Text)}\"" +
                $",`Book_Genre`=\"{ti.ToTitleCase(genre.Text)}\"," +
                $"`Book_Year_Published`=\"{ti.ToTitleCase(yearPublished.Text)}\"," +
                $"`Book_Publisher`=\"{ti.ToTitleCase(publisher.Text)}\"" +
                $",`Book_Number_Of_Quantity`=\"{quantity.Text}\" WHERE `Book_ID` = '{id}'";
            bool success = dbController.insert_DBMethod(query);
            return success;
        }

        /// <summary>
        /// Delete book depending on id
        /// </summary>
        /// <param name="id">reference of id</param>
        /// <returns>return true if delete were successful</returns>
        public bool DeleteBook(string id)
        {
            string query = $"DELETE FROM `tbl_book` WHERE `Book_ID` = '{id}'";
            bool success = dbController.insert_DBMethod(query);
            return success;
        }
    }
}
