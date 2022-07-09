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
                    "INSERT INTO `tbl_book`(`Book_Tittle`, `Book_Author`, `Book_Genre`, " +
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

        public void FillTable(DataGridView table, string search, string author, string genre,
            string yearPublished)
        {
            table.Rows.Clear(); // clear datagridview table

            // initialize all needed query
            string query = "SELECT * FROM `tbl_book` ";
            string whereQuery = "";
            string searchQuery = "";
            string authorQuery = "";
            string genreQuery = "";
            string yearPublishedQuery = "";

            if(search.Trim() != "")
            {
                whereQuery = "WHERE ";
            }
        }
    }
}
