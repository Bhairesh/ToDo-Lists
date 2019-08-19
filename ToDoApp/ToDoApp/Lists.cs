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
    public partial class Lists : Form
    {
        public static string id = "";

        public Lists()
        {
            InitializeComponent();
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            ToDoApp.todoCreationForm.FormState.PreviousPage.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure want to close", "ToDo List", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string dbStr = "datasource=localhost;port=3306;username=root;password=root";
            MySqlConnection con = new MySqlConnection(dbStr);
            if(id != ""){
                string del = "delete from todoDB.lists where id='" + id + "'";
                try
                {
                    if (MessageBox.Show("Are you sure want to DELETE", "ToDo Lists", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(del, con);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Deleted Successfully", "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();

                            //reload code not written
                        }
                        else
                        {
                            MessageBox.Show("Failed", "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Text Field is empty..", "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
           id = textBox1.Text;
           if(id != ""){
               Update_Form updtFrm = new Update_Form();
               this.Hide();
               updtFrm.Show();
           }
           else
           {
               MessageBox.Show("Enter ID to Update..", "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
        }

        private void Lists_Load(object sender, EventArgs e)
        {

        }
    }
}
