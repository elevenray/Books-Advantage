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
    public partial class Form2 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf");
        //SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dtbl;

        public Form2()
        {
            InitializeComponent();
        }

        private void AddNewS_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void ViewStudents_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "Select email, username, role From [People]";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlcon.Close();
        }

        private void ViewBooks_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "Select * From [book]";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlcon.Close();
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void ViewRented_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "Select * From [rentedBooks]";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlcon.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchRentedBooks(searchBox.Text);
            searchBooks(searchBox.Text);
            searchPeople(searchBox.Text);
        }

        public void searchRentedBooks(string search)
        {
            sqlcon.Open();
            string query = "Select * From [rentedBooks] Where name like '%" + search + "%'";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlcon.Close();
        }

        public void searchBooks(string search)
        {
            sqlcon.Open();
            string query = "Select * From [book] Where name like '%" + search + "%'";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlcon.Close();
        }

        public void searchPeople(string search)
        {
            sqlcon.Open();
            string query = "Select email, username, role From [People] Where username like '%" + search + "%'";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlcon.Close();
        }
    }
}
