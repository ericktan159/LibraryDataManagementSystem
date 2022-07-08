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
    public partial class BooksLayoutForm : Form
    {
        MainLayoutController myLayoutController = new MainLayoutController();

        BooksSearchLayoutFormcs booksSearchLayoutFormcs = new BooksSearchLayoutFormcs();
        BooksAddLayoutForm booksAddLayoutForm = new BooksAddLayoutForm();

        public BooksLayoutForm()
        {
            InitializeComponent();
        }

        private void btn_BrowseBooks_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(booksSearchLayoutFormcs, this);
        }

        private void btn_AddBooks_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(booksAddLayoutForm, this);
        }

        public Panel GetMainPanel()
        {
            return pnl_ContentBooks;
        }
    }
}
