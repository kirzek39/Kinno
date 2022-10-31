using Kinoteatr;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kinoteatrr
{
    public partial class Form3 : Form
    {
        DataSet ds;
        MySqlDataAdapter adapter;
        string connectionString = @"Data Source=DESKTOP-K6HD04V; Initial Catalog=kino;";
        string sql = "SELECT * FROM film";
        public Form3()
        {
            InitializeComponent();

            try
            {
                MySqlConnection cnn = DBUtils.GetDBConnection();
                MySqlDataAdapter ada = new MySqlDataAdapter("select * from film;", cnn);
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Win =
                new Form1();
            Win.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // удаляем выделенные строки из dataGridView1
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
    }
}
