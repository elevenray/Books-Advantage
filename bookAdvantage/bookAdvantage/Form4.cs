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
    public partial class Form4 : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dtbl;

        public Form4()
        {
            InitializeComponent();
        }



        private void Register_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "Select * from [People] Where email= '" + textBox1.Text + "'";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                MessageBox.Show("Email is taken!");
            }
            else
            {
                try
                {
                    string commString = "INSERT INTO [People](email, username, password, role) VALUES (@val1, @val2, @val3, @val4)";
                    string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf";

                    using (SqlConnection conn = new SqlConnection(constring))
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            comm.Parameters.AddWithValue("@val1", textBox1.Text);
                            comm.Parameters.AddWithValue("@val2", textBox2.Text);
                            comm.Parameters.AddWithValue("@val3", textBox3.Text);
                            comm.Parameters.AddWithValue("@val4", textBox4.Text);
                            conn.Open();
                            comm.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                    MessageBox.Show("Sucessfully registered!");
                    sqlcon.Close();
                }
                catch { MessageBox.Show("A registration error has occured. Please contact the developer :("); }

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = true;
            }
            else
            {
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            cmd = new SqlCommand(("DELETE from [People] where email = '" + textBox5.Text + "'"), sqlcon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sucessfully Deleted!");
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
