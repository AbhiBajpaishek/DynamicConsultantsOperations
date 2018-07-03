using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicConsultantsOperations
{
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();
            DataTable dt = db.ReadBulkData("select Username, Password from Tbl_Login where Username='" + txtUsername.Text + "'");
            if (dt.Rows.Count>0&& dt.Rows[0][0].ToString()==txtUsername.Text&&dt.Rows[0][1].ToString() == txtOldPassword.Text)
            {
                if (txtPass.Text != "")
                {
                    if (validationCheck(txtPass.Text, txtConfirmPassword.Text))
                    {
                        if (db.InsertUpdateDelete("update Tbl_login SET Password = '" + txtPass.Text + "' where Username= '" + txtUsername.Text + "';"))
                        {
                            MessageBox.Show("Password Changed Succesfully");
                            clearFields();
                        }
                            
                        else
                            MessageBox.Show("Some Error Occurred");
                    }
                    else
                        MessageBox.Show("Passwords didn't match");
                }
                else
                    MessageBox.Show("Please Enter Missing Fields");
                
            }
            else
                MessageBox.Show("Invalid Credentials");
            
        }


        public bool validationCheck(String pass, String confirmPass)
        {
            if (pass.Equals(confirmPass))
            {
                return true;
            }
            return false;
        }

        private void hideShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(hideShowPassword.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtOldPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
                hideShowPassword.Text = "Hide";
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtOldPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
                hideShowPassword.Text = "Show";
            }
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        void clearFields()
        {
            txtConfirmPassword.Text = "";
            txtOldPassword.Text = "";
            txtPass.Text = "";
            txtUsername.Text = "";
        }
    }
}
