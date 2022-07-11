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

namespace LibrartDataManagementSystem.Book_Forms
{
    public partial class BooksDetailPopUp : Form
    {
        private string _id;
        private Label[] _details;
        private BooksController _booksController = new BooksController();


        public BooksDetailPopUp(string id)
        {
            _id = id;
            InitializeComponent();

            _details = new Label[6] { labelTitle, labelAuthor, labelGenre, labelYearPublished,
            labelPublisher, labelQuantity };
        }

        private void BooksDetailPopUp_Load(object sender, EventArgs e)
        {
            string title = _booksController.GetBookTitle(_id);
            this.Text = title;

            _booksController.FillDetails(_details, _id);
        }
    }
}
