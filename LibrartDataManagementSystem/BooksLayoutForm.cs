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
        private string _currentContent = "search";

        public BooksLayoutForm()
        {
            InitializeComponent();
        }

        private void BooksLayoutForm_Load(object sender, EventArgs e)
        {
            if (_currentContent == "search")
            {
                btn_BrowseBooks.PerformClick();
            }
            else
            {
                btn_BrowseBooks.PerformClick();
            }
        }

        /// <summary>
        /// closes the 
        /// </summary>
        private void btn_BrowseBooks_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(booksSearchLayoutFormcs, this);
            _currentContent = "search";
        }

        private void btn_AddBooks_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(booksAddLayoutForm, this);
            _currentContent = "add";
        }

        public Panel GetMainPanel()
        {
            return pnl_ContentBooks;
        }
    }
}
