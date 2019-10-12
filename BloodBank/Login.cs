using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn;
                conn = DB.getinstance();
                conn.Open();

                SqlCommand cmd;
                cmd = new SqlCommand("SELECT password FROM Admin WHERE username=@username", conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                string i;
                i = cmd.ExecuteScalar().ToString();

                if (txtPassword.Text == i)
                {
                    new BloodBank().Show();
                    Hide();
                }
                else
                {
                    lblErrorMsg.Text = "UserName or Password is Incorrect";
                }

                conn.Close();
            }
            catch (Exception)
            {
               lblErrorMsg.Text = "UserName or Password is Incorrect";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        }
    }

