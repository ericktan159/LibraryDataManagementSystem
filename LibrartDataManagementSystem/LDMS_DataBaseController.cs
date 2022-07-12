using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



//// Pull or clone muna kayo lagi sa master branch bago kayo gumawa sa mga branches nyo


/// <summary>
/// 
/// </summary>

namespace LibrartDataManagementSystem
{
    class LDMS_Constants
    {
        
        public const string tbl_book_CONST = "tbl_book";
        public const string tbl_borrower_CONST = "tbl_borrower";
        public const string tbl_borrowed_book_CONST = "tbl_borrowed_book";


        



        public const string Book_Tittle_CONST = "Book_Tittle";
        public const string Book_Author_CONST = "Book_Author";
        public const string Book_Genre_CONST = "Book_Genre";
        public const string Book_Year_Published_CONST = "Book_Year_Published";
        public const string Book_Publisher_CONST = "Book_Publisher";
        public const string Book_Number_Of_Quantity_CONST = "Book_Number_Of_Quantity";


        public const string Borrower_First_Name_CONST = "Borrower_First_Name";
        public const string Borrower_Middle_Name_CONST = "Borrower_Middle_Name";
        public const string Borrower_Last_Name_CONST = "Borrower_Last_Name";
        public const string Borrower_Gender_CONST = "Borrower_Gender";
        public const string Borrower_Address_CONST = "Borrower_Address";
        public const string Borrower_Contact_Number_CONST = "Borrower_Address";
        public const string Borrower_BirthDate_CONST = "Borrower_BirthDate";
        public const string Borrower_Type_of_Valid_ID_CONST = "Borrower_Type_of_Valid_ID";

        public const string Book_ID_CONST = "Book_ID";
        public const string Borrower_ID_CONST = "Borrower_ID";
        public const string Borrowed_Book_Date_Borrowed_CONST = "Borrowed_Book_Date_Borrowed";
        public const string Borrowed_Book_Due_Date_CONST = "Borrowed_Book_Due_Date";
        public const string Borrowed_Book_Due_Status_CONST = "Borrowed_Book_Due_Status";
        public const string Borrowed_Book_Date_Returned_CONST = "Borrowed_Book_Date_Returned";
        public const string Borrowed_Book_Number_of_Copies_CONST = "Borrowed_Book_Number_of_Copies";
    }

    class Info_tbl_borrower
    {
        public string Borrower_First_Name;
        public string Borrower_Middle_Name;
        public string Borrower_Last_Name;
        public string Borrower_Gender;
        public string Borrower_Address;
        public string Borrower_Contact_Number;
        public /*Datetime*/ string Borrower_BirthDate;
        public string Borrower_Type_of_Valid_ID;
    }

    class Info_tbl_book
    {
        public string Book_Tittle;
        public string Book_Author;
        public string Book_Genre; /*DateTime*/
        public string Book_Year_Published;
        public string Book_Publisher;
        public int Book_Number_Of_Quantity;
    }

    class Info_tbl_borrowed_book
    {
        public int Book_ID;
        public int Borrower_ID;
        public string Borrowed_Book_Date_Borrowed;
        public string Borrowed_Book_Due_Date;
        public string Borrowed_Book_Due_Status;
        public string Borrowed_Book_Date_Returned;
        public int Borrowed_Book_Number_of_Copies;
    }



    class LDMS_DataBaseController
    {
        string ConnectString = "datasource = localhost; username = root; password=; database = library_data_management_system;";//databasesample;";
        //string ConnectString = "datasource = sql6.freemysqlhosting.net; username = sql6505213; password=3xepDlsiuM; database = sql6505213; port = 3306";//databasesample;";
        MySqlConnection connectDB;
        MySqlCommand cmd;
        MySqlDataAdapter da;

        public DataTable dt;
        int result;


        
        
        public bool IsDataBaseOpen()
        {
            bool success;
            connectDB = new MySqlConnection(ConnectString);
            try
            {
                connectDB.Open();
                success = true;
            }
            catch
            {
                success = false;
            }
            return success;
        }

