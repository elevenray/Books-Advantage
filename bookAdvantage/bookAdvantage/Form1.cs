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
//using MySql.Data.MySqlClient;


namespace bookAdvantage
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|bookAdvantage.mdf");
        SqlCommand cmd; 
        SqlDataAdapter sda;
        DataTable dtbl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            cmd = new SqlCommand("Select * from [People] Where email ='" + Email.Text + "' and password = '" + Password.Text + "'", sqlcon);
            sda = new SqlDataAdapter(cmd);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            string cmbItemValue = Role_Selection.SelectedItem.ToString();
            if (dtbl.Rows.Count > 0)
            {
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    if (dtbl.Rows[i]["role"].ToString() == cmbItemValue)
                    {
                        if (Role_Selection.SelectedIndex == 0)
                        {
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form3 f3 = new Form3();
                            f3.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        if (dtbl.Rows[i]["role"].ToString() != cmbItemValue)
                        {
                            if (Role_Selection.SelectedIndex == 0)
                            {
                                MessageBox.Show("Incorrect Login Information, Please try again");
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Login Information, Please try again");
                            }

                        }
                    }
                }
            }
    }

    private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_pass.Checked)
            {
                Password.UseSystemPasswordChar = true;
            }
            else
            {
                Password.UseSystemPasswordChar = false;
            }
        }

       
    }
}
