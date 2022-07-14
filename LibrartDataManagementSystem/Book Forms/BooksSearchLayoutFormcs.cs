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
using LibrartDataManagementSystem.Book_Forms;

namespace LibrartDataManagementSystem
{
    public partial class BooksSearchLayoutFormcs : Form
    {
        private BooksController _booksController = new BooksController();
        private LogController _logController = new LogController();

        public BooksSearchLayoutFormcs()
        {
            InitializeComponent();
        }

        private void fillBookSearchFilters(int authorIndex, int genreIndex, int yearIndex)
        {
            _booksController.FillDropdown(combBx_Book_Author, Info_TBL_BOOK.Const_Names.col_2_Book_Author_CONST);//"Book_Author");
            _booksController.FillDropdown(combBx_Book_Genre, Info_TBL_BOOK.Const_Names.col_3_Book_Genre_CONST);//"Book_Genre");
            _booksController.FillDropdown(combBx_Book_Year_Published, Info_TBL_BOOK.Const_Names.col_4_Book_Year_Published_CONST);//"Book_Year_Published");

            combBx_Book_Author.SelectedIndex = authorIndex;// 0;
            combBx_Book_Genre.SelectedIndex = genreIndex;//0;
            combBx_Book_Year_Published.SelectedIndex = yearIndex;//0;
        }

        private void BooksSearchLayoutFormcs_Load(object sender, EventArgs e)
        {
            // fill the dropdown with values
            /*
            _booksController.FillDropdown(combBx_Book_Author, "Book_Author");
            _booksController.FillDropdown(combBx_Book_Genre, "Book_Genre");
            _booksController.FillDropdown(combBx_Book_Year_Published, "Book_Year_Published");

            combBx_Book_Author.SelectedIndex = 0;
            combBx_Book_Genre.SelectedIndex = 0;
            combBx_Book_Year_Published.SelectedIndex = 0;
            //*/

            fillBookSearchFilters(0, 0, 0);

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

                fillBookSearchFilters(authorIndex, genreIndex, yearIndex);
                /*
                _booksController.FillDropdown(combBx_Book_Author, "Book_Author");
                _booksController.FillDropdown(combBx_Book_Genre, "Book_Genre");
                _booksController.FillDropdown(combBx_Book_Year_Published, "Book_Year_Published");

                combBx_Book_Author.SelectedIndex = authorIndex;
                combBx_Book_Genre.SelectedIndex = genreIndex;
                combBx_Book_Year_Published.SelectedIndex = yearIndex;
                //*/
            }

            _booksController.FillTable(
                dtGrdVw_BookSearch, txtBx_BookSearch.Text, combBx_Book_Author.SelectedItem.ToString(),
                combBx_Book_Genre.SelectedItem.ToString(), combBx_Book_Year_Published.SelectedItem.ToString());
            _booksController.FillQuantityColor(dtGrdVw_BookSearch);
        }
        /// <summary>
        /// when any of the dropdown change index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropdownChange(object sender, EventArgs e)
        {
            if (combBx_Book_Author.SelectedItem != null && combBx_Book_Genre.SelectedItem != null &&
                combBx_Book_Year_Published.SelectedItem != null)
            {
                GenerateTable(false);
            }
        }
        
        /// <summary>
        /// pop up a new form that you can edit the selected book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditBooks_Click(object sender, EventArgs e)
        {
            int rowIndex = dtGrdVw_BookSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_BookSearch.Rows[rowIndex].Cells["Column_Book_ID"].Value.ToString();

            BooksEditPopUp popUp = new BooksEditPopUp(id);
            popUp.ShowDialog();
            GenerateTable();
        }

        /// <summary>
        /// deleting the books
        /// </summary>
        private void btn_DeleteBooks_Click(object sender, EventArgs e)
        {
            int rowIndex = dtGrdVw_BookSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_BookSearch.Rows[rowIndex].Cells["Column_Book_ID"].Value.ToString();
            string name = dtGrdVw_BookSearch.Rows[rowIndex].Cells["Column_Book_Title"].Value.ToString();
            bool successDelete = false;

            if (int.Parse(_booksController.GetQuantity(id)) > 1)
            {
                string prompt1 = $"It looks like \"{name}\" has more than 1 quantity. \n" +
                    $"Do you wish to delete the book entirely? (By pressing \"No\" you'll just remove " +
                    $"some of its quantity.)";

                DialogResult result = MessageBox.Show(prompt1, "Confirm", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    successDelete = _booksController.DeleteBook(id);
                }
                else if (result == DialogResult.No)
                {
                    BooksEditPopUp editPopup = new BooksEditPopUp(id, true);
                    editPopup.ShowDialog();
                }
            }
            else
            {
                string prompt2 = $"Do you wish to delete \"{name}\"?";

                DialogResult result = MessageBox.Show(prompt2, "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    successDelete = _booksController.DeleteBook(id);
                }
            }

            if(successDelete)
            {
                MessageBox.Show($"{name} is successfully deleted!", "Success!");
                _logController.LogBook(id, 5);
            }
            GenerateTable();
        }

        private void dtGrdVw_BookSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtGrdVw_BookSearch.CurrentCellAddress.Y;
            string id = dtGrdVw_BookSearch.Rows[rowIndex].Cells["Column_Book_ID"].Value.ToString();

            BooksDetailPopUp detailPopup = new BooksDetailPopUp(id);
            detailPopup.ShowDialog();
        }
    }
}
