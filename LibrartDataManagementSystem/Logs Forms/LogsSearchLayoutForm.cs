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
    public partial class LogsSearchLayoutForm : Form
    {
        private CheckBox[] _checkBoxes;
        private LogController _logController = new LogController();

        public LogsSearchLayoutForm()
        {
            InitializeComponent();
            _checkBoxes = new CheckBox[8] { checkBookAdd, checkBookDelete, checkBookUpdate, checkBorrow,
                checkMemberAdd, checkMemberDelete, checkMemberUpdate, checkReturn};
        }

        private void LogsSearchLayoutForm_Load(object sender, EventArgs e)
        {
            _logController.FillTable(logTable, _checkBoxes);
        }

        private void btn_Filter_LogsViews_Click(object sender, EventArgs e)
        {
            _logController.FillTable(logTable, _checkBoxes);
        }

        /// <summary>
        /// clear the checkboxes
        /// </summary>
        private void buttonClearCheckBox_Click(object sender, EventArgs e)
        {
            foreach (var item in _checkBoxes)
            {
                item.Checked = false;
            }
            _logController.FillTable(logTable, _checkBoxes);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            _logController.FillTable(logTable, _checkBoxes);
        }
    }
}
