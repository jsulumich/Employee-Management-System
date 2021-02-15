using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Human_Relations.Pages
{
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
            hireDateTimePicker.Value = DateTime.Today;
        }

        private Utilities verifyAccount = new Utilities();
        private int ZIPInt;
        private double salaryDouble;
        private string department;


        // DESCRIPTION: Utility function to display errors on page
        private void displayError(string errorMessage)
        {
            lblError.ForeColor = Color.Red;
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }
            

        // DESCRIPTION: shows or hides login information info depending on which department is selected
        private void cBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView oDataRowView = cBoxDep.SelectedItem as DataRowView;

            if (oDataRowView != null)
            {
                department = oDataRowView.Row["departmentName"] as string;
            }

            if (department == "Human Resources")
            {
                gBoxAdminInfo.Visible = true;
            }
            else
            {
                gBoxAdminInfo.Visible = false;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // hide error label
            lblError.Visible = false;
            bool acctOK = verifyFields();
            if (acctOK)
            {
                int empID = createEmpAccount();

                if (empID != -1)
                {
                    lblError.ForeColor = System.Drawing.Color.Green;
                    lblError.Text = "Employee account created successfully";
                    lblError.Visible = true;
                }
                else
                {
                    displayError("Unable to create employee account");
                }

                if (department == "Human Resources")
                {
                    int logID = createLogin(empID);
                    if (logID != -1)
                    {
                        lblError.ForeColor = System.Drawing.Color.Green;
                        lblError.Text = "Employee account and login created successfully";
                        lblError.Visible = true;
                    }
                    else
                    {
                        displayError("Employee account created. Error creating login");
                    }
                }
                else
                    return;
            }
            else
                return;
        }

        private int createEmpAccount()
        {
            DBConnect createAccountConn = new DBConnect();
            MySqlCommand createAccountCmd = new MySqlCommand(@"INSERT INTO employeemgmt.employee
                                                            (firstName,lastName,addressLine1,addressLine2,city,state,zip,email,hireDate,depID,roleID,salary) VALUES
                                                            (@firstName,@lastName,@addressLine1,@addressLine2,@city,@state,@zip,@email,@hireDate,@depID,@roleID,@salary);");
            createAccountCmd.Parameters.Add("@firstName", MySqlDbType.VarChar, 45).Value = txtFName.Text;
            createAccountCmd.Parameters.Add("@lastName", MySqlDbType.VarChar, 45).Value = txtLName.Text;
            createAccountCmd.Parameters.Add("@addressLine1", MySqlDbType.VarChar).Value = txtAddress1.Text;
            createAccountCmd.Parameters.Add("@addressLine2", MySqlDbType.VarChar).Value = txtAddress2.Text;
            createAccountCmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = txtCity.Text;
            createAccountCmd.Parameters.Add("@state", MySqlDbType.VarChar).Value = cBoxStates.SelectedItem;
            createAccountCmd.Parameters.Add("@zip", MySqlDbType.Int32).Value = ZIPInt;
            createAccountCmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = txtEmail.Text;
            createAccountCmd.Parameters.Add("@salary", MySqlDbType.Decimal).Value = salaryDouble;
            createAccountCmd.Parameters.Add("@hiredate", MySqlDbType.DateTime).Value = hireDateTimePicker.Value;
            createAccountCmd.Parameters.Add("@roleID", MySqlDbType.VarChar, 45).Value = cBoxRole.SelectedValue;
            createAccountCmd.Parameters.Add("@depID", MySqlDbType.VarChar).Value = cBoxDep.SelectedValue;
            if (createAccountConn.NonQuery(createAccountCmd) > 0)
            { return verifyAccount.getUserIDFromEmail(txtEmail.Text); }
            else { return -1; }
        
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int  createLogin(int empID)
        {
            DBConnect createLoginConn = new DBConnect();
            MySqlCommand createLoginCmd = new MySqlCommand(@"INSERT INTO employeemgmt.login
                                                            (loginEmployeeID, username, password, isActive)
                                                            VALUES(@empID, @username, @password, 1)");
            createLoginCmd.Parameters.Add("@empID", MySqlDbType.Int32).Value = empID;
            createLoginCmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text;
            createLoginCmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPassword.Text;
            if(createLoginConn.NonQuery(createLoginCmd) > 0)
            {
                return empID;
            }
            else
            {
                return -1;
            }
        }

        //DESCRIPTION: Verifies all fields are filled and valid
        private bool verifyFields()
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                displayError("First name is required");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                displayError("Last name is required");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                displayError("Email address is required");
                return false;
            }
            else if (!(verifyAccount.isValidEmail(txtEmail.Text)))
            {
                displayError("Email address must be in a valid format");
                return false;
            }
            else if (verifyAccount.emailExists(txtEmail.Text))
            {
                displayError("Email address already exists");
                return false;
            }
            else if (string.IsNullOrEmpty(txtAddress1.Text))
            {
                displayError("Street address is required");
                return false;
            }
            //check that city is entered
            else if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                displayError("City is required");
                return false;
            }
            // check that state is selected
            else if (cBoxStates.SelectedIndex == -1)
            {
                displayError("State is required");
                return false;
            }
            // check that zip code is entered
            else if (string.IsNullOrWhiteSpace(txtZIP.Text))
            {
                displayError("ZIP code is required");
                return false;
            }
            // checks ZIP code is a number
            else if (!(int.TryParse(txtZIP.Text, out ZIPInt)))
            {
                displayError("Invalid ZIP code");
                return false;
            }
            else if (txtZIP.TextLength < 5)
            {
                displayError("Zip code must have 5 numbers");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                displayError("Salary is required");
                return false;
            }
            // check that payRate is in a valid format
            else if (!(double.TryParse(txtSalary.Text, out salaryDouble)))
            {
                displayError("Salary must be a number");
                return false;
            }
            // if hire date is not checked
            else if (!hireDateTimePicker.Checked)
            {
                displayError("hiredate is required");
                return false;
            }
            // if role is not selected
            else if (cBoxRole.SelectedIndex <= -1)
            {
                displayError("Please select a Role");
                return false;
            }
            // if department is not selected
            else if (cBoxDep.SelectedIndex <= -1)
            {
                displayError("Please select a Department");
                return false;
            }
            // if user requires a login
            else if (department == "Human Resources")
            {
                if(string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    displayError("Username is required");
                    return false;
                }
                else if(verifyAccount.usernameExists(txtUsername.Text))
                {
                    displayError("Username already exists");
                    return false;
                }
                else if(string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    displayError("Password is required");
                    return false;
                }
                return true;
            }
            return true;
        }

        // DESCRIPTION: Loads data into department and role combo boxes
        private void createAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeemgmtDataSet.role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.employeemgmtDataSet.role);
            // TODO: This line of code loads data into the 'employeemgmtDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.employeemgmtDataSet.department);
            cBoxDep.SelectedIndex = -1;
            cBoxRole.SelectedIndex = -1;
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
                this.Close();
                Application.OpenForms["Menu"].Close();
           
        }
    }

}