        public bool connectDB_And_ExecuteNonQuery(string execute_SQL_StateMent)
        {
            bool success;

            connectDB = new MySqlConnection(ConnectString);

            try
            {
                connectDB.Open();
                cmd = new MySqlCommand(execute_SQL_StateMent, connectDB);
                //cmd.Connection = connectDB;
                //cmd.CommandText = sqlStrCommand;
                result = cmd.ExecuteNonQuery();

                success = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed! " + e.Message);
                success = false;
            }
            finally
            {
                connectDB.Close();
            }
            return success;

            //sqlCommandDB(sqlStrCommand);

        }


        /// <summary>
        /// insert method base on the statement
        /// </summary>
        /// <param name="insert_SQL_StateMent">sql statement to use</param>
        public bool insert_DBMethod(string insert_SQL_StateMent)
        {
            return connectDB_And_ExecuteNonQuery(insert_SQL_StateMent);
        }
        //*/    

        public bool update_DBMethod(string update_SQL_StateMent)
        {
            return connectDB_And_ExecuteNonQuery(update_SQL_StateMent);
        }

        public bool delete_DBMethod(string delete_SQL_StateMent)
        {
            return connectDB_And_ExecuteNonQuery(delete_SQL_StateMent);
        }



        public bool insert_To_tbl_borrower(Info_tbl_borrower tbl_Borrower_Info)
            //(string Borrower_First_Name, string Borrower_Middle_Name, string Borrower_Last_Name, string Borrower_Gender, string Borrower_Address, string Borrower_Contact_Number, /*Datetime*/ string Borrower_BirthDate, string Borrower_Type_of_Valid_ID)
        {
            


            /*
            string sqlStrCommand = "Insert into main (Name, age, address, Gender, isTraveled, isCloseContact, symptomsList, celNumber, eMailAddress) values " +
                    "('" + myCTInfo.name + "', " + myCTInfo.age + ", '" + myCTInfo.address + "', '" + myCTInfo.gender + "', '" + myCTInfo.isTraveledStr + "', '" + myCTInfo.isClosedContact +
                    "', '" + myCTInfo.symptomList + "', '" + myCTInfo.cellNumber + "', '" + myCTInfo.eMail + "')";

            */

            ////////

            string singleQuoteChar = "'";

            string table_Name = "tbl_borrower";
            string table_Columns = "(Borrower_First_Name, Borrower_Middle_Name, Borrower_Last_Name, Borrower_Gender, Borrower_Address, Borrower_Contact_Number, Borrower_BirthDate, Borrower_Type_of_Valid_ID)";
            string table_Column_Values = "(" +
                singleQuoteChar + tbl_Borrower_Info.Borrower_First_Name + singleQuoteChar + ", " +
                singleQuoteChar + tbl_Borrower_Info.Borrower_Middle_Name + singleQuoteChar + ", " +
                singleQuoteChar + tbl_Borrower_Info.Borrower_Last_Name + singleQuoteChar + ", " +
                singleQuoteChar + tbl_Borrower_Info.Borrower_Gender + singleQuoteChar + ", " +
                singleQuoteChar + tbl_Borrower_Info.Borrower_Address + singleQuoteChar + ", " +
                singleQuoteChar + tbl_Borrower_Info.Borrower_Contact_Number + singleQuoteChar + ", " +
                singleQuoteChar + tbl_Borrower_Info.Borrower_BirthDate + singleQuoteChar + ", " +
                singleQuoteChar + tbl_Borrower_Info.Borrower_Type_of_Valid_ID + singleQuoteChar + 
                ")";
            
            ///////////

            string insert_SQL_StateMent = "Insert into "+ table_Name + " " + table_Columns +"  values " + table_Column_Values;

           return insert_DBMethod(insert_SQL_StateMent);
        }
           
