using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace bookAdvantage
{
    public partial class Form5 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf");
        SqlCommand cmd;
        //SqlDataAdapter sda;
        //DataTable dtbl;

        public Form5()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string commString = "INSERT INTO [book](bookID, isbn, name, location) VALUES (@val1, @val2, @val3, @val4)";
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf";

            using (SqlConnection conn = new SqlConnection(constring))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    comm.Parameters.AddWithValue("@val1", textBox5.Text);
                    comm.Parameters.AddWithValue("@val2", textBox1.Text);
                    comm.Parameters.AddWithValue("@val3", textBox2.Text);
                    comm.Parameters.AddWithValue("@val4", textBox3.Text);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
            MessageBox.Show("Sucessfully Added Book!");
            sqlcon.Close();
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            cmd = new SqlCommand(("DELETE from [book] where name = '" + textBox4.Text + "'"), sqlcon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sucessfully Deleted Book!");
            sqlcon.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
