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

        public string v_1_Borrower_First_Name;
        public string v_2_Borrower_Last_Name;
        public string v_3_Borrower_Gender;
        //public string v_3_Borrower_BirthDate;

        public static class FilterNames
        {
            public const string table_Name = Info_TBL_BORR0WER.Const_Names.table_Name;

            public const string f_1_First_Name = Info_TBL_BORR0WER.Const_Names.col_1_Borrower_First_Name_CONST;
            public const string f_2_Last_Name = Info_TBL_BORR0WER.Const_Names.col_3_Borrower_Last_Name_CONST;
            public const string f_3_Gender = Info_TBL_BORR0WER.Const_Names.col_4_Borrower_Gender_CONST;
            //public const string f_3_BirthDate = Info_TBL_BORR0WER.Const_Names.col_7_Borrower_BirthDate_CONST;


        }
    }


    class My_Inputs_Member_Info
    {
        public TextBox input_1_txtBx_Borrower_First_Name;
        public TextBox input_2_txtBx_Borrower_Middle_Name;
        public TextBox input_3_txtBx_Borrower_Last_Name;
        public ComboBox input_4_combBx_Borrower_Gender;
        public TextBox input_5_txtBx_Borrower_Address;
        public TextBox input_6_txtBx_Borrower_Contact_Number;
        public DateTimePicker input_7_dtp_Borrower_BirthDate;
        public ComboBox input_8_combBx_Borrower_Type_of_Valid_ID;


        public static class Prop_About
        {
            public const int n_Size = Info_TBL_BORR0WER.Prop_About.n_Size;
        }

        public static Info_TBL_BORR0WER convert_Inputs_To_Info_TBL_BORR0WER(My_Inputs_Member_Info inputsFromForm)
        {
            Info_TBL_BORR0WER tbl_Infos = new Info_TBL_BORR0WER();

            tbl_Infos.Borrower_First_Name = inputsFromForm.input_1_txtBx_Borrower_First_Name.Text;
            tbl_Infos.Borrower_Middle_Name = inputsFromForm.input_2_txtBx_Borrower_Middle_Name.Text;
            tbl_Infos.Borrower_Last_Name = inputsFromForm.input_3_txtBx_Borrower_Last_Name.Text;
            tbl_Infos.Borrower_Gender = inputsFromForm.input_4_combBx_Borrower_Gender.SelectedItem.ToString();
            tbl_Infos.Borrower_Address = inputsFromForm.input_5_txtBx_Borrower_Address.Text;
            tbl_Infos.Borrower_Contact_Number = inputsFromForm.input_6_txtBx_Borrower_Contact_Number.Text;
            tbl_Infos.Borrower_BirthDate = inputsFromForm.input_7_dtp_Borrower_BirthDate.Value.ToString("MM-dd-yyyy"); 
            tbl_Infos.Borrower_Type_of_Valid_ID = inputsFromForm.input_8_combBx_Borrower_Type_of_Valid_ID.SelectedItem.ToString();


            return tbl_Infos;
        }

        public static Info_TBL_BORR0WER convert_Inputs_To_Info_TBL_BORR0WER(
            TextBox input_1_txtBx_Borrower_First_Name,
            TextBox input_2_txtBx_Borrower_Middle_Name,
            TextBox input_3_txtBx_Borrower_Last_Name,
            ComboBox input_4_combBx_Borrower_Gender,
            TextBox input_5_txtBx_Borrower_Address,
            TextBox input_6_txtBx_Borrower_Contact_Number,
            DateTimePicker input_7_dtp_Borrower_BirthDate,
            ComboBox input_8_combBx_Borrower_Type_of_Valid_ID)
        {

            Info_TBL_BORR0WER tbl_Infos = new Info_TBL_BORR0WER();

            tbl_Infos.Borrower_First_Name = input_1_txtBx_Borrower_First_Name.Text;
            tbl_Infos.Borrower_Middle_Name = input_2_txtBx_Borrower_Middle_Name.Text;
            tbl_Infos.Borrower_Last_Name = input_3_txtBx_Borrower_Last_Name.Text;
            tbl_Infos.Borrower_Gender = input_4_combBx_Borrower_Gender.SelectedItem.ToString();
            tbl_Infos.Borrower_Address = input_5_txtBx_Borrower_Address.Text;
            tbl_Infos.Borrower_Contact_Number = input_6_txtBx_Borrower_Contact_Number.Text;
            tbl_Infos.Borrower_BirthDate = input_7_dtp_Borrower_BirthDate.Value.ToString("MM-dd-yyyy");
            tbl_Infos.Borrower_Type_of_Valid_ID = input_8_combBx_Borrower_Type_of_Valid_ID.SelectedItem.ToString();


            return tbl_Infos;
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
                table.Rows[outerIndex].Cells[DGV_BORROWER.Column_Names.col_0_ID_CONST].Value = member_row[0];//"Column_Borrower_ID"
                table.Rows[outerIndex].Cells[DGV_BORROWER.Column_Names.col_1_First_Name_CONST].Value = member_row[1];//"Column_Borrower_First_Name"
                table.Rows[outerIndex].Cells[DGV_BORROWER.Column_Names.col_2_Middle_Name_CONST].Value = member_row[2];//"Column_Borrower_Middle_Name"
                table.Rows[outerIndex].Cells[DGV_BORROWER.Column_Names.col_3_Last_Name_CONST].Value = member_row[3];//"Column_Borrower_Last_Name"
                table.Rows[outerIndex].Cells[DGV_BORROWER.Column_Names.col_4_Gender_CONST].Value = member_row[4];//"Column_Borrower_Gender"
                table.Rows[outerIndex].Cells[DGV_BORROWER.Column_Names.col_5_Address_CONST].Value = member_row[5];//"Column_Borrower_Address"
                table.Rows[outerIndex].Cells[DGV_BORROWER.Column_Names.col_6_Contact_Number_CONST].Value = member_row[6];//"Column_Borrower_Conatact_Number"
                table.Rows[outerIndex].Cells[DGV_BORROWER.Column_Names.col_7_BirthDate_CONST].Value = member_row[7];//"Column_Borrower_BirthDate"
                table.Rows[outerIndex].Cells[DGV_BORROWER.Column_Names.col_8_Type_of_Valid_ID_CONST].Value = member_row[8];//"Column_Borrower_Type_Valid_ID"

            }

        }

        public string QuerySelectFill(string search, SearchFilterMember searchFilters_M)
        {
            // initialize all needed query
            string query = $"SELECT * FROM `{SearchFilterMember.FilterNames.table_Name}` ";
            string whereQuery = "";
            string searchQuery = "";
            string v_1_First_Name_Filter = "";
            string v_2_Last_Name_Filter = "";
            string v_3_Gender_Filter = "";

            // fill the query
            /*
            MessageBox.Show($"{SearchFilterMember.FilterNames.f_1_First_Name}: {searchFilters_M.v_1_Borrower_First_Name}" +
                            $"{SearchFilterMember.FilterNames.f_2_Last_Name}: {searchFilters_M.v_2_Borrower_Last_Name}" +
                            $"{SearchFilterMember.FilterNames.f_3_Gender}: {searchFilters_M.v_3_Borrower_Gender}");
            //*/
            if (search != "")
            {
                whereQuery = "WHERE ";
                searchQuery = $"(" +
                    $"`{Info_TBL_BORR0WER.Const_Names.col_1_Borrower_First_Name_CONST}` REGEXP \".*{search}.*\" OR " +

                    $"`{SearchFilterMember.FilterNames.f_1_First_Name}` REGEXP \".*{search}.*\" OR " +
                    $"`{SearchFilterMember.FilterNames.f_2_Last_Name}` REGEXP \".*{search}.*\" OR " +
                    $"`{SearchFilterMember.FilterNames.f_3_Gender}` REGEXP \".*{search}.*\" OR " +

                    $"`{Info_TBL_BORR0WER.Const_Names.Primary_Key_ID_Name_CONST}` = \"{search}\") ";
            }
            if (searchFilters_M.v_1_Borrower_First_Name != "All")
            {
                if (whereQuery != "")
                {
                    v_1_First_Name_Filter = $"AND ";

                }
                else
                {
                    whereQuery = "WHERE ";
                    v_1_First_Name_Filter = $" ";
                }

                v_1_First_Name_Filter += $"`{SearchFilterMember.FilterNames.f_1_First_Name}` = \"{searchFilters_M.v_1_Borrower_First_Name}\" ";

            }
            if (searchFilters_M.v_2_Borrower_Last_Name != "All")
            {
                if (whereQuery != "")
                {
                    v_2_Last_Name_Filter = $"AND ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    v_2_Last_Name_Filter = $" ";
                }
                v_2_Last_Name_Filter += $"`{SearchFilterMember.FilterNames.f_2_Last_Name}` = \"{searchFilters_M.v_2_Borrower_Last_Name}\" ";
            }
            if (searchFilters_M.v_3_Borrower_Gender != "All")
            {
                if (whereQuery != "")
                {
                    v_3_Gender_Filter = $"AND ";
                }
                else
                {
                    whereQuery = "WHERE ";
                    v_3_Gender_Filter = $" ";
                }
                v_3_Gender_Filter += $"`{SearchFilterMember.FilterNames.f_3_Gender}` = \"{searchFilters_M.v_3_Borrower_Gender}\" ";
            }

            query += whereQuery + searchQuery + v_1_First_Name_Filter + v_2_Last_Name_Filter + v_3_Gender_Filter;
            //MessageBox.Show(query);
            return query;
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


        public List<string> GetBorrowerDetails(string id)
        {
            return dbController.select_DBMethod_return_A_Row_Of_Records(Info_TBL_BORR0WER.Const_Names.table_Name, int.Parse(id));
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


        public string GetFirstName(int Borrower_ID)
        {
            return dbController.select_DBMethod_return_a_Cell(Info_TBL_BORR0WER.Const_Names.table_Name, Borrower_ID, Info_TBL_BORR0WER.Const_Names.col_1_Borrower_First_Name_CONST);
        }
        public string GetMiddleName(int Borrower_ID)
        {
            return dbController.select_DBMethod_return_a_Cell(Info_TBL_BORR0WER.Const_Names.table_Name, Borrower_ID, Info_TBL_BORR0WER.Const_Names.col_2_Borrower_Middle_Name_CONST);
        }
        public string GetLastName(int Borrower_ID)
        {
            return dbController.select_DBMethod_return_a_Cell(Info_TBL_BORR0WER.Const_Names.table_Name, Borrower_ID, Info_TBL_BORR0WER.Const_Names.col_3_Borrower_Last_Name_CONST);
        }
        public string getFullName(int Borrower_ID)
        {
            return GetFirstName(Borrower_ID) + " " + GetMiddleName(Borrower_ID) + " " + GetLastName(Borrower_ID);
        }









        public void fill_Labels_TableDeatails(string table_id, Label[] labels)
        {

            List<string> results = GetBorrowerDetails(table_id);
            labels[0].Text = results[1] + " " + results[2] + " " + results[3];
            
            labels[1].Text = results[4];
            labels[2].Text = results[5];
            labels[3].Text = results[6];
            labels[4].Text = results[7];
            labels[5].Text = results[8];
            

        }
        public void fill_Inputs_TableDeatails(string table_id, My_Inputs_Member_Info inputsFromForm)
        //(TextBox title, TextBox author, TextBox genre, DateTimePicker yearPublished,TextBox publisher, TextBox quantity, string id)
        {

            //*
            List<string> results = GetBorrowerDetails(table_id);
            inputsFromForm.input_1_txtBx_Borrower_First_Name.Text = results[1];
            inputsFromForm.input_2_txtBx_Borrower_Middle_Name.Text = results[2];
            inputsFromForm.input_3_txtBx_Borrower_Last_Name.Text = results[3];
            inputsFromForm.input_4_combBx_Borrower_Gender.SelectedItem = results[4];
            inputsFromForm.input_5_txtBx_Borrower_Address.Text = results[5];
            inputsFromForm.input_6_txtBx_Borrower_Contact_Number.Text = results[6];
            Console.WriteLine(results[7]);
            inputsFromForm.input_7_dtp_Borrower_BirthDate.Value = DateTime.ParseExact(results[7], "MM-dd-yyyy", CultureInfo.InvariantCulture);
            inputsFromForm.input_8_combBx_Borrower_Type_of_Valid_ID.SelectedItem = results[8];
            //*/
            ///////////////////////////////
        }

        public void init_GenderChoice_ComboBox(ComboBox genderComboBox)
        {

            Enum_CONST_Gender.set_ComboBox_Items(genderComboBox);
            /*
            genderComboBox.Items.Clear();

            genderComboBox.Items.Add(Enum_CONST_Gender.const_Male);
            genderComboBox.Items.Add(Enum_CONST_Gender.const_Female);

            genderComboBox.SelectedIndex = 0;
            //*/
        }


        /*
        public bool AddBorrowerQuantity(string BorrowerID, string value)
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
                                                                Info_TBL_BORR0WER.Const_Names.,
                                                                value);

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
            if(result.Count > 0)
            {
                return true;
            }
            return false;
        }

        

        

        /*
        public string GetQuantity(string id)
        {
            string query = $"SELECT * FROM `tbl_Borrower` WHERE `Borrower_ID` = {id}";
            List<List<string>> res = dbController.select_DBMethod_return_2DList_Table_Records(query);
            return res[0][6];
        }
        //*/



    }
}