        public bool insert_To_tbl_book(Info_tbl_book tbl_book_Info)
            //(string Book_Tittle, string Book_Author, string Book_Genre, /*DateTime*/ string Book_Year_Published, string Book_Publisher, int Book_Number_Of_Quantity)
        {

            ////////

            string singleQuoteChar = "'";

            string table_Name = "tbl_book";
            string table_Columns = "(Book_Tittle, Book_Author, Book_Genre, Book_Year_Published, Book_Publisher, Book_Number_Of_Quantity)";
            //string table_Columns = "(Book_Tittle, Book_Author, Book_Genre,  Book_Publisher, Book_Number_Of_Quantity)";
            string table_Column_Values = "(" +
                singleQuoteChar + tbl_book_Info.Book_Tittle + singleQuoteChar + ", " +
                singleQuoteChar + tbl_book_Info.Book_Author + singleQuoteChar + ", " +
                singleQuoteChar + tbl_book_Info.Book_Genre + singleQuoteChar + ", " +
                singleQuoteChar + tbl_book_Info.Book_Year_Published + singleQuoteChar + ", " +
                singleQuoteChar + tbl_book_Info.Book_Publisher + singleQuoteChar + ", " +
                tbl_book_Info.Book_Number_Of_Quantity +
                ")";

            ///////////

            string insert_SQL_StateMent = "Insert into " + table_Name + " " + table_Columns + "  values " + table_Column_Values;

            return insert_DBMethod(insert_SQL_StateMent);

        }


        public bool is_Book_ID_Exist(int Book_ID)
        {
            string query = $"SELECT Book_ID FROM `tbl_book` WHERE `Book_ID` = \"{Book_ID}\"";
            List<List<string>> Book_ID_2D_List = select_DBMethod_return_2DList_Table_Records(query);
            if((Book_ID_2D_List.Count != 0) && (Book_ID_2D_List[0][0].Equals(Book_ID.ToString())))
            {
               // MessageBox.Show("Book_ID tama");

                return true;
            }
            else
            {
                //MessageBox.Show("Book_ID mali");

                return false;
            }    
        }

        public bool is_Borrower_ID_Exist(int Borrower_ID)
        {
            string query = $"SELECT Borrower_ID FROM `tbl_borrower` WHERE `Borrower_ID` = \"{Borrower_ID}\"";
            List<List<string>> Borrower_ID_2D_List = select_DBMethod_return_2DList_Table_Records(query);
            if ((Borrower_ID_2D_List.Count != 0) && (Borrower_ID_2D_List[0][0].Equals(Borrower_ID.ToString())))
            {
                //MessageBox.Show("Borrower_ID tama");

                return true;
            }
            else
            {
                //MessageBox.Show("Borrower_ID mali");

                return false;
            }
        }

