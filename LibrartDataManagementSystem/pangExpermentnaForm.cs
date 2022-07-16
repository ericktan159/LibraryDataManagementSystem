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
    public partial class pangExpermentnaForm : Form
    {
        public pangExpermentnaForm()
        {
            InitializeComponent();
        }

        private void pangExpermentnaForm_Load(object sender, EventArgs e)
        {
            demotest();
        }

        private void exitAgad()
        {
            this.Close();
        }
        private void demotest()
        {
            Enum_CONST_Type_Valid_ID.set_ComboBox_Items(comboBox1);

            exitAgad();
        }
    }
}
