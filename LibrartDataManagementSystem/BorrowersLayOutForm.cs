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
    public partial class BorrowersLayOutForm : Form
    {
        MainLayoutController myLayoutController = new MainLayoutController();


        BorrowersSearchLayoutForm borrowersSearchLayoutForm = new BorrowersSearchLayoutForm();

        public BorrowersLayOutForm()
        {
            InitializeComponent();
        }

        private void BorrowersLayOutForm_Load(object sender, EventArgs e)
        {
            btn_SearchBorrowers.PerformClick();
        }

        private void btn_SearchBorrowers_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(borrowersSearchLayoutForm, this);
        }

        public Panel GetMainPanel()
        {
            return pnl_ContentBorrowers;
        }
    }
}
