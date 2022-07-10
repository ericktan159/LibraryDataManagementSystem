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

namespace LibrartDataManagementSystem
{
    public partial class BooksSearchLayoutFormcs : Form
    {
        private BooksController _booksController = new BooksController();

        public BooksSearchLayoutFormcs()
        {
            InitializeComponent();
        }

        private void BooksSearchLayoutFormcs_Load(object sender, EventArgs e)
        {
            // fill the dropdown with values
            _booksController.FillDropdown(combBx_Book_Author, "Book_Author");
            _booksController.FillDropdown(combBx_Book_Genre, "Book_Genre");
            _booksController.FillDropdown(combBx_Book_Year_Published, "Book_Year_Published");

            combBx_Book_Author.SelectedIndex = 0;
            combBx_Book_Genre.SelectedIndex = 0;
            combBx_Book_Year_Published.SelectedIndex = 0;

            // fill the table
            _booksController.FillTable(
                dtGrdVw_BookSearch, txtBx_BookSearch.Text, combBx_Book_Author.SelectedItem.ToString(),
                combBx_Book_Genre.SelectedItem.ToString(), combBx_Book_Year_Published.SelectedItem.ToString());
            _booksController.FillQuantityColor(dtGrdVw_BookSearch);
        }

        //
        private void btn_Book_Search_Click(object sender, EventArgs e)
        {
            GenerateTable(false);
        }

        private void combBx_Book_Author_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combBx_Book_Author.SelectedItem != null && combBx_Book_Genre.SelectedItem != null &&
                combBx_Book_Year_Published.SelectedItem != null)
            {
                GenerateTable(false);
            }
        }

        private void combBx_Book_Genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combBx_Book_Author.SelectedItem != null && combBx_Book_Genre.SelectedItem != null &&
                combBx_Book_Year_Published.SelectedItem != null)
            {
                GenerateTable(false);
            }
        }

        private void combBx_Book_Year_Published_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combBx_Book_Author.SelectedItem != null && combBx_Book_Genre.SelectedItem != null &&
                combBx_Book_Year_Published.SelectedItem != null)
            {
                GenerateTable(false);
            }
        }

        /// <summary>
        /// refresh the table
        /// </summary>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GenerateTable();
        }

        /// <summary>
        /// Generate table and dropdown
        /// </summary>
        /// <param name="withDropdown">generate dropdown list if true</param>
        public void GenerateTable(bool withDropdown = true, bool fromOtherForm = false)
        {
            if (withDropdown)
            {
                int authorIndex = combBx_Book_Author.SelectedIndex;
                int genreIndex = combBx_Book_Genre.SelectedIndex;
                int yearIndex = combBx_Book_Year_Published.SelectedIndex;
                _booksController.FillDropdown(combBx_Book_Author, "Book_Author");
                _booksController.FillDropdown(combBx_Book_Genre, "Book_Genre");
                _booksController.FillDropdown(combBx_Book_Year_Published, "Book_Year_Published");

                combBx_Book_Author.SelectedIndex = authorIndex;
                combBx_Book_Genre.SelectedIndex = genreIndex;
                combBx_Book_Year_Published.SelectedIndex = yearIndex;
            }

            _booksController.FillTable(
                dtGrdVw_BookSearch, txtBx_BookSearch.Text, combBx_Book_Author.SelectedItem.ToString(),
                combBx_Book_Genre.SelectedItem.ToString(), combBx_Book_Year_Published.SelectedItem.ToString());
            _booksController.FillQuantityColor(dtGrdVw_BookSearch);
        }

        /// <summary>
        /// pop up a new form that you can edit the selected book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditBooks_Click(object sender, EventArgs e)
        {
            // check if the selected row is multiple then cancel the operation
            int rowIndex = dtGrdVw_BookSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_BookSearch.Rows[rowIndex].Cells["Column_Book_ID"].Value.ToString();

            BooksEditPopUp popUp = new BooksEditPopUp(id);
            popUp.ShowDialog();
            GenerateTable();
        }
    }
}
