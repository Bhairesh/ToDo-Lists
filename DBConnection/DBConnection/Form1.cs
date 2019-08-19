
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string con = "datasource=localhost;port=3306;username=root;password=root";
            //MySqlConnection myCon = new MySqlConnection(con);
            try
            {
               
               // myCon.Open();             
              //  MySqlDataAdapter adapter = new MySqlDataAdapter();
               // adapter.SelectCommand = new MySqlCommand("select * from sampledb.user;", myCon);
                MySqlDataReader readr= ConnectionDB.getReader("select * from sampledb.user;");
                Boolean cmd = ConnectionDB.getCmdResult("select * from sampledb.user;");
                if(cmd){
                    MessageBox.Show("Trueeeeeeee");
                }
                else
                {
                    MessageBox.Show("Falseeee");
                }
             if((readr) != null){
                 MessageBox.Show("Connected");
               //  myCon.Close();
             }
             else
             {
                 MessageBox.Show("Not Connected");
               //  myCon.Close();
             }
                
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    myCon.Close();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertData insrtfrm = new InsertData();
            this.Hide();
            insrtfrm.Show();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            ListsForm lfrm = new ListsForm();
            this.Hide();
            lfrm.Show();
        }
    }
}