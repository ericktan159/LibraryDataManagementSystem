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


namespace LibrartDataManagementSystem
{
    public partial class MemberAddLayoutForm : Form
    {
        LDMS_DataBaseController my_LDMS_DataBaseController = new LDMS_DataBaseController();
        Info_TBL_BORR0WER myInfo_tbl_borrower = new Info_TBL_BORR0WER();
        LogController logController = new LogController();
        private MembersController _membersController = new MembersController();
        private TextBox[] inputs;
        private TextBox[] inputsWMname;
        
        public MemberAddLayoutForm()
        {
            InitializeComponent();

            combBx_Gender_MemberAddLayout.SelectedIndex = 0;
            dropdownValidID.SelectedIndex = 0;
        }

        private void MemberAddLayoutForm_Load(object sender, EventArgs e)
        {
            dtp_BirthDate_MemberAddLayout.MaxDate = DateTime.Now;
            dtp_BirthDate_MemberAddLayout.MinDate = DateTime.Now.AddYears(-100);
            inputs = new TextBox[4] {txtBx_FirstName_MemberAddLayout,
                txtBx_LastName_MemberAddLayout, txtBx_Address_MemberAddLayout,
                txtBx_ContactNumber_MemberAddLayout};
            inputsWMname = new TextBox[5] {txtBx_FirstName_MemberAddLayout, txtBx_MiddleName_MemberAddLayout,
                txtBx_LastName_MemberAddLayout, txtBx_Address_MemberAddLayout,
                txtBx_ContactNumber_MemberAddLayout};
        }

        /// <summary>
        /// add member
        /// </summary>
        private void btn_MemberAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dtp_BirthDate_MemberAddLayout.Value.ToString("MM-dd-yyyy"));
            if (_membersController.isInputComplete(inputs))
            {
                string prompt1;
                if (_membersController.CheckIfUserExist(txtBx_FirstName_MemberAddLayout.Text,
                    txtBx_MiddleName_MemberAddLayout.Text, txtBx_LastName_MemberAddLayout.Text,
                    dtp_BirthDate_MemberAddLayout.Value.ToString("MM-dd-yyyy")))
                {
                    prompt1 = "The account is Existing do you still wish to add this account?";
                }
                else
                {
                    prompt1 = "Do you wish to register this member?";
                }
                DialogResult dialogResult = MessageBox.Show(prompt1, "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //Console.WriteLine(dtp_BirthDate_MemberAddLayout.Value.ToString("MM-dd-yyyy"));
                    myInfo_tbl_borrower.Borrower_First_Name = txtBx_FirstName_MemberAddLayout.Text;
                    myInfo_tbl_borrower.Borrower_Middle_Name = txtBx_MiddleName_MemberAddLayout.Text;
                    myInfo_tbl_borrower.Borrower_Last_Name = txtBx_LastName_MemberAddLayout.Text;
                    myInfo_tbl_borrower.Borrower_Gender = combBx_Gender_MemberAddLayout.Text;
                    myInfo_tbl_borrower.Borrower_Address = txtBx_Address_MemberAddLayout.Text;
                    myInfo_tbl_borrower.Borrower_Contact_Number = txtBx_ContactNumber_MemberAddLayout.Text;
                    myInfo_tbl_borrower.Borrower_BirthDate = dtp_BirthDate_MemberAddLayout.Value.
                        ToString("MM-dd-yyyy");
                    myInfo_tbl_borrower.Borrower_Type_of_Valid_ID = dropdownValidID.Text;
                    _membersController.AddBorrowers(myInfo_tbl_borrower);

                    if (checkClear.Checked)
                    {
                        _membersController.ClearInputs(inputsWMname);
                        dropdownValidID.SelectedIndex = 0;
                    }

                    string id = _membersController.GetLastBorrowerID();
                    if (!logController.LogMember(id, 6))
                    {
                        MessageBox.Show("Can't log automatically, please log manually.");
                    }
                }
            }
        }

        /// <summary>
        /// accept only digit
        /// </summary>
        private void txtBx_ContactNumber_MemberAddLayout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _membersController.ClearInputs(inputsWMname);
            dropdownValidID.SelectedIndex = 0;
        }
    }
}
