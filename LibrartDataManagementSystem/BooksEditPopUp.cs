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
    public partial class BooksEditPopUp : Form
    {
        private string _id;
        public BooksEditPopUp(string bookID)
        {
            _id = bookID;
            InitializeComponent();
        }

        private void BooksEditPopUp_Load(object sender, EventArgs e)
        {
            txtBx_BookTitle_BookAdd.Text = _id;
        }
    }
}
