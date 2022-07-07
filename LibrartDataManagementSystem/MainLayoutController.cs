using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrartDataManagementSystem
{
    class MainLayoutController
    {
        public void LoadForm(Form form, MainLayout originalForm)
        {
            if (originalForm.GetMainPanel().Controls.Count > 0)
            {
                originalForm.GetMainPanel().Controls.RemoveAt(0);
            }
            Form f = form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            originalForm.GetMainPanel().Controls.Add(f);
            originalForm.GetMainPanel().Tag = f;
            f.Show();
        }

        public Form proccessThisForm(Form myForm)
        {
            Form proccessedForm = myForm;
            proccessedForm.TopLevel = false;

            return proccessedForm;

        }

        public Panel processThisPanel(Panel myPanel)
        {
            if (myPanel.Controls.Count > 0)
            {
                myPanel.Controls.RemoveAt(0);
            }
            return myPanel;
        }
    }
}
