using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ToDoApp
{
    public class DBConnection
    {
       static MySqlConnection con = null;
       static MySqlCommand cmd = null;
       static MySqlDataReader reader = null;
       static string dbStr = "datasource=localhost;port=3306;username=root;password=root";

        public static Boolean getCmdResult(string query)
        {
            con = null;
            try
            {
                if(query!="")
                {
                        con = new MySqlConnection(dbStr);
                        con.Open();
                        cmd = new MySqlCommand(query, con);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }    
                }
                else
                {
                    MessageBox.Show("Empty query...", "Todo List", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex){
                MessageBox.Show("MySqlConnection/MySqlCommand: " + ex.Message, "Todo List", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }

        public static MySqlDataReader getReader(string query)
        {
            try
            {
                    con = null;
                    con = new MySqlConnection(dbStr);
                    con.Open();
                    cmd = new MySqlCommand(query, con);// Only For Select Query
                    reader = cmd.ExecuteReader();
                    if(reader != null){
                        return reader;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySqlDataReader: " + ex.Message, "Todo List", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            return reader;
        }
    }
}
