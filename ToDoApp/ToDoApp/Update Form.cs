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
    public partial class Update_Form : Form
    {
        public Update_Form()
        {
            InitializeComponent();
        }

        
        private void exitBtn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure want to close", "ToDo List", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                Close();
            }
        }

        static string dbStr = "datasource=localhost;port=3306;username=root;password=root";
        static string todotext = "";
        static string dnt = "";
        static string id = "";

        private void Update_Form_Load(object sender, EventArgs e)
        {
            id = Lists.id;
            int idNo = int.Parse(id);
            try
            {
                string selQuery = "select * from todoDB.lists where id='" + id + "';";
                MySqlConnection con = new MySqlConnection(dbStr);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = new MySqlCommand(selQuery, con);

                MySqlDataReader reader = null;

                if ((adapter.SelectCommand) != null)
                {
                    reader = adapter.SelectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        todotext = reader["todotext"].ToString();
                        dnt = reader["dnt"].ToString();
                    }
                 //   MessageBox.Show("TDL "+todotext +" dnt "+dnt);
                    textBox1.Text = todotext;
                    reader.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Failed..to connect", "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    con.Close();

                }
                reader.Close();
                con.Close();
            } catch(Exception ex){
                MessageBox.Show("Form Load '" + ex.Message + "'", "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("TDL " + todotext + " dnt " + dnt);
            

            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "yyyy-MM-dd";
            string date = datePicker.Text + " " + timePicker.Text;

            MySqlConnection con = new MySqlConnection(dbStr);
            con.Open();

            if (textBox1.Text != "" && date != "")
            {
                try
                {
                    string updateQ = "update todoDB.lists set todotext = '" + textBox1.Text + "',dnt = '" + date + "' where id='" + id + "'";
                    MySqlCommand cmd1 = new MySqlCommand(updateQ, con);
                    if (cmd1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Updated Successfully", "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save Data", "ToDo Lists", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        con.Close();
                    }
                }catch(Exception ex){
                    MessageBox.Show(ex.Message, "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Data not found for the ID '" + id + "'", "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
            Lists lists = new Lists();
            this.Close();
            lists.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            ToDoApp.todoCreationForm.FormState.PreviousPage.Show();
            this.Hide();
        }
    }
}
