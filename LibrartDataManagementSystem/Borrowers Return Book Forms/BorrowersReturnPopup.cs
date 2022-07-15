using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrartDataManagementSystem.Scripts;

namespace LibrartDataManagementSystem.Borrowers_Return_Book_Forms
{
    public partial class BorrowersReturnPopup : Form
    {
        private BorrowersController _borrowersController = new BorrowersController();
        private string _id;
        public BorrowersReturnPopup(string id)
        {
            _id = id;
            InitializeComponent();
        }

        private void BorrowersReturnPopup_Load(object sender, EventArgs e)
        {
            quantityCount.Maximum = _borrowersController.GetQuantity(_id);
        }
    }
}
