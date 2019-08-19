using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // DialogResult stores the result of messageBox

            if ((MessageBox.Show("Are you sure want to close", "ToDo List", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                    Close();
            }          
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            ToDoApp.todoCreationForm.FormState.PreviousPage = this;
            this.Hide();
            todoCreationForm tdcf = new todoCreationForm();
            tdcf.ShowDialog();
        }

        private void listsBtn_Click(object sender, EventArgs e)
        {
            ToDoApp.todoCreationForm.FormState.PreviousPage = this;
            this.Hide();
            Lists listPage = new Lists();
            listPage.ShowDialog();
        }

        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lists listPage = new Lists();
            listPage.ShowDialog();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            todoCreationForm tdcf = new todoCreationForm();
            tdcf.ShowDialog();
        }
    }
}
