using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
 
namespace DBConnection
{
    public partial class InsertData : Form
    {
        public InsertData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pwd = textBox2.Text;
             int id = 0;
           // int count = 1;

            //string dbStr = "datasource=localhost;port=3306;username=root;password=root";
            //MySqlConnection con = new MySqlConnection(dbStr);

            try

        
            {

               
               // con.Open();
                string selCmd = "select max(id) ID from sampledb.user;";
              //  MySqlCommand cmd = new MySqlCommand(selCmd,con);
               // MySqlDataReader read = cmd.ExecuteReader();
                MySqlDataReader read = ConnectionDB.getReader(selCmd);
              //  using (MySqlDataReader read = cmd.ExecuteReader())
               // {
                    while (read.Read())
                    {
                         id = int.Parse(read["ID"].ToString());
                    }
                //}
                

                string query = "";

                if(id != 0)
                {
                 

                    id = id + 1;
                     query = "insert into sampledb.user(uname,pwd,id) values('" + uname + "','" + pwd + "','" + id + "');";
                 //    cmd = new MySqlCommand(query, con);

                     if (ConnectionDB.getCmdResult(query))
                     {
                         MessageBox.Show("Data Inserted");
                     }
                     else
                     {
                         MessageBox.Show("Failed!!!!!!!!!!!!");
                     }
                }
                else
                {
                    MessageBox.Show("Duplicate ID Values..!!");

                }
               
             //   con.Close();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message,"DBC",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           //  con.Close();
        }

        //public static class DBConnector{
        //    private DBConnector() {}

        //    public static MySqlConnection getCon(){
        //        MySqlConnection con=null;
        //        string dbStr = "datasource=localhost;port=3306;username=root;password=root";
        //        if(con==null){
        //        try
        //        {
        //            con = new MySqlConnection(dbStr);
        //            return con;

        //        } catch(Exception ex){
        //            MessageBox.Show(ex.Message);
        //        }
        //      } else {
        //          return con;
        //      }
        //    }
        /**/
        //}

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //string dbStr = "datasource=localhost;port=3306;username=root;password=root";
            //    MySqlConnection con = new MySqlConnection(dbStr);
            try
            {
                string uname = textBox3.Text;
                
               // con.Open();
                string query = "delete from sampledb.user where uname='" + uname + "';";
                //MySqlCommand cmd = new MySqlCommand(query, con);

                if (ConnectionDB.getCmdResult(query))
                {
                    MessageBox.Show("Data deleted..");
                }
                else
                {
                    MessageBox.Show("Failed!!!!");
                }
              //  con.Close();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
           // con.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string uname = textBox4.Text;
            string newName = textBox5.Text;
          //   string dbStr = "datasource=localhost;port=3306;username=root;password=root";
           //     MySqlConnection con = new MySqlConnection(dbStr);
            try
            {
               
           //     con.Open();
                string query = "update sampledb.user set uname='" + newName + "' where uname='" + uname + "';";
             //   MySqlCommand cmd = new MySqlCommand(query,con);

                if (ConnectionDB.getCmdResult(query))
                {
                    MessageBox.Show("data updated..");
                }
                else
                {
                    MessageBox.Show("Failed!!!");
                }
              //  con.Close();


            } 
            catch(Exception exx){
                MessageBox.Show(exx.Message);
            }
          //  con.Close();
        }

    }
}
