using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kinoteatr;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kinoteatrr
{
    public partial class Form2 : Form
    {
        DataSet ds;
        MySqlDataAdapter adapter;
        string connectionString = @"Data Source=DESKTOP-K6HD04V; Initial Catalog=kino;";
        string sql = "SELECT * FROM ticket";
        public Form2()
        {
            InitializeComponent();

            

            try
            {
                MySqlConnection cnn = DBUtils.GetDBConnection();
                MySqlDataAdapter ada = new MySqlDataAdapter("select * from ticket;", cnn);
                DataTable dt = new DataTable();
                cnn.Open();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Win =
                new Form1();
            Win.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
