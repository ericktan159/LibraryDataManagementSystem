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
    public partial class BorrowersDetailPopup : Form
    {
        private string _id;
        private BorrowersController _borrowersController = new BorrowersController();

        public BorrowersDetailPopup(string id)
        {
            _id = id;
            InitializeComponent();
        }

        private void BorrowersDetailPopup_Load(object sender, EventArgs e)
        {
            _borrowersController.FillDetails(_id, transacID, borrowerID, borrowerName, bookID, bookTitle,
                dateBorrowed, dueDate, dueStatus, quantity, dateReturned);
        }
    }
}
