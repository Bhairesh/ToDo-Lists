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
    public partial class ListsForm : Form
    {
        public ListsForm()
        {
            InitializeComponent();
        }

        private void Lists_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sampledbDataSet.user' table. You can move, or remove it, as needed.
           // this.userTableAdapter.Fill(this.sampledbDataSet.user);
           
            try
            {
                string dbStr = "datasource=localhost;port=3306;username=root;password=root";
                MySqlConnection con = new MySqlConnection(dbStr);
                con.Open();
                //string query = "select * from sampledb.user;";
                //MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                
                //DataSet ds = new DataSet();
                //adapter.Fill(ds, "user");
                //dataGridView1.DataSource = ds.Tables["user"];
                //---------------------------------------------------

                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "SELECT * from sampledb.user";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridView1.DataSource = bSource;


                for (int i = 0; i < (dataGridView1.SelectedRows.Count); i++)
                {
                    for (int j = 0; j < (dataGridView1.SelectedColumns.Count); j++)
                    {
                        dataGridView1.SelectedRows[i].Cells[j].Value = "sdhvks";
                    }
                }



                
              //  dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);//resizes the column to table's content
                
                con.Close();
            } catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
