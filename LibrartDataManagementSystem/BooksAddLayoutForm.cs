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
    public partial class BooksAddLayoutForm : Form
    {
        LDMS_DataBaseController my_LDMS_DataBaseController = new LDMS_DataBaseController();


        public BooksAddLayoutForm()
        {
            InitializeComponent();
        }

        private void btn_BookAdd_Click(object sender, EventArgs e)
        {
            demodemolang();
        }
        private void demodemolang()
        {

            string Book_Tittle = "Physics";
            string Book_Author = "Einstein"; 
            string Book_Genre = "Scifi";
            string Book_Year_Published = DateTime.Now.ToString();//DateTime Book_Year_Published = DateTime.Now.GetDateTimeFormats();
            string Book_Publisher = "Dr. Tan";
            int Book_Number_Of_Quantity = 5;

            my_LDMS_DataBaseController.insert_To_tbl_book(Book_Tittle, Book_Author, Book_Genre, Book_Year_Published, Book_Publisher, Book_Number_Of_Quantity);
            
            MessageBox.Show("Gumana!!!");
        }
    }
}
