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

        private void btn_SearchBorrowers_Click(object sender, EventArgs e)
        {

            pnl_ContentBorrowers = myLayoutController.processThisPanel(pnl_ContentBorrowers);
            borrowersSearchLayoutForm = (BorrowersSearchLayoutForm)myLayoutController.proccessThisForm(borrowersSearchLayoutForm);

            pnl_ContentBorrowers.Controls.Add(borrowersSearchLayoutForm);
            pnl_ContentBorrowers.Tag = borrowersSearchLayoutForm;
            borrowersSearchLayoutForm.Show();

        }

        private void pnl_ContentBorrowers_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
