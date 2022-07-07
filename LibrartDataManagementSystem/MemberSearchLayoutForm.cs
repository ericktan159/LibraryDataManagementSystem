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
            testDemolang();
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
            TriggeredBorrowLayoutForm triggeredBorrowLayoutForm = new TriggeredBorrowLayoutForm();

            triggeredBorrowLayoutForm.Show();
        }
    }
}
