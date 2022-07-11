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
    public partial class MemberSearchLayoutForm : Form
    {

        List<List<string>> demoListOfListOfString;

        LDMS_DataBaseController myLDMS_DataBaseController = new LDMS_DataBaseController();
            
                
        public MemberSearchLayoutForm()
        {
            InitializeComponent();
        }
           
        private void dtGrdVw_MemberSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void MemberSearchLayoutForm_Load(object sender, EventArgs e)
        {
            //demoLang_select_ALL_Form_tbl_borrower();
            testDemolang();
        }


        private void demoLang_select_ALL_Form_tbl_borrower()
        {
            List<List<string>> selectItems_2DList = new List<List<string>>();

            selectItems_2DList = myLDMS_DataBaseController.select_ALL_Form_tbl_borrower();


            dtGrdVw_MemberSearch.Rows.Clear();

            /*
            foreach (List<string> rowIinfos in selectItems_2DList)
            {
                int outerIndex = dtGrdVw_MemberSearch.Rows.Add();
                int innerIndex = 0;

                /*
                foreach (string info in rowIinfos)
                {
                    if(innerIndex < (rowIinfos.Count-2))
                    {
                        dtGrdVw_MemberSearch.Rows[outerIndex].Cells[innerIndex].Value = info;
                        innerIndex++;
                    }
                    
                }
                
                
                /*
                for (int i = 1; i < (rowIinfos.Count-1); i++)
                {
                    dtGrdVw_MemberSearch.Rows[outerIndex].Cells[i].Value = rowIinfos[i];

                }
                /////
            }
            //*/
            //*
            string msgFormat = "";

            foreach (List<string> row in selectItems_2DList)
            {
                foreach (string item in row)
                {
                    msgFormat += item + "\t";
                }
                msgFormat += "\n";
            }

            MessageBox.Show(msgFormat);
            //*/
        }



        private void testDemolang()
        {
            dtGrdVw_MemberSearch.Rows.Clear();

            demoListOfListOfString = generate2DListString();

            foreach (List<string> infos in demoListOfListOfString)
            {
                int outerIndex = dtGrdVw_MemberSearch.Rows.Add();
                int innerIndex = 0;
                foreach (string info in infos)
                {
                    dtGrdVw_MemberSearch.Rows[outerIndex].Cells[innerIndex].Value = info;
                    innerIndex++;
                }
            }


        }

        private List<List<string>> generate2DListString()
        {
            List<List<string>> list2dString = new List<List<string>>();
            List<String> rowListString = new List<string>();

            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");
            rowListString.Add("HEllo World!!");

            list2dString.Add(rowListString);

            return list2dString;
        }

        private void btn_Borrow_Btn_Click(object sender, EventArgs e)
        {
            TransactionBorrowLayoutForm triggeredBorrowLayoutForm = new TransactionBorrowLayoutForm();

            triggeredBorrowLayoutForm.Show();
        }
    }
}
