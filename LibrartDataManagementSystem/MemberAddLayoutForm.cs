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
        public MemberAddLayoutForm()
        {
            InitializeComponent();
        }

        private void btn_MemberAdd_Click(object sender, EventArgs e)
        {
            demodemolang();


        }

        private void demodemolang()
        {

            string Borrower_Last_Name = "Tan";
            string Borrower_First_Name = "Frederick";
            string Borrower_Middle_Name = "Bogtong";
            string Borrower_Address = "Marikina City";
            string Borrower_Contact_Number = "09123456789";
            int Borrower_Age = 25;
            string Borrower_Type_of_Valid_ID = "School ID";

            my_LDMS_DataBaseController.insert_To_tbl_borrower(Borrower_Last_Name, Borrower_First_Name, Borrower_Middle_Name, Borrower_Address, Borrower_Contact_Number, Borrower_Age, Borrower_Type_of_Valid_ID);

            MessageBox.Show("Gumana!!!");
        }

    }
}
