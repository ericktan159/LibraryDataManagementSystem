using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace LibrartDataManagementSystem.Scripts
{
    // Kitts tignan mo ginawa ko dito. Mas umiksi at gumanda di ba? maliban lang comments haha. pero resusable at pang general na yung mga methods na ginawa ko sa LDMS_DataBaseController
    // at Common_Controller

    class BooksController
    {
        LDMS_DataBaseController dbController = new LDMS_DataBaseController();
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        Info_TBL_BOOK tbl_Infos = new Info_TBL_BOOK();
        LogController _logController = new LogController();

        Common_Controller myCommon_Controller = new Common_Controller();


        /// <summary>
        /// Check if the input is complete
        /// </summary>
        /// <param name="inputs">the list of input to check</param>
        /// <returns>return true if it is complete</returns>
        public bool isInputComplete(TextBox[] inputs)
        {
            /*
            foreach (TextBox input in inputs)
            {
                if(input.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Inputs are incomplete");
                    return false;
                }
            }
            return true;
            //*/

            return myCommon_Controller.isTextBoxeSComplete(inputs);

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
            /*
            string query = "" +
                    "INSERT INTO `tbl_book`(`Book_Title`, `Book_Author`, `Book_Genre`, " +
                    "`Book_Year_Published`, `Book_Publisher`, `Book_Number_Of_Quantity` " +
                    $") VALUES (\"{ti.ToTitleCase(title)}\",\"{ti.ToTitleCase(author)}\"," +
                    $"\"{ti.ToTitleCase(genre)}\"" +
                    $",\"{ti.ToTitleCase(yearPublished)}\",\"{ti.ToTitleCase(publisher)}\"," +
                    $"\"{numberOfQuantity}\")";
            bool success = dbController.insert_DBMethod(query);
            return success;
            //*/

            tbl_Infos.Book_Tittle = ti.ToTitleCase(title);
            tbl_Infos.Book_Author = ti.ToTitleCase(author);
            tbl_Infos.Book_Genre = ti.ToTitleCase(genre);
            tbl_Infos.Book_Year_Published = ti.ToTitleCase(yearPublished);
            tbl_Infos.Book_Publisher = ti.ToTitleCase(publisher);
            tbl_Infos.Book_Number_Of_Quantity = int.Parse(numberOfQuantity);

            bool success = dbController.insert_DBMethod_BOOKS(tbl_Infos);

            return success;
        }

        /// <summary>
        /// clear the inputs text
        /// </summary>
        /// <param name="inputs">the list of inputs to clear</param>
        public void ClearInputs(TextBox[] inputs)
        {
            /*
            foreach (TextBox input in inputs)
            {
                input.Text = "";
            }
            //*/

            myCommon_Controller.ClearTextBoxeS(inputs);
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
        /// fill the table with no other query
        /// </summary>
        /// <param name="table"></param>
        public void FillTable(DataGridView table)
        {
            // get the correct query
            string query = "SELECT * FROM `tbl_book`";

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
        /// fill the dropdownobject by the value of what they seachfor
        /// </summary>
        /// <param name="dropDownObject">reference of dropdownobject</param>
        /// <param name="searchFor">what to search for</param>
        public void FillDropdown(ComboBox dropDownObject, string searchFor)
        {
            /*
            dropDownObject.Items.Clear();
            dropDownObject.Items.Add("All");
            string query = $"SELECT {searchFor} FROM `tbl_book` ORDER BY {searchFor} ASC";
            List<List<string>> resultListList = dbController.select_DBMethod_return_2DList_Table_Records(query);
            List<string> resultList = new List<string>();
            foreach (List<string> result in resultListList)
            {
                resultList.Add(result[0]);
            }
            resultList = resultList.Distinct().ToList();
            foreach (string result in resultList)
            {
                dropDownObject.Items.Add(result);
            }
            //*/

            myCommon_Controller.fill_ComboBox_Filter(dropDownObject, Info_TBL_BOOK.Const_Names.table_Name, searchFor, "ASC");

        }

        /// <summary>
        /// Check if the book exist
        /// </summary>
        /// <param name="bookTitle">title of book</param>
        /// <returns>return list of the existing books</returns>
        public List<string> CheckIfBookExist(string bookTitle, string bookAuthor, string bookGenre,
            string bookPublisher, string yearPublished)
        {
            //*
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

            //int nakalimutan_mo_ata_Book_Number_Of_Quantity = 1;

            //tbl_Infos.Book_Tittle = bookTitle;
            //tbl_Infos.Book_Author = bookAuthor;
            //tbl_Infos.Book_Genre = bookGenre;
            //tbl_Infos.Book_Year_Published = yearPublished;
            //tbl_Infos.Book_Publisher = bookPublisher;
            //tbl_Infos.Book_Number_Of_Quantity = 1;



            //return dbController.select_DBMethod_Table_Details_Return_Prime_ID_Column(tbl_Infos);

        }

        /// <summary>
        /// get the title of book by using id
        /// </summary>
        /// <param name="id">get the id of book</param>
        /// <returns></returns>
        public string GetBookTitle(string id)
        {
            /*
            string query = $"SELECT * FROM `tbl_book` WHERE `Book_ID` = \"{id}\"";
            List<List<string>> book = dbController.select_DBMethod_return_2DList_Table_Records(query);
            return book[0][1];
            //*/

            return dbController.select_DBMethod_return_a_Cell(Info_TBL_BOOK.Const_Names.table_Name, int.Parse(id), Info_TBL_BOOK.Const_Names.col_1_Book_Tittle_CONST);
        }

        /// <summary>
        /// add a quantity to the existing books
        /// </summary>
        /// <param name="bookID">reference to the id of database</param>
        /// <param name="quantity">quantity to add</param>
        /// <returns>return true if success</returns>
        public bool AddBookQuantity(string bookID, int quantity)
        {
            /*
            int currentQuantity =
                int.Parse(dbController.select_DBMethod_return_2DList_Table_Records("SELECT " +
                $"`Book_Number_Of_Quantity` FROM `tbl_book` WHERE `Book_ID` = " +
                $"\"{bookID}\"")[0][0]);
            string query = $"UPDATE `tbl_book` SET `Book_Number_Of_Quantity`='{currentQuantity + quantity}' " +
                $"WHERE `Book_ID` = \"{bookID}\"";
            bool success = dbController.insert_DBMethod(query);
            return success;
            //*/

            return dbController.update_DBMethod_Update_A_Cell(Info_TBL_BOOK.Const_Names.table_Name, 
                                                                int.Parse(bookID), 
                                                                Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST, 
                                                                quantity);

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
                if(int.Parse(cell.Value.ToString()) > 5)
                {
                    cell.Style.BackColor = Color.Green;
                }
                else if(int.Parse(cell.Value.ToString()) > 0)
                {
                    cell.Style.BackColor = Color.Orange;
                }
                else
                {
                    cell.Style.BackColor = Color.Red;
                }
            }
        }

        public List<string> GetBookDetails(string id)
        {
            /*
            string query = $"SELECT * FROM `tbl_book` WHERE `Book_ID` = {id}";
            List<List<string>> results = dbController.select_DBMethod_return_2DList_Table_Records(query);
            return results[0];
            //*/

            return dbController.select_DBMethod_return_A_Row_Of_Records(Info_TBL_BOOK.Const_Names.table_Name, int.Parse(id));

        }

        /// <summary>
        /// fill the labels with the value of books by ID
        /// </summary>
        /// <param name="title">textbox of title</param>
        /// <param name="author">textbox of author</param>
        /// <param name="genre">textbox of genre</param>
        /// <param name="yearPublished">year published input</param>
        /// <param name="publisher">textbox of publisher</param>
        /// <param name="quantity">textbox quantity</param>
        /// <param name="id">the id to search book</param>
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
            /*
            string query = $"UPDATE `tbl_book` SET `Book_Title`=\"{ti.ToTitleCase(title.Text)}\"," +
                $"`Book_Author`=\"{ti.ToTitleCase(author.Text)}\"" +
                $",`Book_Genre`=\"{ti.ToTitleCase(genre.Text)}\"," +
                $"`Book_Year_Published`=\"{ti.ToTitleCase(yearPublished.Text)}\"," +
                $"`Book_Publisher`=\"{ti.ToTitleCase(publisher.Text)}\"" +
                $",`Book_Number_Of_Quantity`=\"{quantity.Text}\" WHERE `Book_ID` = '{id}'";
            bool success = dbController.insert_DBMethod(query);
            return success;
            //*/

            int Book_ID = int.Parse(id);
            tbl_Infos.Book_Tittle = ti.ToTitleCase(title.Text);
            tbl_Infos.Book_Author = ti.ToTitleCase(author.Text);
            tbl_Infos.Book_Genre = ti.ToTitleCase(genre.Text);
            tbl_Infos.Book_Year_Published = ti.ToTitleCase(yearPublished.Text);
            tbl_Infos.Book_Publisher = ti.ToTitleCase(publisher.Text);
            tbl_Infos.Book_Number_Of_Quantity = int.Parse(quantity.Text);

            return dbController.update_DBMethod_BOOKS(Book_ID, tbl_Infos);
        }

        /// <summary>
        /// Delete book depending on id
        /// </summary>
        /// <param name="id">reference of id</param>
        /// <returns>return true if delete were successful</returns>
        public bool DeleteBook(string id)
        {
            /*
            string query = $"DELETE FROM `tbl_book` WHERE `Book_ID` = '{id}'";
            bool success = dbController.insert_DBMethod(query);
            return success;
            //*/

            int Book_ID = int.Parse(id);
            return dbController.delete_DBMethod_return_Boolean(Info_TBL_BOOK.Const_Names.table_Name, Book_ID); 
        }

        /// <summary>
        /// get the latest book id
        /// </summary>
        /// <returns>return the id</returns>
        public string GetLastBookID()
        {
            string query = "SELECT * FROM `tbl_book` ORDER BY `Book_ID` DESC LIMIT 1";
            List<List<string>> res = dbController.select_DBMethod_return_2DList_Table_Records(query);
            return res[0][0];
        }

        public string GetQuantity(string id)
        {
            string query = $"SELECT * FROM `tbl_book` WHERE `Book_ID` = {id}";
            List<List<string>> res = dbController.select_DBMethod_return_2DList_Table_Records(query);
            return res[0][6];
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
                searchQuery = $"(`Book_Title` REGEXP \".*{search}.*\" OR `Book_Author` REGEXP \".*{search}.*\" " +
                    $"OR `Book_Genre` REGEXP \".*{search}.*\" OR `Book_ID` = {search}) ";
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
    }
}
