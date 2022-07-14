using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrartDataManagementSystem.Scripts;
using LibrartDataManagementSystem;

namespace LibrartDataManagementSystem
{
    public partial class MemberSearchLayoutForm : Form
    {

        List<List<string>> demoListOfListOfString;


        LDMS_DataBaseController myLDMS_DataBaseController = new LDMS_DataBaseController();

        private LogController _logController = new LogController();
        private MembersController _MembersController = new MembersController();

        SearchFilterMember myComboBoxFilters = new SearchFilterMember();


        public MemberSearchLayoutForm()
        {
            InitializeComponent();
        }

        
        private void fillBorrwerSearchFilters(int lastNameIndex, int genderIndex, int birthDateIndex)
        {
            _MembersController.FillDropdown(combBx_Borrower_Last_Name_MemberSearch, SearchFilterMember.FilterNames.f_1_Last_Name);
            _MembersController.FillDropdown(combBx_Borrower_Gender_MemberSearch, SearchFilterMember.FilterNames.f_2_Gender);
            _MembersController.FillDropdown(combBx_Borrower_BirthDate_MemberSearch, SearchFilterMember.FilterNames.f_3_BirthDate);

            combBx_Borrower_Last_Name_MemberSearch.SelectedIndex = lastNameIndex;
            combBx_Borrower_Gender_MemberSearch.SelectedIndex = genderIndex;
            combBx_Borrower_BirthDate_MemberSearch.SelectedIndex = birthDateIndex;
        }

        private void event_FormLoad()// Here_EVENT
        {
            fillBorrwerSearchFilters(0, 0, 0);


            myComboBoxFilters.v_1_Borrower_Last_Name = combBx_Borrower_Last_Name_MemberSearch.SelectedItem.ToString();
            myComboBoxFilters.v_2_Borrower_Gender = combBx_Borrower_Gender_MemberSearch.SelectedItem.ToString();
            myComboBoxFilters.v_3_Borrower_BirthDate = combBx_Borrower_BirthDate_MemberSearch.SelectedItem.ToString();


            _MembersController.FillTable(dtGrdVw_MemberSearch, txtBx_MemberSearch.Text, myComboBoxFilters);
            
            
            //_BorrwersController.FillQuantityColor(dtGrdVw_BorrwerSearch);
        }


        //btn_Search/btn_refresh CLICK - GenerateTable

        
        
        public void GenerateTable(bool withDropdown = true, bool fromOtherForm = false)
        {
            if (withDropdown)
            {
                int lastNameIndex = combBx_Borrower_Last_Name_MemberSearch.SelectedIndex;
                int genderIndex = combBx_Borrower_Gender_MemberSearch.SelectedIndex;
                int birthDateIndex = combBx_Borrower_BirthDate_MemberSearch.SelectedIndex;

                fillBorrwerSearchFilters(lastNameIndex, genderIndex, birthDateIndex);              
            }


            myComboBoxFilters.v_1_Borrower_Last_Name = combBx_Borrower_Last_Name_MemberSearch.SelectedItem.ToString();
            myComboBoxFilters.v_2_Borrower_Gender = combBx_Borrower_Gender_MemberSearch.SelectedItem.ToString();
            myComboBoxFilters.v_3_Borrower_BirthDate = combBx_Borrower_BirthDate_MemberSearch.SelectedItem.ToString();


            _MembersController.FillTable(dtGrdVw_MemberSearch, txtBx_MemberSearch.Text, myComboBoxFilters);

         }


        //DropdownChange
        private void event_DropdownChange()//HERE_EVENT
        {
            if (combBx_Borrower_Last_Name_MemberSearch.SelectedItem != null && 
                combBx_Borrower_Gender_MemberSearch.SelectedItem != null &&
                combBx_Borrower_BirthDate_MemberSearch.SelectedItem != null)
            {
                GenerateTable(false);
            }
        }


        // EVENT_HERE - btn_EditClick
        private void event_btn_Edit_Click()
        {
            int rowIndex = dtGrdVw_MemberSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_MemberSearch.Rows[rowIndex].Cells[DGV_BORROWER.Column_Names.col_0_ID_CONST].Value.ToString();
            detailPopUp(id);
            GenerateTable();
        }


        private DialogResult warning_Message(string msg, string caption)
        {
            return MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }


