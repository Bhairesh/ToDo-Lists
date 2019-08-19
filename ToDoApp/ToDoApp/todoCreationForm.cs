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

namespace ToDoApp
{
    public partial class todoCreationForm : Form
    {
        public todoCreationForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void todoCreationForm_Load(object sender, EventArgs e)
        {
            string id = Lists.id;           
        }

        public static class FormState
        {
            public static Form PreviousPage;
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormState.PreviousPage.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
           // string dbStr = "datasource=localhost;port=3306;username=root;password=root";
           // MySqlConnection con = new MySqlConnection(dbStr);
           // MySqlCommand cmd = null, cmd1;
            
            int idNo = 0;
            try
            {
                string eventData = textBox1.Text;

                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = "yyyy-MM-dd";
                string date = dateTimePicker.Text + " " + dateTimePicker2.Text;

               // MessageBox.Show(date);
               // con.Open();

                string maxId = "select max(id) MaxID from todoDB.lists;";
               // cmd = new MySqlCommand(maxId,con);

                using(MySqlDataReader reader = DBConnection.getReader(maxId)){
                    while(reader.Read()){
                        idNo = int.Parse(reader["MaxID"].ToString());
                    }
                }
                if(textBox1.Text != "" && dateTimePicker.Text != "" && dateTimePicker2.Text != "")
                {
                    if (/*cmd != null && */idNo > 0)
                    {
                       idNo = ++idNo ;
                    string insert = "insert into todoDB.lists values('" + idNo + "','" + eventData + "','" + date + "');";
                    //cmd1 = new MySqlCommand(insert, con);

                    if (/*cmd1.ExecuteNonQuery() == 1*/DBConnection.getCmdResult(insert))
                    {
                        MessageBox.Show("Todo event created Successfully", "Todo List", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create event!!!", "Todo List", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                      //  con.Close();
                    }
                   } else{
                       MessageBox.Show("Fialed to Connect", "Todo List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
                }
                else
                {
                    MessageBox.Show("Field is Empty..", "Todo List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Todo List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            mainForm main = new mainForm();
            this.Close();
            main.Show();
        }
    }
}
