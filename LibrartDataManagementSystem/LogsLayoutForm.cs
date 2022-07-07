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

        private void btn_ViewLogs_Click(object sender, EventArgs e)
        {

            pnl_ContentLogs = myLayoutController.processThisPanel(pnl_ContentLogs);
            logsSearchLayoutForm = (LogsSearchLayoutForm)myLayoutController.proccessThisForm(logsSearchLayoutForm);
            pnl_ContentLogs.Controls.Add(logsSearchLayoutForm);
            pnl_ContentLogs.Tag = logsSearchLayoutForm;
            logsSearchLayoutForm.Show();

        }

        private void pnl_ContentLogs_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
