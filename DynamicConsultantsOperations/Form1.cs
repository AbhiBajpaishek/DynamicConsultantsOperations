using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicConsultantsOperations;

namespace DynamicConsultantsOperations
{
    public partial class Login : Form
    {
        public static string username;
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (authentication(txtUsername.Text, txtPass.Text))
            {
                this.Hide();
                username = txtUsername.Text;
                DashBoardMaster dashBoard = new DashBoardMaster();
                dashBoard.uname = txtUsername.Text;
                dashBoard.Show();
            } 
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }



        public bool authentication(String uname, String pass)
        {
            DBClass db = new DBClass();
            DataTable dt= db.ReadBulkData("select Username, Password from Tbl_Login where Username='"+txtUsername.Text+"'");
            if (dt.Rows.Count>0&&dt.Rows[0][0].Equals(uname))
            {
                if (dt.Rows[0][1].Equals(pass))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
        
          
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPassword.Text == "Show")
            {
                txtPass.PasswordChar = '\0';
                btnShowPassword.Text = "Hide";
            }
            else
            {
                txtPass.PasswordChar = '*';
                btnShowPassword.Text = "Show";
            }
        }
    }
}