        //*
        public bool insert_To_tbl_borrowed_book(Info_tbl_borrowed_book tbl_borrowed_book_Info)
            //(int Book_ID, int Borrower_ID, string Borrowed_Book_Date_Borrowed, string Borrowed_Book_Due_Date, string Borrowed_Book_Due_Status, string Borrowed_Book_Date_Returned, int Borrowed_Book_Number_of_Copies)
        {

            ////////

            if ((is_Book_ID_Exist(tbl_borrowed_book_Info.Book_ID)) && (is_Borrower_ID_Exist(tbl_borrowed_book_Info.Borrower_ID)))
            {

                //MessageBox.Show("Pumasok dito tama Book_ID at Borrower_ID");

                string singleQuoteChar = "'";

                string table_Name = "tbl_borrowed_book";
                string table_Columns = "(Book_ID, Borrower_ID, Borrowed_Book_Date_Borrowed, Borrowed_Book_Due_Date, Borrowed_Book_Due_Status, Borrowed_Book_Date_Returned, Borrowed_Book_Number_of_Copies)";
                //string table_Columns = "(Book_Tittle, Book_Author, Book_Genre,  Book_Publisher, Book_Number_Of_Quantity)";
                string table_Column_Values = "(" +
                    tbl_borrowed_book_Info.Book_ID + ", " +
                    tbl_borrowed_book_Info.Borrower_ID + ", " +
                    singleQuoteChar + tbl_borrowed_book_Info.Borrowed_Book_Date_Borrowed + singleQuoteChar + ", " +
                    singleQuoteChar + tbl_borrowed_book_Info.Borrowed_Book_Due_Date + singleQuoteChar + ", " +
                    singleQuoteChar + tbl_borrowed_book_Info.Borrowed_Book_Due_Status + singleQuoteChar + ", " +
                    singleQuoteChar + tbl_borrowed_book_Info.Borrowed_Book_Date_Returned + singleQuoteChar + ", " +
                    tbl_borrowed_book_Info.Borrowed_Book_Number_of_Copies +
                    ")";

                ///////////

                string insert_SQL_StateMent = "Insert into " + table_Name + " " + table_Columns + "  values " + table_Column_Values;

                bool isSuccess = insert_DBMethod(insert_SQL_StateMent);


                string num_Qntty = select_DBMethod_return_a_Cell("tbl_book", "Book_ID", tbl_borrowed_book_Info.Book_ID, LDMS_Constants.Book_Number_Of_Quantity_CONST);
                int value = int.Parse(num_Qntty) - tbl_borrowed_book_Info.Borrowed_Book_Number_of_Copies;
                if (isSuccess)
                {
                    string query = $"UPDATE `tbl_book` SET `Book_Number_Of_Quantity`=\"{value}\" WHERE `Book_ID` = '{tbl_borrowed_book_Info.Book_ID}'";
                    return connectDB_And_ExecuteNonQuery(query);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //MessageBox.Show("di Pumasok dito tama Book_ID at Borrower_ID");
                return false;
            }

            
        }
        //*/
        public List<List<string>> select_DBMethod_return_2DList_Table_Records(string select_SQL_StateMent)
        {
            connectDB = new MySqlConnection(ConnectString);

            List<List<string>> select_Query_Result_2D_Liist = new List<List<string>>();
            try
            {
                connectDB.Open();
                cmd = new MySqlCommand(select_SQL_StateMent, connectDB);
                MySqlDataReader tableReader = cmd.ExecuteReader();

                while (tableReader.Read())
                {
                    List<string> rowRecord_StrList = new List<string>();

                    for (int i = 0; i < tableReader.FieldCount; i++)
                    {
                        rowRecord_StrList.Add(tableReader.GetValue(i).ToString());
                    }
                 
                    select_Query_Result_2D_Liist.Add(rowRecord_StrList);
                }
            }
            catch (Exception e)
            {

                return null;
            }
            finally
            {
                connectDB.Close();
            }

            return select_Query_Result_2D_Liist;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="ID_name"></param>
        /// <param name="ID"></param>
        /// <param name="column_Name"></param>
        /// <returns></returns>
        public string select_DBMethod_return_a_Cell(string table_Name, string ID_name, int ID, string column_Name)
        {
            string select_SQL_StateMent = $"SELECT {column_Name} FROM `{table_Name}` WHERE `{ID_name}` = \"{ID}\"";
            List<List<string>> temp2DStrList_Row = select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
            string select_Query_A_Cell = "";

            select_Query_A_Cell = temp2DStrList_Row[0][0];
            /*
            int outerIndex = 0;
            foreach (List<string> infos in temp2DStrList_Row)
            {
                int innerIndex = 0;
                foreach (string info in infos)
                {
                    select_Query_1D_StrList_Row.Add(temp2DStrList_Row[outerIndex][innerIndex]);
                    innerIndex++;
                }
                outerIndex++;
            }
            //*/
            return select_Query_A_Cell;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="ID_name"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<string> select_DBMethod_return_A_Row_Of_Records(string table_Name, string ID_name, int ID)
        {
            string select_SQL_StateMent = $"SELECT * FROM `{table_Name}` WHERE `{ID_name}` = \"{ID}\"";
            List<List<string>> temp2DStrList_Row = select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
            List<string> select_Query_1D_StrList_Row = new List<string>();

            int outerIndex = 0;
            foreach (List<string> infos in temp2DStrList_Row)
            {
                int innerIndex = 0;
                foreach (string info in infos)
                {
                    select_Query_1D_StrList_Row.Add(temp2DStrList_Row[outerIndex][innerIndex]);
                    innerIndex++;
                }
                outerIndex++;
            }

            return select_Query_1D_StrList_Row;
        }
        
        public List<string> select_DBMethod_return_A_Column_Of_Records(string table_Name, string column_Name)
        {
            string select_SQL_StateMent = $"SELECT {column_Name} FROM `{table_Name}`";
            List<List<string>> temp2DStrList_Column = select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
            List<string> select_Query_1D_StrList_Column = new List<string>();

            foreach (List<string> rowItem in temp2DStrList_Column)
            {
                select_Query_1D_StrList_Column.Add(rowItem[0]);
            }
            return select_Query_1D_StrList_Column;

        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="column_Name"></param>
        /// <param name="column_Name_OrderBy"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public List<string> select_DBMethod_return_A_Column_Of_Distinct_Records_OrderBy(string table_Name, string column_Name, string column_Name_OrderBy, string orderBy = "ASC")
        {
            string select_SQL_StateMent = $"SELECT {column_Name} FROM `{table_Name}` ORDER BY {column_Name_OrderBy} {orderBy}";
            List<List<string>> temp2DStrList_Column = select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
            List<string> select_Query_1D_StrList_Column = new List<string>();

            foreach (List<string> rowItem in temp2DStrList_Column)
            {
                select_Query_1D_StrList_Column.Add(rowItem[0]);
            }


            select_Query_1D_StrList_Column = select_Query_1D_StrList_Column.Distinct().ToList();

            return select_Query_1D_StrList_Column;
        }


        public List<List<string>> select_ALL_Form_tbl_borrower()
        {

            //sqlStrCommand = "Select * From main";
            
            
            string singleQuoteChar = "'";

            string table_Name = "tbl_borrower";
            /*
            string table_Columns = "(Borrower_Last_Name, Borrower_First_Name, Borrower_Middle_Name, Borrower_Name, Borrower_Address, Borrower_Contact_Number, Borrower_Age, Borrower_Type_of_Valid_ID)";
            string table_Column_Values = "(" +
                singleQuoteChar + Borrower_Last_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_First_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Middle_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Address + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Contact_Number + singleQuoteChar + ", " +
                Borrower_Age + ", " +
                singleQuoteChar + Borrower_Type_of_Valid_ID + singleQuoteChar +
                ")";
            //*/
            ///////////

            string select_SQL_StateMent = "Select * From " + table_Name;


            return select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
        }

        /// <summary>
        /// Update book dependin on ID and book info
        /// </summary>
        /// <param name="Book_ID"></param>
        /// <param name="tbl_book_Info"></param>
        /// <returns></returns>
        public bool update_DBMethod_tbl_book(int Book_ID, Info_tbl_book tbl_book_Info)
        {
            if (is_Book_ID_Exist(Book_ID))
            {
                string query = $"UPDATE `tbl_book` SET `Book_Title`=\"{tbl_book_Info.Book_Tittle}\"," +
                $"`Book_Author`=\"{tbl_book_Info.Book_Author}\"" +
                $",`Book_Genre`=\"{tbl_book_Info.Book_Genre}\"," +
                $"`Book_Year_Published`=\"{tbl_book_Info.Book_Year_Published}\"," +
                $"`Book_Publisher`=\"{tbl_book_Info.Book_Publisher}\"" +
                $",`Book_Number_Of_Quantity`=\"{tbl_book_Info.Book_Number_Of_Quantity}\" WHERE `Book_ID` = '{Book_ID}'";
                return connectDB_And_ExecuteNonQuery(query);
            }
            else
            {
                return false;
            }                 
        }
        /*
        public List<string> delete_DBMethod_return_row_Record(string table_name, int ID)
        {
            List<string> select_row = new List<string>();
            if (is_Book_ID_Exist(Book_ID))
            {
                string select_querry = $"Select * from WHERE `Book_ID` = '{Book_ID}'";
                List<List<string>> temp = select_DBMethod_return_2DList_Table_Records(select_querry);
                select_row = new List<string>(temp);
                string query = $"DELETE FROM `tbl_book` WHERE `Book_ID` = '{Book_ID}'";
                bool isSucces = connectDB_And_ExecuteNonQuery(query);
                if(isSucces)
                {
                    return select_row;
                }
                else
                {
                    return "";
                }


            }
            else
            {
                return "";
            }
        }
        //*/


        /// <summary>
        /// Delete book depending on id
        /// </summary>
        /// <param name="id">reference of id</param>
        /// <returns>return true if delete were successful</returns>
        public bool delete_DBMethod_tbl_book(int Book_ID)
        {
            if (is_Book_ID_Exist(Book_ID))
            {
                string query = $"DELETE FROM `tbl_book` WHERE `Book_ID` = '{Book_ID}'";
                return connectDB_And_ExecuteNonQuery(query);
            }
            else
            {
                return false;
            } 
        }

        public List<List<string>> selectbakalla()
        {
            string table_Name = "tbl_borrower";

            string select_SQL_StateMent = "Select Borrower_Last_Name from " + table_Name + "where Borrower_Last_Name = Tan";

            return select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);

        }
    }

}
