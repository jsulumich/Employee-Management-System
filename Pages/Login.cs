using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace Human_Relations
{
    public partial class Login : Form
    {
        private Utilities verifyCredentials = new Utilities();
     
        public Login()
        {
            InitializeComponent();
        }

        // DESCRIPTION: Utility function for error display
        private void displayError(string errorMessage)
        {
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }

        //DESCRIPTION: Sets isActive = 0 for empID record in employeemgmt.login table
        public bool deactivateLogin(int empID)
        {
            DBConnect deactivateLoginConn = new DBConnect();
            MySqlCommand deactivateLoginCmd = new MySqlCommand(@"UPDATE employeemgmt.login
                                                                SET isActive = 0
                                                                WHERE loginEmployeeID = @empID");
            deactivateLoginCmd.Parameters.Add("@empID", MySqlDbType.Int32).Value = empID;
            if (deactivateLoginConn.NonQuery(deactivateLoginCmd) > 0)
                return true;
            return false;
        }

        // DESCRIPTION: checks if user is active and password matches username
        private bool checkPassword(string username)
        {
            DBConnect checkPasswordConn = new DBConnect();
            MySqlCommand checkPasswordCmd = new MySqlCommand(@"SELECT COUNT(*) FROM employeemgmt.login
                                                                WHERE username = @username
                                                                AND password = @password
                                                                and isActive = 1");
            checkPasswordCmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = txtUsername.Text;
            checkPasswordCmd.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = txtPassword.Text;
            if (checkPasswordConn.intScalar(checkPasswordCmd) > 0)
                return true;
            else
                return false;
        }

// DESCRIPTION: Updates lastLogin column of user record in employeemgmt.login table
        private void updateLastLogin(int loginEmpID)
        {
            DateTime current = DateTime.Now;
            DBConnect updateLastLoginConn = new DBConnect();
            MySqlCommand updateLastLoginCmd = new MySqlCommand(@"UPDATE employeemgmt.login
                                                                SET
                                                                lastLogin = @current
                                                                WHERE loginEmployeeID = @loginEmpID");
            updateLastLoginCmd.Parameters.Add("@current", MySqlDbType.DateTime).Value = current;
            updateLastLoginCmd.Parameters.Add("@loginEmpID", MySqlDbType.Int32).Value = loginEmpID;
            updateLastLoginConn.NonQuery(updateLastLoginCmd);
        }
        
         // DESCRIPTION: Checks that account is active and verifies credentials. Logs user into system if they are
         private void btnLogin_Click(object sender, EventArgs e)
        {
            // reset error status
            lblError.Visible = false;

            // if username not entered
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                displayError("Username is required");
            }
            // if password not entered
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                displayError("Password is required");
            }

            else
            {
                // if credentials are valid
                if (checkPassword(txtUsername.Text))
                {
                    // get account ID of user logging in
                    int loginEmpID = verifyCredentials.getLoginEmpIDFromUsername(txtUsername.Text);
                    // update last login time of user
                    updateLastLogin(loginEmpID);
                    // re-direct to menu
                    var menuScreen = new Menu(loginEmpID, this);
                    menuScreen.FormClosed += new FormClosedEventHandler(menuScreen_FormClosed);
                    this.Hide();
                    menuScreen.Show();
                }
                else
                {
                // invalid credentials. display generic error message
                displayError("Invalid username/password");
                }            
            }
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        // returns to Login screen when menu is closed
        private void menuScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
