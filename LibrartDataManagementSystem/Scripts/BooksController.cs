using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrartDataManagementSystem.Scripts
{
    class BooksController
    {
        LDMS_DataBaseController dbController = new LDMS_DataBaseController();

        /// <summary>
        /// Check if the input is complete
        /// </summary>
        /// <param name="inputs">the list of input to check</param>
        /// <returns>return true if it is complete</returns>
        public bool isInputComplete(TextBox[] inputs)
        {
            foreach (TextBox input in inputs)
            {
                if(input.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Inputs are incomplete");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// add books to the database
        /// </summary>
        /// <param name="title">title of book</param>
        /// <param name="author">author of book</param>
        /// <param name="genre">genre of book</param>
        /// <param name="yearPublished">what year does the book has been published</param>
        /// <param name="publisher">publisher of book</param>
        /// <param name="numberOfQuantity">number of quantity of book</param>
        public bool AddBooks(string title, string author, string genre, string yearPublished,
            string publisher, string numberOfQuantity)
        {
            string query = "" +
                    "INSERT INTO `tbl_book`(`Book_Title`, `Book_Author`, `Book_Genre`, " +
                    "`Book_Year_Published`, `Book_Publisher`, `Book_Number_Of_Quantity` " +
                    $") VALUES ('{title}','{author}','{genre}'" +
                    $",'{yearPublished}','{publisher}','{numberOfQuantity}')";
            bool success = dbController.insert_DBMethod(query);
            return success;
        }

        /// <summary>
        /// clear the inputs text
        /// </summary>
        /// <param name="inputs">the list of inputs to clear</param>
        public void ClearInputs(TextBox[] inputs)
        {
            foreach (TextBox input in inputs)
            {
                input.Text = "";
            }
        }

        /// <summary>
        /// fill the table of books
        /// </summary>
        /// <param name="table">table to fill</param>
        /// <param name="search">search for what title, author, genre</param>
        /// <param name="author">author dropdown text</param>
        /// <param name="genre">genre dropdown text</param>
        /// <param name="yearPublished">yearpublished dropdown text</param>
        public void FillTable(DataGridView table, string search, string author, string genre,
            string yearPublished)
        {
            table.Rows.Clear(); // clear datagridview table

            search = search.Trim(); // remove unecessary spaces

            // get the correct query
            string query = QuerySelectFill(search, author, genre, yearPublished);

            // get the database list
            List<List<string>> booksDetails = dbController.select_DBMethod_return_2DList_Table_Records(query);

            // fill the table
            foreach (List<string> bookDetails in booksDetails)
            {
                int outerIndex = table.Rows.Add();
                table.Rows[outerIndex].Cells["Column_Book_ID"].Value = bookDetails[0];
                table.Rows[outerIndex].Cells["Column_Book_Title"].Value = bookDetails[1];
                table.Rows[outerIndex].Cells["Column_Book_Author"].Value = bookDetails[2];
                table.Rows[outerIndex].Cells["Column_Book_Genre"].Value = bookDetails[3];
                table.Rows[outerIndex].Cells["Column_Book_Year_published"].Value = bookDetails[4];
                table.Rows[outerIndex].Cells["Column_Book_Publisher"].Value = bookDetails[5];
                table.Rows[outerIndex].Cells["Column_Book_Number_Of_Quantity"].Value = bookDetails[6];
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
        public string QuerySelectFill(string search, string author, string genre,
            string yearPublished)
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
                searchQuery = $"`Book_Title` REGEXP \".*{search}.*\" OR `Book_Author` REGEXP \".*{search}.*\" " +
                    $"OR `Book_Genre` REGEXP \".*{search}.*\" ";
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
                    yearPublishedQuery = $"AND `Book_Genre` = \"{yearPublished}\" ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    yearPublishedQuery = $"`Book_Genre` = \"{yearPublished}\" ";
                }
            }
            query += whereQuery + searchQuery + authorQuery + genreQuery + yearPublishedQuery;
            return query;
        }
    }
}
