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
    public partial class BooksSearchLayoutFormcs : Form
    {
        public BooksSearchLayoutFormcs()
        {
            InitializeComponent();
        }

        private void BooksSearchLayoutFormcs_Load(object sender, EventArgs e)
        {
            // set all dropdownlist to "All"
            combBx_Book_Author.SelectedIndex = 0;
            combBx_Book_Genre.SelectedIndex = 0;
            combBx_Book_Year_Published.SelectedIndex = 0;
        }
    }
}
