﻿using System;
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
            // set all dropdownlist to "All"
            combBx_Book_Author.SelectedIndex = 0;
            combBx_Book_Genre.SelectedIndex = 0;
            combBx_Book_Year_Published.SelectedIndex = 0;

            // fill the table
            _booksController.FillTable(
                dtGrdVw_BookSearch, txtBx_BookSearch.Text, combBx_Book_Author.SelectedItem.ToString(),
                combBx_Book_Genre.SelectedItem.ToString(), combBx_Book_Year_Published.SelectedItem.ToString());
        }

        //
        private void btn_Book_Search_Click(object sender, EventArgs e)
        {
            _booksController.FillTable(
                dtGrdVw_BookSearch, txtBx_BookSearch.Text, combBx_Book_Author.SelectedItem.ToString(),
                combBx_Book_Genre.SelectedItem.ToString(), combBx_Book_Year_Published.SelectedItem.ToString());
        }
    }
}
