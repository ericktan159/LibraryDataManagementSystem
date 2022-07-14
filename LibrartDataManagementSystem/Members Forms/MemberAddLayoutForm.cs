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
        Info_TBL_BORR0WER myInfo_tbl_borrower = new Info_TBL_BORR0WER();
        public MemberAddLayoutForm()
        {
            InitializeComponent();

            combBx_Gender_MemberAddLayout.SelectedIndex = 0;
        }
    }
}
