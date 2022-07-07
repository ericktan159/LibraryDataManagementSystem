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
            pnl_ContentBooks = myLayoutController.processThisPanel(pnl_ContentBooks);
            booksSearchLayoutFormcs = (BooksSearchLayoutFormcs)myLayoutController.proccessThisForm(booksSearchLayoutFormcs);

            pnl_ContentBooks.Controls.Add(booksSearchLayoutFormcs);
            pnl_ContentBooks.Tag = booksSearchLayoutFormcs;
            booksSearchLayoutFormcs.Show();
        }

        private void btn_AddBooks_Click(object sender, EventArgs e)
        {
            pnl_ContentBooks = myLayoutController.processThisPanel(pnl_ContentBooks);
            booksAddLayoutForm = (BooksAddLayoutForm)myLayoutController.proccessThisForm(booksAddLayoutForm);

            pnl_ContentBooks.Controls.Add(booksAddLayoutForm);
            pnl_ContentBooks.Tag = booksAddLayoutForm;
            booksAddLayoutForm.Show();
        }
    }
}
