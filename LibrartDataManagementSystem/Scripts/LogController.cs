using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LibrartDataManagementSystem.Scripts
{
    class LogController
    {
        private LDMS_DataBaseController _databaseController = new LDMS_DataBaseController();
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        /// <summary>
        /// Logs the books event
        /// </summary>
        /// <param name="textBox">Textbox of Title</param>
        /// <param name="type">reference of what type of events happens</param>
        /// <returns>true if success</returns>
        public bool LogBook(string id, int type)
        {
            string description = "";
            string query = "";
            switch(type)
            {
                case 3:
                    description = $"Added new book with the id: {id}";
                    break;
                case 4:
                    description = $"Updated book with the id: {id}";
                    break;
                case 5:
                    description = $"Deleted book with the id: {id}";
                    break;
                default:
                    return false;
            }
            query = $"INSERT INTO `tbl_logs`(`log_description`, `log_type`) " +
                $"VALUES ('{description}','{type}')";

            if(_databaseController.insert_DBMethod(query))
            {
                return true;
            }
            return false;
        }

        //public void FillTable(DataGridView table, string type, string,)
        //{
        //    table.Rows.Clear();

        //}
    }
}
