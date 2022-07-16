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
        /// <summary>
        /// load form for main layout
        /// </summary>
        /// <param name="form">form of the layout we will show</param>
        /// <param name="originalForm">the mainlayout form</param>
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

        /// <summary>
        /// loadform for books
        /// </summary>
        /// <param name="form">content of what we want to use</param>
        /// <param name="originalForm">the booklayoutform</param>
        public void LoadForm(Form form, BooksLayoutForm originalForm)
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

        /// <summary>
        /// loadform for Members
        /// </summary>
        /// <param name="form">content form</param>
        /// <param name="originalForm">membersearchlayoutform</param>
        public void LoadForm(Form form, MembersLayoutForm originalForm)
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
        /// <summary>
        /// loadform for borrowers
        /// </summary>
        /// <param name="form">content form</param>
        /// <param name="originalForm">borrowers layout form</param>
        public void LoadForm(Form form, BorrowersLayOutForm originalForm)
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

        /// <summary>
        /// loadform for logs
        /// </summary>
        /// <param name="form"></param>
        /// <param name="originalForm"></param>
        public void LoadForm(Form form, LogsLayoutForm originalForm)
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

        /// <summary>
        /// will check if the form is open
        /// </summary>
        /// <param name="formType">what form to check</param>
        /// <returns>return true if the form is open</returns>
        public bool IsFormOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().Any(openForm => openForm.GetType() == formType);
        }

        ////////////
    }
}
