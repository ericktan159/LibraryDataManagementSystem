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

namespace LibrartDataManagementSystem.Book_Forms
{
    public partial class BooksQuantityPopUp : Form
    {
        private string _id;
        BooksController _booksController = new BooksController();

        public BooksQuantityPopUp(string id)
        {
            _id = id;
            InitializeComponent();
        }

        private void BooksQuantityPopUp_Load(object sender, EventArgs e)
        {
            string bookTitle = _booksController.GetBookTitle(_id);
            labelTitle.Text = $"ID: {_id}; {bookTitle}";
        }
    }
}
