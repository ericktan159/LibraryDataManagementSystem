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
