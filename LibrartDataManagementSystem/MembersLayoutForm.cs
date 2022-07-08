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
    public partial class MembersLayoutForm : Form
    {
        MainLayoutController myLayoutController = new MainLayoutController();
        MemberSearchLayoutForm memberSearchLayoutForm = new MemberSearchLayoutForm();
        MemberAddLayoutForm memberAddLayoutForm = new MemberAddLayoutForm();

        public MembersLayoutForm()
        {
            InitializeComponent();
        }
        private void MembersLayoutForm_Load(object sender, EventArgs e)
        {
            btn_BrowseMembers.PerformClick();
        }

        private void btn_BrowseMembers_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(memberSearchLayoutForm, this);
        }

        private void btn_AddMembers_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(memberAddLayoutForm, this);
        }
        public Panel GetMainPanel()
        {
            return pnl_ContentMembers;
        }
    }
}
