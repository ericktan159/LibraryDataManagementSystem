using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrartDataManagementSystem.Scripts
{
    class BooksController
    {
        LDMS_DataBaseController dbController = new LDMS_DataBaseController();
        public BooksAddLayoutForm addForm;
        public BooksSearchLayoutFormcs searchForm;

        /// <summary>
        /// Check if the input is complete
        /// </summary>
        /// <param name="inputs">the list of input to check</param>
        /// <returns>return true if it is complete</returns>
        public bool isInputComplete(TextBox[] inputs)
        {
            foreach (TextBox input in inputs)
            {
                if(input.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Inputs are incomplete");
                    return false;
                }
            }
            return true;
        }
    }
}
