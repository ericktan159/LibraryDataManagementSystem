using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LibrartDataManagementSystem
{
    class LDMS_DataBaseController
    {
        string ConnectString = "datasource = localhost; username = root; password=; database = library_data_management_system;";//databasesample;";
        MySqlConnection connectDB;
        MySqlCommand cmd;
        MySqlDataAdapter da;

        public DataTable dt;
        int result;
        string sqlStrCommand;

        //*

        public void insertRecordtoTable(string insert_SQL_StateMent_For_Table_)
        {
            /*
            string sqlStrCommand = "Insert into main (Name, age, address, Gender, isTraveled, isCloseContact, symptomsList, celNumber, eMailAddress) values " +
                    "('" + myCTInfo.name + "', " + myCTInfo.age + ", '" + myCTInfo.address + "', '" + myCTInfo.gender + "', '" + myCTInfo.isTraveledStr + "', '" + myCTInfo.isClosedContact +
                    "', '" + myCTInfo.symptomList + "', '" + myCTInfo.cellNumber + "', '" + myCTInfo.eMail + "')";

            */

            string msg_false = "Failure!!!";
            string msg_true = "Succes!!";

            connectDB = new MySqlConnection(ConnectString);

            try
            {
                connectDB.Open();
                cmd = new MySqlCommand(insert_SQL_StateMent_For_Table_, connectDB);
                //cmd.Connection = connectDB;
                //cmd.CommandText = sqlStrCommand;
                result = cmd.ExecuteNonQuery();

                /*
                if (result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                }
                //*/

                //MessageBox.Show("Succes!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Failed! " + e.Message);
            }
            finally
            {
                connectDB.Close();
            }

            //sqlCommandDB(sqlStrCommand);

        }
        //*/    



        public string sql__StateMent_For_Table_Borrower()
        {

            return "";

        }




        /*
        /// <summary>
        /// Get all data in the database
        /// </summary>
        /// <param name="date">select specific date to check</param>
        /// <returns>return data on the specific date if date is null return all data</returns>
        public List<List<string>> GetAll(string date = null)
        {
            string sqlStrCommand;
            connectDB = new MySqlConnection(ConnectString);
            if (date != null)
            {
                sqlStrCommand = $"Select * From main where time REGEXP '{date}.*'";
            }
            else
            {
                sqlStrCommand = "Select * From main";
            }
            List<List<string>> myCTInfos = new List<List<string>>();
            try
            {
                connectDB.Open();
                cmd = new MySqlCommand(sqlStrCommand, connectDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    myCTInfos.Add(new List<string>{
                        reader.GetValue(1).ToString(),
                        reader.GetValue(2).ToString(),
                        reader.GetValue(3).ToString(),
                        reader.GetValue(4).ToString(),
                        reader.GetValue(5).ToString(),
                        reader.GetValue(6).ToString(),
                        reader.GetValue(7).ToString(),
                        reader.GetValue(8).ToString(),
                        reader.GetValue(9).ToString(),
                        reader.GetValue(10).ToString()});
                }
                return myCTInfos;
            }
            catch (Exception e)
            {

                return null;
            }
            finally
            {
                connectDB.Close();
            }
        }

        //*/






    }

}
