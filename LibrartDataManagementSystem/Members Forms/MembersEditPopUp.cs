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


namespace LibrartDataManagementSystem.Members_Forms
{
    public partial class MembersEditPopUp : Form
    {


        private MembersController myMembersController = new MembersController();
        private LogController _logController = new LogController();
        private Info_TBL_BORR0WER tbl_Infos = new Info_TBL_BORR0WER();


        private TextBox[] _inputs;
        My_Inputs_Member_Info myInputMemberInfo = new My_Inputs_Member_Info();


        private string _id;
        private int Borrower_ID;
        private int n_TxtBx = 5;

        public MembersEditPopUp(string _Borrower_ID)
        {
            InitializeComponent();

            _id = _Borrower_ID;
            Borrower_ID = int.Parse(_Borrower_ID);
 
            //n_TxtB
            _inputs = new TextBox[5] {
                    txtBx_FirstNamel_MembersEdit,
                    txtBx_Middle_Name_MembersEdit,
                    txtBx_LastNamel_MembersEdit,
                    txtBx_Address_MembersEdit,
                    txtBx_ContactNumber_MembersEdit
                    
            };
        }


        private void MembersEditPopUp_Load(object sender, EventArgs e)
        {
            event_FormLoad();
        }
        private void buttonUpdatel_MembersEdit_Click(object sender, EventArgs e)
        {
            event_Update_Click();
        }

        private void event_FormLoad()
        {
            //myMembersController.init_GenderChoice_ComboBox(combBx_Gender_MembersEdit);
            Enum_CONST_Gender.set_ComboBox_Items(combBx_Gender_MembersEdit);
            Enum_CONST_Type_Valid_ID.set_ComboBox_Items(combBx_TypeValidID__MembersEdit);

            myInputMemberInfo.input_1_txtBx_Borrower_First_Name = txtBx_FirstNamel_MembersEdit;
            myInputMemberInfo.input_2_txtBx_Borrower_Middle_Name = txtBx_Middle_Name_MembersEdit;
            myInputMemberInfo.input_3_txtBx_Borrower_Last_Name = txtBx_LastNamel_MembersEdit;
            myInputMemberInfo.input_4_combBx_Borrower_Gender = combBx_Gender_MembersEdit;
            myInputMemberInfo.input_5_txtBx_Borrower_Address = txtBx_Address_MembersEdit;
            myInputMemberInfo.input_6_txtBx_Borrower_Contact_Number = txtBx_ContactNumber_MembersEdit;
            myInputMemberInfo.input_7_dtp_Borrower_BirthDate = dtp_BirthDate__MembersEdit;
            myInputMemberInfo.input_8_combBx_Borrower_Type_of_Valid_ID = combBx_TypeValidID__MembersEdit;

            myMembersController.fill_Inputs_TableDeatails(Borrower_ID.ToString(), myInputMemberInfo);
        }

        private void event_Update_Click()
        {
            string prompt = "Do you wish to update this Member?";
            bool success = false;
            

            if (myMembersController.isInputComplete(_inputs))
            {
                if (MessageBox.Show(prompt, "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    /*
                    tbl_Infos.Borrower_First_Name = txtBx_FirstNamel_MembersEdit.Text;
                    tbl_Infos.Borrower_Middle_Name = txtBx_Middle_Name_MembersEdit.Text;
                    tbl_Infos.Borrower_Last_Name = txtBx_LastNamel_MembersEdit.Text;
                    tbl_Infos.Borrower_Gender = combBx_Gender_MembersEdit.SelectedItem.ToString();
                    tbl_Infos.Borrower_Address = txtBx_Address_MembersEdit.Text;
                    tbl_Infos.Borrower_Contact_Number = txtBx_ContactNumber_MembersEdit.Text;
                    tbl_Infos.Borrower_BirthDate = dtp_BirthDate__MembersEdit.Value.ToString("MM-dd-yyyy"); 
                    tbl_Infos.Borrower_Type_of_Valid_ID = txtBx_TypeValidID__MembersEdit.Text;
                    //*/
            


                    tbl_Infos = My_Inputs_Member_Info.convert_Inputs_To_Info_TBL_BORR0WER(txtBx_FirstNamel_MembersEdit,
                                                                                txtBx_Middle_Name_MembersEdit,
                                                                                txtBx_LastNamel_MembersEdit,
                                                                                combBx_Gender_MembersEdit,
                                                                                txtBx_Address_MembersEdit,
                                                                                txtBx_ContactNumber_MembersEdit,
                                                                                dtp_BirthDate__MembersEdit,
                                                                                combBx_TypeValidID__MembersEdit);

                    success = myMembersController.UpdateBorrowers(Borrower_ID, tbl_Infos);
                    if (success)
                    {
                        MessageBox.Show("Successfully Updated!", "Success!");
                    }
                    else
                    {
                        MessageBox.Show("NOT Successfully Updated!", "Failed!");
                    }


                }
            }
            else
            {
                MessageBox.Show("Inomplete Inputs! please complete your inputs first...");
            }
            
            this.Close();
        }

        private void buttonCancel_MembersEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