        // EVENT_HERE - btn_DeleteClick
        private void event_btn_Delete_Click()
        {
            int rowIndex = dtGrdVw_MemberSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_MemberSearch.Rows[rowIndex].Cells[DGV_BORROWER.Column_Names.col_0_ID_CONST].Value.ToString();//"Column_Borrwer_ID"].Value.ToString();
            string name = dtGrdVw_MemberSearch.Rows[rowIndex].Cells[DGV_BORROWER.Column_Names.col_1_First_Name_CONST].Value.ToString() + " " +
                          dtGrdVw_MemberSearch.Rows[rowIndex].Cells[DGV_BORROWER.Column_Names.col_3_Last_Name_CONST].Value.ToString();//"Column_Borrwer_Title"].Value.ToString();
            bool successDelete = false;

            string msg = "Are you sure you want to Delete this Record?";
            string caption = "WARNING!!! Deletion!";
            if (warning_Message(msg, caption) == DialogResult.Yes)
            {
                successDelete =_MembersController.deleteMember(int.Parse(id));
                if (successDelete)
                {
                    MessageBox.Show($"{name} is successfully deleted!", "Success!");
                    //_logController. //---//
                }
                else
                {
                    MessageBox.Show($"{name} is NOT successfully deleted!", "Failed!");
                }
            }
            else
            {
                MessageBox.Show($"Deletion of {name} is cancelled...");
            }

            GenerateTable();
        }


        //
        private void event_dtGrdVw_BorrwerSearch_CellDoubleClick()
        {
            int rowIndex = dtGrdVw_MemberSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_MemberSearch.Rows[rowIndex].Cells[DGV_BORROWER.Column_Names.col_0_ID_CONST].Value.ToString();//"Column_Borrwer_ID"].Value.ToString();

            detailPopUp(id);
        }


        private void detailPopUp(string id)
        {
            //BorrwersDetailPopUp detailPopup = new BorrwersDetailPopUp(id);
            //detailPopup.ShowDialog();
        }














        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        






        private void dtGrdVw_MemberSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void MemberSearchLayoutForm_Load(object sender, EventArgs e)
        {
            //demoLang_select_ALL_Form_tbl_borrower();
            //testDemolang();
            event_FormLoad();
        }


        private void demoLang_select_ALL_Form_tbl_borrower()
        {
            List<List<string>> selectItems_2DList = new List<List<string>>();

            selectItems_2DList = myLDMS_DataBaseController.select_DBMethod_BORROWER();


            dtGrdVw_MemberSearch.Rows.Clear();

            /*
            foreach (List<string> rowIinfos in selectItems_2DList)
            {
                int outerIndex = dtGrdVw_MemberSearch.Rows.Add();
                int innerIndex = 0;

                /*
                foreach (string info in rowIinfos)
                {
                    if(innerIndex < (rowIinfos.Count-2))
                    {
                        dtGrdVw_MemberSearch.Rows[outerIndex].Cells[innerIndex].Value = info;
                        innerIndex++;
                    }
                    
                }
                
                
                /*
                for (int i = 1; i < (rowIinfos.Count-1); i++)
                {
                    dtGrdVw_MemberSearch.Rows[outerIndex].Cells[i].Value = rowIinfos[i];

                }
                /////
            }
            //*/
            //*
            string msgFormat = "";

            foreach (List<string> row in selectItems_2DList)
            {
                foreach (string item in row)
                {
                    msgFormat += item + "\t";
                }
                msgFormat += "\n";
            }

            MessageBox.Show(msgFormat);
            //*/
        }



        private void testDemolang()
        {
            dtGrdVw_MemberSearch.Rows.Clear();

            demoListOfListOfString = generate2DListString();

            foreach (List<string> infos in demoListOfListOfString)
            {
                int outerIndex = dtGrdVw_MemberSearch.Rows.Add();
                int innerIndex = 0;
                foreach (string info in infos)
                {
                    dtGrdVw_MemberSearch.Rows[outerIndex].Cells[innerIndex].Value = info;
                    innerIndex++;
                }
            }


        }

        private List<List<string>> generate2DListString()
        {
            List<List<string>> list2dString = new List<List<string>>();
            List<String> rowListString = new List<string>();

            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");

            list2dString.Add(rowListString);

            return list2dString;
        }

        private void btn_Borrow_Btn_Click(object sender, EventArgs e)
        {
            TransactionBorrowLayoutForm triggeredBorrowLayoutForm = new TransactionBorrowLayoutForm();

            triggeredBorrowLayoutForm.Show();
        }

        private void btn_Member_Search_Click(object sender, EventArgs e)
        {
            GenerateTable(false);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GenerateTable();
        }

        private void btn_EditMemberSearch_Click(object sender, EventArgs e)
        {
            event_btn_Edit_Click();
        }

        private void btn_DeleteMemberSearch_Click(object sender, EventArgs e)
        {
            event_btn_Delete_Click();
        }

        private void dtGrdVw_MemberSearch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            event_dtGrdVw_BorrwerSearch_CellDoubleClick();
        }

        private void combBx_Borrower_Last_Name_MemberSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            event_DropdownChange();
        }
    }
}
