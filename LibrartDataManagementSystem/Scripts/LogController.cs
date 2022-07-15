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
        private LDMS_DataBaseController _dbController = new LDMS_DataBaseController();
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

            if(_dbController.insert_DBMethod(query))
            {
                return true;
            }
            return false;
        }

        public bool LogMember(string id, int type)
        {
            string description = "";
            string query = "";
            switch (type)
            {
                case 6:
                    description = $"Registered New Member id: {id}";
                    break;
                case 7:
                    description = $"Updated Member id: {id}";
                    break;
                case 8:
                    description = $"Deleted Member id: {id}";
                    break;
                default:
                    return false;
            }
            query = $"INSERT INTO `tbl_logs`(`log_description`, `log_type`) " +
                $"VALUES ('{description}','{type}')";

            if (_dbController.insert_DBMethod(query))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// fill the table of log form
        /// </summary>
        /// <param name="table">reference of table</param>
        /// <param name="checkboxes">refences of checkboxes filter</param>
        public void FillTable(DataGridView table, CheckBox[] checkboxes)
        {
            table.Rows.Clear();
            string query = FillQuery(checkboxes);
            List<List<string>> logDetails = _dbController.select_DBMethod_return_2DList_Table_Records(query);

            foreach (List<string> logDetail in logDetails)
            {
                int row = table.Rows.Add();
                table.Rows[row].Cells["Column_Logs_Description"].Value = logDetail[1];
                table.Rows[row].Cells["Column_Log_Type"].Value = GetTypeDescription(logDetail[2]);
                table.Rows[row].Cells["Column_Log_Date"].Value = logDetail[3];
            }
        }

        /// <summary>
        /// get a string description of a log type
        /// </summary>
        /// <param name="id">id of the log type</param>
        /// <returns>string value of log type</returns>
        private string GetTypeDescription(string id)
        {
            string query = $"SELECT * FROM `tbl_log_types` WHERE `id` = {id}";
            List<List<string>> results = _dbController.select_DBMethod_return_2DList_Table_Records(query);
            return results[0][1];
        }

        /// <summary>
        /// fill the needed query for filtering the table
        /// </summary>
        /// <param name="checkbox">reference of a checkbox</param>
        /// <returns>the query string</returns>
        public string FillQuery(CheckBox[] checkbox)
        {
            string query = "SELECT * FROM `tbl_logs` ";
            bool haveWhere = false;
            bool haveValues = false;
            foreach (CheckBox item in checkbox)
            {
                if(item.Checked)
                {
                    if(!haveWhere)
                    {
                        query += "WHERE `log_type` in (";
                        haveWhere = true;
                    }
                    if(item.Text == "Borrow")
                    {
                        if (haveValues)
                        {
                            query += ", 1";
                        }
                        else
                        {
                            haveValues = true;
                            query += "1";
                        }
                    }
                    else if(item.Text == "Return")
                    {
                        if(haveValues)
                        {
                            query += ", 2";
                        }
                        else
                        {
                            haveValues = true;
                            query += "2";
                        }
                    }
                    else if (item.Text == "Book Add")
                    {
                        if (haveValues)
                        {
                            query += ", 3";
                        }
                        else
                        {
                            haveValues = true;
                            query += "3";
                        }
                    }
                    else if (item.Text == "Book Update")
                    {
                        if (haveValues)
                        {
                            query += ", 4";
                        }
                        else
                        {
                            haveValues = true;
                            query += "4";
                        }
                    }
                    else if (item.Text == "Book Delete")
                    {
                        if (haveValues)
                        {
                            query += ", 5";
                        }
                        else
                        {
                            haveValues = true;
                            query += "5";
                        }
                    }
                    else if (item.Text == "Member Add")
                    {
                        if (haveValues)
                        {
                            query += ", 6";
                        }
                        else
                        {
                            haveValues = true;
                            query += "6";
                        }
                    }
                    else if (item.Text == "Member Update")
                    {
                        if (haveValues)
                        {
                            query += ", 7";
                        }
                        else
                        {
                            haveValues = true;
                            query += "7";
                        }
                    }
                    else if (item.Text == "Member Delete")
                    {
                        if (haveValues)
                        {
                            query += ", 8";
                        }
                        else
                        {
                            haveValues = true;
                            query += "8";
                        }
                    }
                }
            }
            if(haveWhere)
            {
                query += ")";
            }
            return query;
        }
    }
}
