using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LibrartDataManagementSystem
{
    class LDMS_DataBaseController
    {
        string ConnectString = "datasource = localhost; username = root; password=; database = library_data_management_system;";//databasesample;";
        MySqlConnection connectDB;
        MySqlCommand cmd;
        MySqlDataAdapter da;

        public DataTable dt;
        int result;
        
        //*

        public void insert_DBMethod(string insert_SQL_StateMent)
        {
            /*
            string sqlStrCommand = "Insert into main (Name, age, address, Gender, isTraveled, isCloseContact, symptomsList, celNumber, eMailAddress) values " +
                    "('" + myCTInfo.name + "', " + myCTInfo.age + ", '" + myCTInfo.address + "', '" + myCTInfo.gender + "', '" + myCTInfo.isTraveledStr + "', '" + myCTInfo.isClosedContact +
                    "', '" + myCTInfo.symptomList + "', '" + myCTInfo.cellNumber + "', '" + myCTInfo.eMail + "')";

            */

            string msg_false = "Failure!!!";
            string msg_true = "Succes!!";

            connectDB = new MySqlConnection(ConnectString);

            try
            {
                connectDB.Open();
                cmd = new MySqlCommand(insert_SQL_StateMent, connectDB);
                //cmd.Connection = connectDB;
                //cmd.CommandText = sqlStrCommand;
                result = cmd.ExecuteNonQuery();

                /*
                if (result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                }
                //*/

                //MessageBox.Show("Succes!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Failed! " + e.Message);
            }
            finally
            {
                connectDB.Close();
            }

            //sqlCommandDB(sqlStrCommand);

        }
        //*/    



        public void insert_To_tbl_borrower(string Borrower_Last_Name, string Borrower_First_Name, string Borrower_Middle_Name, string Borrower_Address, string Borrower_Contact_Number, int Borrower_Age, string Borrower_Type_of_Valid_ID)
        {
            string Borrower_Name = Borrower_First_Name + " " + Borrower_Middle_Name + " " + Borrower_Last_Name;


            /*
            string sqlStrCommand = "Insert into main (Name, age, address, Gender, isTraveled, isCloseContact, symptomsList, celNumber, eMailAddress) values " +
                    "('" + myCTInfo.name + "', " + myCTInfo.age + ", '" + myCTInfo.address + "', '" + myCTInfo.gender + "', '" + myCTInfo.isTraveledStr + "', '" + myCTInfo.isClosedContact +
                    "', '" + myCTInfo.symptomList + "', '" + myCTInfo.cellNumber + "', '" + myCTInfo.eMail + "')";

            */

            ////////

            string singleQuoteChar = "'";

            string table_Name = "tbl_borrower";
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
            
            ///////////

            string insert_SQL_StateMent = "Insert into "+ table_Name + " " + table_Columns +"  values " + table_Column_Values;

            insert_DBMethod(insert_SQL_StateMent);

            return;
        }
           
        public void insert_To_tbl_book(string Book_Tittle, string Book_Author, string Book_Genre, /*DateTime*/ string Book_Year_Published, string Book_Publisher, int Book_Number_Of_Quantity)
        {

            ////////

            string singleQuoteChar = "'";

            string table_Name = "tbl_book";
            string table_Columns = "(Book_Tittle, Book_Author, Book_Genre, Book_Year_Published, Book_Publisher, Book_Number_Of_Quantity)";
            //string table_Columns = "(Book_Tittle, Book_Author, Book_Genre,  Book_Publisher, Book_Number_Of_Quantity)";
            string table_Column_Values = "(" +
                singleQuoteChar + Book_Tittle + singleQuoteChar + ", " +
                singleQuoteChar + Book_Author + singleQuoteChar + ", " +
                singleQuoteChar + Book_Genre + singleQuoteChar + ", " +
                singleQuoteChar + Book_Year_Published + singleQuoteChar + ", " +
                singleQuoteChar + Book_Publisher + singleQuoteChar + ", " +
                Book_Number_Of_Quantity +
                ")";

            ///////////

            string insert_SQL_StateMent = "Insert into " + table_Name + " " + table_Columns + "  values " + table_Column_Values;

            insert_DBMethod(insert_SQL_StateMent);

            return;
        }


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




    }

}
