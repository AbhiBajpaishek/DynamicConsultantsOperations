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
    public partial class DashBoardMaster : Form
    {
        public static  String uname;
        Registration registration = new Registration();
        PasswordChange passwordChange = new PasswordChange();
        public DashBoardMaster()
        {
            InitializeComponent();
            registration.uname = DashBoardMaster.uname;
            logOutToolStripMenuItem.Text = uname + " Log Out";
            registration.TopLevel = false;
            registration.Parent = this;
            childPanel.Controls.Add(registration);
            registration.Dock = DockStyle.Fill;
            registration.Show();
        }

        private void DashBoardMaster_Load(object sender, EventArgs e)
        {

        }


        private void changePassowrdToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            passwordChange.TopLevel = false;
            passwordChange.Parent = this;
            childPanel.Controls.Add(passwordChange);
            passwordChange.Dock = DockStyle.Fill;
            //passwordChange.StartPosition = FormStartPosition.CenterScreen;
            passwordChange.Show();
            registration.Hide();
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordChange.Hide();
            registration.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            
        }

        private void childPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
