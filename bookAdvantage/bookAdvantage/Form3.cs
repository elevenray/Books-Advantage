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
    public partial class Form3 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf");
        //SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dtbl;

        public Form3()
        {
            InitializeComponent();
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

        private void Rent_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "Insert Into [rentedBooks] (bookID, isbn, name, location) Select bookID, isbn, name, location From [book] Where bookID = '" + BookID.Text + "'";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            MessageBox.Show("Book has been rented.");
            sqlcon.Close();

            SqlConnection sqlcon3 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf");
            string query2 = "Update [rentedBooks] Set location = '" + textBox1.Text + "' Where bookID = '" + BookID.Text + "'";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon3);
            DataTable dtbl2 = new DataTable();
            sda2.Fill(dtbl2);
            sqlcon3.Close();
            
            SqlConnection sqlcon2 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf");
            sqlcon2.Open();
            SqlCommand cmd = new SqlCommand(("DELETE from [book] where bookID = '" + BookID.Text + "'"), sqlcon2);
            cmd.ExecuteNonQuery();
            sqlcon2.Close();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "Insert Into [book] (bookID, isbn, name, location) Select bookID, isbn, name, location From [rentedBooks] Where bookID = '" + BookID.Text + "'";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            MessageBox.Show("Book has been returned.");
            sqlcon.Close();

            SqlConnection sqlcon3 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf");
            string query2 = "Update [book] Set location = '" + textBox1.Text + "' Where bookID = '" + BookID.Text + "'";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon3);
            DataTable dtbl2 = new DataTable();
            sda2.Fill(dtbl2);
            sqlcon3.Close();

            SqlConnection sqlcon2 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf");
            sqlcon2.Open();
            SqlCommand cmd = new SqlCommand(("DELETE from [rentedBooks] where bookID = '" + BookID.Text + "'"), sqlcon2);
            cmd.ExecuteNonQuery();
            sqlcon2.Close();
        }

        private void logOff_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewRented_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "Select bookID, name, isbn, location From [rentedBooks] Where location = '" + textBox1.Text + "'";
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlcon.Close();
        }

        private void seachBox_TextChanged(object sender, EventArgs e)
        {
            searchRentedBooks(searchBox.Text);
            searchBooks(searchBox.Text);
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
    }
}
