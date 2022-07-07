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

        private void btn_BrowseMembers_Click(object sender, EventArgs e)
        {
            pnl_ContentMembers = myLayoutController.processThisPanel(pnl_ContentMembers);
            memberSearchLayoutForm = (MemberSearchLayoutForm)myLayoutController.proccessThisForm(memberSearchLayoutForm);
            

            pnl_ContentMembers.Controls.Add(memberSearchLayoutForm);
            pnl_ContentMembers.Tag = memberSearchLayoutForm;
            memberSearchLayoutForm.Show();
        }

        private void btn_AddMembers_Click(object sender, EventArgs e)
        {
            pnl_ContentMembers = myLayoutController.processThisPanel(pnl_ContentMembers);
            memberAddLayoutForm = (MemberAddLayoutForm)myLayoutController.proccessThisForm(memberAddLayoutForm);


            pnl_ContentMembers.Controls.Add(memberAddLayoutForm);
            pnl_ContentMembers.Tag = memberAddLayoutForm;
            memberAddLayoutForm.Show();
        }
    }
}
