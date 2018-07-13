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
    public partial class Registration : Form
    {
        public String uname=Login.username;
        String query = "select * from Tbl_Registration where Status='Active';";
        DBClass db = new DBClass();
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (validationCheck(txtPass.Text, txtConfirmPass.Text) == false)
            {
                MessageBox.Show("Passwords didn't match");
            }
            else if (emptyCheck() && txtPass.Text != "")
            {
                //if the fields aren't empty it will chekc for existing data or fresh registration
                if (db.ReadBulkData("select Name from Tbl_Registration where Email= '" + txtMail.Text + "';").Rows.Count > 0)
                {//for update
                    if (db.spUpdate(txtName.Text, txtMail.Text, txtAge.Text, genderCheck(), txtPass.Text))
                        MessageBox.Show("Record Updated");
                    else
                        MessageBox.Show("Some Error Occured");
                    registrationDataGridView.DataSource = db.ReadBulkData(query);
                }
                else
                {//for fresh registration
                    if (db.spRegistration(txtName.Text, txtMail.Text, txtAge.Text, genderCheck(), txtPass.Text, uname))
                        MessageBox.Show("Registration Succesfull");
                    else
                        MessageBox.Show("Failure");
                }
            }
            else
                MessageBox.Show("Fill Blank Columns");
            registrationDataGridView.DataSource = db.ReadBulkData(query);
            clearFields();
        }


        //to check if email is already registered

        private void registrationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = db.ReadBulkData(query);
            if (e.ColumnIndex == 0)
            {
                //this is for transferring data to the above edit panel in the form
                txtName.Text = dt.Rows[e.RowIndex][0].ToString();
                txtMail.Text = dt.Rows[e.RowIndex][1].ToString();
                if (dt.Rows[e.RowIndex][2].ToString() == "Male")
                    maleRadio.Select();
                else
                    femaleRadio.Select();
                txtAge.Text = dt.Rows[e.RowIndex][3].ToString();
            }
            else if(e.ColumnIndex==1)
            {
                //It doesn't delete records instead turn it inactive
                    if (db.spDelete(dt.Rows[e.RowIndex][1].ToString()))
                        MessageBox.Show("Record Deleted");
                    else
                        MessageBox.Show("Some Error Occured");
                registrationDataGridView.DataSource = db.ReadBulkData(query);
                clearFields();
            }
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            registrationDataGridView.DataSource= db.ReadBulkData(query);              
        }

        //for clearing all fields

            public void clearFields()
            {
                txtAge.Text = "";
                txtMail.Text = "";
                txtName.Text = "";
                txtConfirmPass.Text = "";
                txtPass.Text = "";  
            }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        public bool validationCheck(String pass, String confirmPass)
        {
            if(pass.Equals(confirmPass))
            {
                return true;
            }
            return false;
        }


        public bool emptyCheck()
        {
            if (txtName.Text != "")
            {
                if (txtMail.Text != "")
                {
                     if (txtAge.Text != "")
                            return true;
                        else
                            MessageBox.Show("Please Enter Age");
                }
                else
                    MessageBox.Show("Please Enter E-Mail ");
            }
            else
                MessageBox.Show("Please Enter Name");
            return false;

        }


        String genderCheck()
        {
            if (maleRadio.Checked)
                return "Male";
            else
               return "Female";
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (btnShowPassword.Text == "Show")
            {
                txtPass.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
                btnShowPassword.Text = "Hide";
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
                btnShowPassword.Text = "Show";
            }

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPassword.Text == "Show")
            {
                txtPass.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
                btnShowPassword.Text = "Hide";
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
                btnShowPassword.Text = "Show";
            }
        }
    }
}
