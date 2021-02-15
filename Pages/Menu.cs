using System;
using System.Windows.Forms;
using Human_Relations.Pages;

namespace Human_Relations
{
    public partial class Menu : Form
    {
        public int UserID;
        Login loginWind;
         
        public Menu(Login loginInstance, DateTime current)
        {
            InitializeComponent();
            loginWind = loginInstance;
        }

        // DESCRIPTION: Initializer. Shows/hides hotel management button based on isCustomer
        public Menu(int userID, Login loginInstance)
        {

            InitializeComponent();
            loginWind = loginInstance;
            UserID = userID;
        }

        // logs user out
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // opens employee management page
        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            var manageEmp = new ManageEmp(UserID);
            manageEmp.FormClosed += new FormClosedEventHandler(manageEmp_FormClosed);
            this.Hide();
            manageEmp.Show();
        }

        // opens menu when employee management page is closed
        private void manageEmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        //description: Shows report page to admins
        private void btnReport_Click(object sender, EventArgs e)
        {
            var viewReports = new Reports();
            viewReports.FormClosed += new FormClosedEventHandler(reports_formClosed);
            this.Hide();
            viewReports.Show();
        }
        // opens menu when reports page is closed
        private void reports_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        // opens new employee page
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            var newEmployee = new createAccount();
            newEmployee.FormClosed += new FormClosedEventHandler(newEmployee_FormClosed);
            this.Hide();
            newEmployee.Show();
        }
        // opens menu when new employee page is closed
        private void newEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
