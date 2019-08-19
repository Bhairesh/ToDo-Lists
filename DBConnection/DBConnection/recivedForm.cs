using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnection
{
    public partial class recivedForm : Form
    {
        public recivedForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void recivedForm_Load(object sender, EventArgs e)
        {
            label1.Text = passingForm.value;
            textBox1.Text = passingForm.value;
        }
    }
}
