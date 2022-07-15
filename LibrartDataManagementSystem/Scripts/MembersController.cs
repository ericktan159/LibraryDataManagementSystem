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
    class SearchFilterMember
    {

        //public string Borrower_First_Name;
        public string v_1_Borrower_Last_Name;
        public string v_2_Borrower_Gender;
        public string v_3_Borrower_BirthDate;

        public static class FilterNames
        {
            public const string table_Name = Info_TBL_BORR0WER.Const_Names.table_Name;

            //public const string c_First_Name = Info_TBL_BORR0WER.Const_Names.col_1_Borrower_First_Name_CONST;
            public const string f_1_Last_Name = Info_TBL_BORR0WER.Const_Names.col_3_Borrower_Last_Name_CONST;
            public const string f_2_Gender = Info_TBL_BORR0WER.Const_Names.col_4_Borrower_Gender_CONST;
            public const string f_3_BirthDate = Info_TBL_BORR0WER.Const_Names.col_7_Borrower_BirthDate_CONST;


        }
    }

    class MembersController
    {
        LDMS_DataBaseController dbController = new LDMS_DataBaseController();
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        Info_TBL_BORR0WER tbl_Infos = new Info_TBL_BORR0WER();
        LogController _logController = new LogController();

        Common_Controller myCommon_Controller = new Common_Controller();


        public bool isInputComplete(TextBox[] inputs)
        {

            return myCommon_Controller.isTextBoxeSComplete(inputs);

        }

        public bool AddBorrowers(Info_TBL_BORR0WER tbl_Info)
        {
            return dbController.insert_DBMethod_BORROWER(tbl_Info);
        }

        public void ClearInputs(TextBox[] inputs)
        {
            myCommon_Controller.ClearTextBoxeS(inputs);
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

        public void FillTable(DataGridView table, string search, SearchFilterMember searchFilters_M)
        {
            table.Rows.Clear();
            search = search.Trim();
            string query = QuerySelectFill(search, searchFilters_M);
            List<List<string>> BorrowersDetails = dbController.select_DBMethod_return_2DList_Table_Records(query);
            //Console.WriteLine(query);

            fill_DataGridView_Members(table, BorrowersDetails);
        }

        public void FillTable(DataGridView table)
        {
            string query = $"SELECT * FROM `{Info_TBL_BORR0WER.Const_Names.table_Name}`";

            List<List<string>> BorrowersDetails = dbController.select_DBMethod_return_2DList_Table_Records(query);

            fill_DataGridView_Members(table, BorrowersDetails);
        }

        public void FillDropdown(ComboBox dropDownObject, string searchFor)
        {

            myCommon_Controller.fill_ComboBox_Filter(dropDownObject, Info_TBL_BORR0WER.Const_Names.table_Name, searchFor, "ASC");

        }
        /*
        public List<string> CheckIfBorrowerExist(Info_TBL_BORR0WER tbl_Infos)
        {
            /*
            string query = $"SELECT * FROM `tbl_Borrower` WHERE `Borrower_Title` = \"{BorrowerTitle}\" AND " +
                $"`Borrower_Author` = \"{BorrowerAuthor}\" AND `Borrower_Genre` = \"{BorrowerGenre}\" AND " +
                $"`Borrower_Publisher` = \"{BorrowerPublisher}\" AND `Borrower_Year_Published` = \"{yearPublished}\"";
            List<List<string>> Borrowers = dbController.select_DBMethod_return_2DList_Table_Records(query);
            List<string> result = new List<string>();
            foreach (List<string> Borrower in Borrowers)
            {
                result.Add(Borrower[0]);
            }
            return result;

            //* /

            //int nakalimutan_mo_ata_Borrower_Number_Of_Quantity = 1;

            //tbl_Infos.Borrower_Tittle = BorrowerTitle;
            //tbl_Infos.Borrower_Author = BorrowerAuthor;
            //tbl_Infos.Borrower_Genre = BorrowerGenre;
            //tbl_Infos.Borrower_Year_Published = yearPublished;
            //tbl_Infos.Borrower_Publisher = BorrowerPublisher;
            //tbl_Infos.Borrower_Number_Of_Quantity = 1;



            return dbController.select_DBMethod_Table_Details_Return_Prime_ID_Column(tbl_Infos);

        }
         //*/
        public string GetFirstName(string id)
        {
            return dbController.select_DBMethod_return_a_Cell(Info_TBL_BORR0WER.Const_Names.table_Name, int.Parse(id), Info_TBL_BORR0WER.Const_Names.col_1_Borrower_First_Name_CONST);
        }

        /*
        public bool AddBorrowerQuantity(string BorrowerID, int quantity)
        {
            /*
            int currentQuantity =
                int.Parse(dbController.select_DBMethod_return_2DList_Table_Records("SELECT " +
                $"`Borrower_Number_Of_Quantity` FROM `tbl_Borrower` WHERE `Borrower_ID` = " +
                $"\"{BorrowerID}\"")[0][0]);
            string query = $"UPDATE `tbl_Borrower` SET `Borrower_Number_Of_Quantity`='{currentQuantity + quantity}' " +
                $"WHERE `Borrower_ID` = \"{BorrowerID}\"";
            bool success = dbController.insert_DBMethod(query);
            return success;
            //* /

            return dbController.update_DBMethod_Update_A_Cell(Info_TBL_BORR0WER.Const_Names.table_Name,
                                                                int.Parse(BorrowerID),
                                                                Info_TBL_BORR0WER.Const_Names.col_6_Borrower_Number_Of_Quantity_CONST,
                                                                quantity);

        }
        public void FillQuantityColor(DataGridView table)
        {
            foreach (DataGridViewRow row in table.Rows)
            {
                DataGridViewCell cell = row.Cells["Column_Borrower_Number_Of_Quantity"];
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
        //*/

        /// <summary>
        /// check if the user exist
        /// </summary>
        /// <param name="fName">first name to check</param>
        /// <param name="mName">middle name to check</param>
        /// <param name="lName">last name to check</param>
        /// <param name="bDay">birthday to check</param>
        /// <returns>return true if exist</returns>
        public bool CheckIfUserExist(string fName, string mName, string lName, string bDay)
        {
            string query = $"SELECT * FROM `tbl_borrower` WHERE `Borrower_First_Name` = \"{fName}\" " +
                $"AND `Borrower_Middle_Name` = \"{mName}\" AND `Borrower_Last_Name` = \"{lName}\" " +
                $"AND `Borrower_BirthDate` = \"{bDay}\"";
            List<List<string>> result = dbController.select_DBMethod_return_2DList_Table_Records(query);
            Console.WriteLine(result.Count);
            foreach (List<string> res in result)
            {
                Console.WriteLine(res);
            }
            return true;
        }

        public List<string> GetBorrowerDetails(string id)
        {
            return dbController.select_DBMethod_return_A_Row_Of_Records(Info_TBL_BORR0WER.Const_Names.table_Name, int.Parse(id));
        }

        public void FillDetails(Label[] labels, string id)
        {

            ////////////////////////////////////
            ///
            List<string> results = GetBorrowerDetails(id);
            labels[0].Text = results[1];
            labels[1].Text = results[2];
            labels[2].Text = results[3];
            labels[3].Text = results[4];
            labels[4].Text = results[5];
            labels[5].Text = results[6];

            ////////////////////////////////
        }
        public void FillInputs(TextBox title, TextBox author, TextBox genre, DateTimePicker yearPublished,
            TextBox publisher, TextBox quantity, string id)
        {
            /////////////////
            ///

            List<string> results = GetBorrowerDetails(id);
            title.Text = results[1];
            author.Text = results[2];
            genre.Text = results[3];
            yearPublished.Value = DateTime.ParseExact(results[4], "yyyy", CultureInfo.InvariantCulture);
            publisher.Text = results[5];
            quantity.Text = results[6];

            ///////////////////////////////
        }

        public bool UpdateBorrowers(int Borrower_ID, Info_TBL_BORR0WER tbl_Infos)
        {
            return dbController.update_DBMethod_BORROWER(Borrower_ID, tbl_Infos);
        }

        public bool deleteMember(int Borrower_ID)
        {
            return dbController.delete_DBMethod_return_Boolean(Info_TBL_BORR0WER.Const_Names.table_Name, Borrower_ID);
        }

        public string GetLastBorrowerID()
        {
            string query = $"SELECT * FROM `{Info_TBL_BORR0WER.Const_Names.table_Name}` " +
                           $"ORDER BY `{Info_TBL_BORR0WER.Const_Names.Primary_Key_ID_Name_CONST}` DESC LIMIT 1";
            List<List<string>> res = dbController.select_DBMethod_return_2DList_Table_Records(query);
            return res[0][0];
        }

        /*
        public string GetQuantity(string id)
        {
            string query = $"SELECT * FROM `tbl_Borrower` WHERE `Borrower_ID` = {id}";
            List<List<string>> res = dbController.select_DBMethod_return_2DList_Table_Records(query);
            return res[0][6];
        }
        //*/


        public string QuerySelectFill(string search, SearchFilterMember searchFilters_M)
        {
            // initialize all needed query
            string query = $"SELECT * FROM `{SearchFilterMember.FilterNames.table_Name}` ";
            string whereQuery = "";
            string searchQuery = "";
            string v_1_Last_Name_Filter = "";
            string v_2_Gender_Filter = "";
            string v_3_BirthDate_Filter = "";

            // fill the query
            if (search != "")
            {
                whereQuery = "WHERE ";
                searchQuery = $"(" +
                    $"`{Info_TBL_BORR0WER.Const_Names.col_1_Borrower_First_Name_CONST}` REGEXP \".*{search}.*\" OR " +

                    $"`{SearchFilterMember.FilterNames.f_1_Last_Name}` REGEXP \".*{search}.*\" OR " +
                    $"`{SearchFilterMember.FilterNames.f_2_Gender}` REGEXP \".*{search}.*\" OR " +
                    $"`{SearchFilterMember.FilterNames.f_3_BirthDate}` REGEXP \".*{search}.*\" OR " +

                    $"`{Info_TBL_BORR0WER.Const_Names.Primary_Key_ID_Name_CONST}` = \"{search}\") ";
            }
            if (searchFilters_M.v_1_Borrower_Last_Name != "All")
            {
                if (whereQuery != "")
                {
                    v_1_Last_Name_Filter = $"AND ";

                }
                else
                {
                    whereQuery = "WHERE ";
                    v_1_Last_Name_Filter = $" ";
                }

                v_1_Last_Name_Filter += $"`{SearchFilterMember.FilterNames.f_1_Last_Name}` = \"{searchFilters_M.v_1_Borrower_Last_Name}\" ";

            }
            if (searchFilters_M.v_2_Borrower_Gender != "All")
            {
                if (whereQuery != "")
                {
                    v_2_Gender_Filter = $"AND ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    v_2_Gender_Filter = $" ";
                }
                v_2_Gender_Filter += $"`{SearchFilterMember.FilterNames.f_2_Gender}` = \"{searchFilters_M.v_2_Borrower_Gender}\" ";
            }
            if (searchFilters_M.v_3_Borrower_BirthDate != "All")
            {
                if (whereQuery != "")
                {
                    v_3_BirthDate_Filter = $"AND ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    v_3_BirthDate_Filter = $" ";
                }

                v_3_BirthDate_Filter = $"`{SearchFilterMember.FilterNames.f_3_BirthDate}` = \"{searchFilters_M.v_3_Borrower_BirthDate}\" ";
            }

            query += whereQuery + searchQuery + v_1_Last_Name_Filter + v_2_Gender_Filter + v_3_BirthDate_Filter;

            return query;
        }
    }
}
