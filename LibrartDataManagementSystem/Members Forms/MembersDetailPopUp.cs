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
    public partial class MembersDetailPopUp : Form
    {

        MembersController myMembersController = new MembersController();

        private string _id;
        private int Borrower_ID;
        private Label[] _details;

        int N_Lbl = 6;

        public MembersDetailPopUp(string _Borrower_ID)
        {
            InitializeComponent();

            _id = _Borrower_ID;
            Borrower_ID = int.Parse(_Borrower_ID);

            //N_Lbl
            _details = new Label[6] {
                        lbl_123_Full_Name_MemberDetails,
                        lbl_4_Gender_MemberDetails,
                        lbl_5_Address_MemberDetails,
                        lbl_6_Contact_Number_MemberDetails,
                        lbl_7_BirthDate_MemberDetails,
                        lbl_8_Type_Valid_ID_MemberDetails
            };

        }

        private void MembersDetailPopUp_Load(object sender, EventArgs e)
        {
            string title = myMembersController.getFullName(Borrower_ID);
            this.Text = title;

            myMembersController.fill_Labels_TableDeatails(Borrower_ID.ToString(), _details);
        }

    }
}
