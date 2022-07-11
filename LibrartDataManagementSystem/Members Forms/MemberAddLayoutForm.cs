using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibrartDataManagementSystem
{
    public partial class MemberAddLayoutForm : Form
    {
        LDMS_DataBaseController my_LDMS_DataBaseController = new LDMS_DataBaseController();
        Info_tbl_borrower myInfo_tbl_borrower = new Info_tbl_borrower();
        public MemberAddLayoutForm()
        {
            InitializeComponent();

            combBx_Gender_MemberAddLayout.Items.Clear();
            combBx_Gender_MemberAddLayout.Items.Add("Male");
            combBx_Gender_MemberAddLayout.Items.Add("Female");


        }

        private void btn_MemberAdd_Click(object sender, EventArgs e)
        {

            
            demodemolang();


        }

        private void demodemolang()
        {

            //string Borrower_First_Name
            myInfo_tbl_borrower.Borrower_First_Name = txtBx_FirstName_MemberAddLayout.Text; //"Frederick";
            //string Borrower_Middle_Name
            myInfo_tbl_borrower.Borrower_Middle_Name = txtBx_MiddleName_MemberAddLayout.Text;//"B.";
            //string Borrower_Last_Name
            myInfo_tbl_borrower.Borrower_Last_Name = txtBx_LastName_MemberAddLayout.Text;//"Tan";
            //string Borrower_Gender
            myInfo_tbl_borrower.Borrower_Gender = combBx_Gender_MemberAddLayout.SelectedItem.ToString();
            //string Borrower_Address
            myInfo_tbl_borrower.Borrower_Address = txtBx_Address_MemberAddLayout.Text;
            //string Borrower_Contact_Number
            myInfo_tbl_borrower.Borrower_Contact_Number = txtBx_ContactNumber_MemberAddLayout.Text;
            //string Borrower_BirthDate
            myInfo_tbl_borrower.Borrower_BirthDate = dtp_BirthDate_MemberAddLayout.Value.ToString();//DateTime.Now.ToString();
            //string Borrower_Type_of_Valid_ID
            myInfo_tbl_borrower.Borrower_Type_of_Valid_ID = txtBx_TypeValidID_MemberAddLayout.Text;
            
            
            

            /*
            MessageBox.Show(Borrower_First_Name + "\n" +
            Borrower_Middle_Name + "\n" +
            Borrower_Last_Name + "\n" +
            Borrower_Gender + "\n" +
            Borrower_Address + "\n" +
            Borrower_Contact_Number + "\n" +
            Borrower_BirthDate + "\n" +
            Borrower_Type_of_Valid_ID 

            );
            */

            my_LDMS_DataBaseController.insert_To_tbl_borrower(myInfo_tbl_borrower);
                //(Borrower_First_Name, Borrower_Middle_Name, Borrower_Last_Name, Borrower_Gender, Borrower_Address, Borrower_Contact_Number, Borrower_BirthDate , Borrower_Type_of_Valid_ID);

            MessageBox.Show("Gumana!!!");

            
        }

        private void testesing()
        {
            if (my_LDMS_DataBaseController.is_Book_ID_Exist(2))
            {
                MessageBox.Show("Book Exist");
            }
            else
            {
                MessageBox.Show("Book Not Exist");
            }

            if (my_LDMS_DataBaseController.is_Borrower_ID_Exist(7))
            {
                MessageBox.Show("Member Exist");
            }
            else
            {
                MessageBox.Show("Member Not Exist");
            }

        }

        private void MemberAddLayoutForm_Load(object sender, EventArgs e)
        {

            testesing();
        }
    }
}
