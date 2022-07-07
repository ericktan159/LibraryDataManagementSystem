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
    public partial class MainLayout : Form
    {

        MainLayoutController myLayoutController = new MainLayoutController();
        
        MembersLayoutForm membersLayoutForm = new MembersLayoutForm();
        BooksLayoutForm booksLayoutForm = new BooksLayoutForm();
        BorrowersLayOutForm borrowersLayOutForm = new BorrowersLayOutForm();
        LogsLayoutForm logsLayoutForm = new LogsLayoutForm();
        public MainLayout()
        {
            InitializeComponent();
        }

        private void MainLayout_Load(object sender, EventArgs e)
        {

        }

        public Panel  GetMainPanel()
        {
            return pnl_Main;
        }
        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Members_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(membersLayoutForm, this);
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(booksLayoutForm, this);
        }

        private void btn_Borrowers_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(borrowersLayOutForm, this);
        }

        private void btn_Logs_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(logsLayoutForm, this);
        }
    }
}
