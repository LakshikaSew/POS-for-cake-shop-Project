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

namespace POS_Project
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Welcome\OneDrive\Documents\PoS.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand Login_UserName_Check = new SqlCommand("select UserName from UserDetails where UserName = '"+txtUserName.Text+"'",con);
            SqlDataReader NameChecker = Login_UserName_Check.ExecuteReader();

            if (NameChecker.Read() == true)
            {
                NameChecker.Close();
                con.Close();

                con.Open();
                SqlCommand Login_Passsword_Check = new SqlCommand("select Password from UserDetails where UserName = '"+txtUserName.Text+"' and Password = '" + txtPassword.Text + "'", con);
                SqlDataReader Password_Reader = Login_Passsword_Check.ExecuteReader();
                if (Password_Reader.Read() == true)
                {
                    Password_Reader.Close();
                    con.Close();

                    this.Hide();
                    Work_Station work_Station = new Work_Station();
                    work_Station.Show();
                }

                else 
                {
                    Password_Reader.Close();
                    con.Close();

                    txtPassword.Text = "";
                    MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                NameChecker.Close();
                con.Close();

                txtUserName.Text = "";

                MessageBox.Show("Username not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
