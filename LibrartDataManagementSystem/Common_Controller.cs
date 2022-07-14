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
    
    class DataGridView_BOOK
    {
        public static class Column_Names
        {
            public const string col_0_ID_CONST = "Column_Book_ID";
            public const string col_1_Tittle_CONST = "Column_Book_Title";
            public const string col_2_Author_CONST = "Column_Book_Author";
            public const string col_3_Genre_CONST = "Column_Book_Genre";
            public const string col_4_Year_Published_CONST = "Column_Book_Year_published";
            public const string col_5_Publisher_CONST = "Column_Book_Publisher";
            public const string col_6_Number_Of_Quantity_CONST = "Column_Book_Number_Of_Quantity";
            //public const string col_7_Date_Encoded_CONST = ;
            
        }
    }

    class DataGridView_BORROWER
    {
        public static class Column_Names
        {
            public const string col_0_ID_CONST = "Column_Borrower_ID";
            public const string col_1_First_Name_CONST = "Column_Borrower_First_Name";
            public const string col_2_Middle_Name_CONST = "Column_Borrower_Middle_Name";
            public const string col_3_Last_Name_CONST = "Column_Borrower_Last_Name";
            public const string col_4_Gender_CONST = "Column_Borrower_Gender";
            public const string col_5_Address_CONST = "Column_Borrower_Address";
            public const string col_6_Contact_Number_CONST = "Column_Borrower_Conatact_Number";
            public const string col_7_BirthDate_CONST = "Column_Borrower_BirthDate";
            public const string col_8_Type_of_Valid_ID_CONST = "Column_Borrower_Type_Valid_ID";
            //public const string col_9_Date_Encoded_CONST = ;

        }
    }


    class DataGridView_BORROW_RETURNED_BOOK
    {
        public static class Column_Names
        {
            public const string col_0_ID_CONST = "Column_Borrowed_Book_ID";
            
            public const string col_1_Borrower_ID_CONST = "Column_Borrower_ID";
            public const string col_2_Book_ID_CONST = "Column_Book_ID";
            
            public const string col_3_Borrower_Name_CONST = "Column_Borrower_Name";
            public const string col_4_Due_Date_CONST = "Column_Book_Title";

            public const string col_5_Date_Borrowed_CONST = "Column_Borrowed_Book_Date_Borrowed";
            public const string col_6_Due_Date_CONST = "Column_Borrowed_Book_Due_Date";
            public const string col_7_Due_Status_CONST = "Column_Borrowed_Book_Due_Status";
            public const string col_8_Date_Returned_CONST = "ColumnBorrowed_Book_Date_Returned";
            public const string col_9_Number_of_Copies_CONST = "Column_Borrowed_Book_Number_of_Copies";
            //public const string col_8_Borrowed_Book_Date_Encoded_CONST = ;

            /*
             
            Column_Borrowed_Book_ID

            Column_Borrower_ID
            Column_Book_ID
            
            Column_Borrower_Name
            Column_Book_Title
            
            Column_Borrowed_Book_Date_Borrowed
            Column_Borrowed_Book_Due_Date
            Column_Borrowed_Book_Due_Status
            ColumnBorrowed_Book_Date_Returned
            Column_Borrowed_Book_Number_of_Copies
             //*/
        }
    }


    class DataGridView_LOGS
    {
        public static class Column_Names
        {
            public const string col_0_Logs_Description_CONST = "Column_Logs_Description";

            public const string col_1_Log_Type_CONST = "Column_Log_Type";
            public const string col_2_Log_Date_CONST = "Column_Log_Date";

            //public const string col_8_Borrowed_Book_Date_Encoded_CONST = ;

            /*
             Column_Logs_Description
            Column_Log_Type
            Column_Log_Date
             //*/
        }
    }


    class Common_Controller // wag nyo muna kalikutin. to be continued to. inaayos ko pa
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


        public void check_If_Duplicate_Entry()
        {

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


        

        

        
        





    }
}
