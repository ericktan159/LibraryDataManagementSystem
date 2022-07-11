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
    public partial class LogsLayoutForm : Form
    {
        MainLayoutController myLayoutController = new MainLayoutController();

        LogsSearchLayoutForm logsSearchLayoutForm = new  LogsSearchLayoutForm();
        public LogsLayoutForm()
        {
            InitializeComponent();
        }

        private void LogsLayoutForm_Load(object sender, EventArgs e)
        {
            btn_ViewLogs.PerformClick();
        }

        private void btn_ViewLogs_Click(object sender, EventArgs e)
        {
            myLayoutController.LoadForm(logsSearchLayoutForm, this);
        }

        public Panel GetMainPanel()
        {
            return pnl_ContentLogs;
        }
    }
}
