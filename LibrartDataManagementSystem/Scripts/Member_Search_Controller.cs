using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using LibrartDataManagementSystem.Members_Forms;

namespace LibrartDataManagementSystem.Scripts
{
    /// <summary>
    /// Contreller for Search Membertable
    /// </summary>
    class Member_Search_Controller
    {
        List<List<string>> demoListOfListOfString;

        LDMS_DataBaseController myLDMS_DataBaseController = new LDMS_DataBaseController();
        private LogController _logController = new LogController();
        private MembersController _MembersController = new MembersController();

        SearchFilterMember myComboBoxFilters = new SearchFilterMember();


        ComboBox combBx_Borrower_First_Name_MemberSearch;
        ComboBox combBx_Borrower_Last_Name_MemberSearch;
        ComboBox combBx_Borrower_Gender_MemberSearch;

        DataGridView dtGrdVw_MemberSearch;

        TextBox txtBx_MemberSearch;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="combBx_Borrower_First_Name_MemberSearch"></param>
        /// <param name="combBx_Borrower_Last_Name_MemberSearch"></param>
        /// <param name="combBx_Borrower_Gender_MemberSearch"></param>
        /// <param name="dtGrdVw_MemberSearch"></param>
        /// <param name="txtBx_MemberSearch"></param>
        public Member_Search_Controller(
            ComboBox combBx_Borrower_First_Name_MemberSearch,
            ComboBox combBx_Borrower_Last_Name_MemberSearch,
            ComboBox combBx_Borrower_Gender_MemberSearch,
            DataGridView dtGrdVw_MemberSearch,
            TextBox txtBx_MemberSearch)
        {
            this.combBx_Borrower_First_Name_MemberSearch = combBx_Borrower_First_Name_MemberSearch;
            this.combBx_Borrower_Last_Name_MemberSearch = combBx_Borrower_Last_Name_MemberSearch;
            this.combBx_Borrower_Gender_MemberSearch = combBx_Borrower_Gender_MemberSearch;

            this.dtGrdVw_MemberSearch = dtGrdVw_MemberSearch;

            this.txtBx_MemberSearch = txtBx_MemberSearch;

        }


        private void fillBorrwerSearchFilters(int firstNameIndex, int lastNameIndex, int genderIndex)
        {
            _MembersController.FillDropdown(combBx_Borrower_First_Name_MemberSearch, SearchFilterMember.FilterNames.f_1_First_Name);
            _MembersController.FillDropdown(combBx_Borrower_Last_Name_MemberSearch, SearchFilterMember.FilterNames.f_2_Last_Name);
            _MembersController.FillDropdown(combBx_Borrower_Gender_MemberSearch, SearchFilterMember.FilterNames.f_3_Gender);

            combBx_Borrower_First_Name_MemberSearch.SelectedIndex = firstNameIndex;
            combBx_Borrower_Last_Name_MemberSearch.SelectedIndex = lastNameIndex;
            combBx_Borrower_Gender_MemberSearch.SelectedIndex = genderIndex;

        }

        public void event_FormLoad()// Here_EVENT
        {
            fillBorrwerSearchFilters(0, 0, 0);


            myComboBoxFilters.v_1_Borrower_First_Name = combBx_Borrower_First_Name_MemberSearch.SelectedItem.ToString();
            myComboBoxFilters.v_2_Borrower_Last_Name = combBx_Borrower_Last_Name_MemberSearch.SelectedItem.ToString();
            myComboBoxFilters.v_3_Borrower_Gender = combBx_Borrower_Gender_MemberSearch.SelectedItem.ToString();


            _MembersController.FillTable(dtGrdVw_MemberSearch, txtBx_MemberSearch.Text, myComboBoxFilters);


            //_BorrwersController.FillQuantityColor(dtGrdVw_BorrwerSearch);
            event_refresh();
        }


        //btn_Search/btn_refresh CLICK - GenerateMembersTable



        public void GenerateMembersTable(bool withDropdown = true, bool fromOtherForm = false)
        {
            if (withDropdown)
            {
                int firstNameIndex = combBx_Borrower_First_Name_MemberSearch.SelectedIndex;
                int lastNameIndex = combBx_Borrower_Last_Name_MemberSearch.SelectedIndex;
                int genderIndex = combBx_Borrower_Gender_MemberSearch.SelectedIndex;

                fillBorrwerSearchFilters(firstNameIndex, lastNameIndex, genderIndex);
            }


            myComboBoxFilters.v_1_Borrower_First_Name = combBx_Borrower_First_Name_MemberSearch.SelectedItem.ToString();
            myComboBoxFilters.v_2_Borrower_Last_Name = combBx_Borrower_Last_Name_MemberSearch.SelectedItem.ToString();
            myComboBoxFilters.v_3_Borrower_Gender = combBx_Borrower_Gender_MemberSearch.SelectedItem.ToString();


            _MembersController.FillTable(dtGrdVw_MemberSearch, txtBx_MemberSearch.Text, myComboBoxFilters);

        }


        //DropdownChange
        public void event_DropdownChange()//HERE_EVENT
        {
            if (combBx_Borrower_Last_Name_MemberSearch.SelectedItem != null &&
                combBx_Borrower_Gender_MemberSearch.SelectedItem != null &&
                combBx_Borrower_First_Name_MemberSearch.SelectedItem != null)
            {
                GenerateMembersTable(false);
            }
        }

        //
        public void event_Click_Searh()
        {
            GenerateMembersTable(false);
        }

        public void event_refresh()
        {
            GenerateMembersTable();
        }


        // EVENT_HERE - btn_EditClick
        public void event_btn_Edit_Click()
        {
            int rowIndex = dtGrdVw_MemberSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_MemberSearch.Rows[rowIndex].Cells[DGV_BORROWER.Column_Names.col_0_ID_CONST].Value.ToString();
            updateMemberPopUP(id);
            event_refresh();
        }


        private DialogResult warning_Message(string msg, string caption)
        {
            return MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }


        // EVENT_HERE - btn_DeleteClick
        public void event_btn_Delete_Click()
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
                successDelete = _MembersController.deleteMember(int.Parse(id));
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

            event_refresh();
        }


        //
        public void event_dtGrdVw_BorrwerSearch_CellDoubleClick()
        {
            int rowIndex = dtGrdVw_MemberSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_MemberSearch.Rows[rowIndex].Cells[DGV_BORROWER.Column_Names.col_0_ID_CONST].Value.ToString();//"Column_Borrwer_ID"].Value.ToString();

            viewDetailsMembers(id);
        }


        private void viewDetailsMembers(string id)
        {
            MembersDetailPopUp detailPopup = new MembersDetailPopUp(id);
            detailPopup.ShowDialog();
        }

        private void updateMemberPopUP(string id)
        {
            MembersEditPopUp updateDetailPopUp = new MembersEditPopUp(id);
            updateDetailPopUp.ShowDialog();
        }














        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////







        

        
    }
}
