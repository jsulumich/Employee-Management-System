using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Human_Relations.Pages
{
    public partial class ManageEmp : Form
    {
        public int adminUserID;
        public int empUserID;
        public int ZIPInt;
        public double salaryDouble;
        public User userInfo;
        private Login manageAdmin = new Login();

        public ManageEmp(int UserID)
        {
            InitializeComponent();
            adminUserID = UserID;
            resetEndDate();
        }

        // DESCRIPTION: Logs user out
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }
    

// DESCRIPTION: Displays error
        private void displayError(string errorMessage)
        {
            lblError.ForeColor = Color.Red;
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }
        
        private void displaySuccess(string message)
        {
            lblError.ForeColor = Color.Green;
            lblError.Text = message;
            lblError.Visible = true;
        }

// DESCRIPTION return to menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeemgmtDataSet.role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.employeemgmtDataSet.role);
            // TODO: This line of code loads data into the 'employeemgmtDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.employeemgmtDataSet.department);


        }

        // DESCRIPTION: Validates updated information and updates data in DB
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            Utilities checkEmail = new Utilities();

            // check all fields are valid
            if(string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                displayError("User ID of employee is required");
            }
            // check first name is entered
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                displayError("First name is required");
            }
            // check that last name is entered
            else if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                displayError("Last name is required");
            }
            // check that address line 1 is entered
            else if (string.IsNullOrEmpty(txtAddress1.Text))
            {
                displayError("Street address is required");
            }
            //check that city is entered
            else if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                displayError("City is required");
            }
            // check that state is selected
            else if (cBoxStates.SelectedIndex == -1)
            {
                displayError("State is required");
            }
            // check that zip code is entered
            else if (string.IsNullOrWhiteSpace(txtZIP.Text))
            {
                displayError("ZIP code is required");
            }
            // checks ZIP code is a number
            else if (!(int.TryParse(txtZIP.Text, out ZIPInt)))
            {
                displayError("Invalid ZIP code");
            }
            else if (txtZIP.TextLength < 5)
            {
                displayError("Zip code must have 5 numbers");
            }
            // check that payRate is entered
            else if(string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                displayError("Pay Rate is required");
            }
            // check that payRate is in a valid format
            else if(!(double.TryParse(txtSalary.Text, out salaryDouble)))
            {
                displayError("Pay Rate must be a number");
            }
            // check that email is entered
            else if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                displayError("E-mail address is required");
            }    
            // check that email is in a valid format
            else if(!(checkEmail.isValidEmail(txtEmail.Text)))
            {
                displayError("E-mail address is in an invalid format");
            }
            else
            {
                // if employee is in HR
                if(userInfo.depID == 1)
                {
                    // if end date was updated
                    if (endDatePicker.Format != DateTimePickerFormat.Custom)
                    {  
                        // deactivate login
                        manageAdmin.deactivateLogin(userInfo.empID);   
                    }
                }
                // update user object
                userInfo.address1 = txtAddress1.Text;
                userInfo.address2 = txtAddress2.Text;
                userInfo.city = txtCity.Text;
                userInfo.state = cBoxStates.SelectedItem.ToString();
                userInfo.zip = ZIPInt;
                userInfo.firstName = txtFName.Text;
                userInfo.lastName = txtLName.Text;
                userInfo.email = txtEmail.Text;
                userInfo.roleID = Convert.ToInt32(cBoxRole.SelectedValue);
                userInfo.depID = Convert.ToInt32(cBoxDep.SelectedValue);
                userInfo.salary = Convert.ToDouble(txtSalary.Text);
                userInfo.hireDate = hireDateTimePicker.Value;
                if (endDatePicker.Format != DateTimePickerFormat.Custom)
                {
                    userInfo.endDate = endDatePicker.Value;
                }
                // update user row in database
                if (userInfo.updateUser(userInfo))
                {
                    // display success message
                    displaySuccess("Employee profile updated successfully");
                }
                else
                {
                    //something went wrong with the Database
                    displayError("Unable to update employee profile.");
                }
            }
        }

// DESCRIPTION: Conducts search for user ID profile
        private void btnSearch_Click(object sender, EventArgs e)
        {
            resetEndDate();
            lblError.Visible = false;
            Utilities verifyAccount = new Utilities();

            // check that userID is an int
            if (!(int.TryParse(txtUserID.Text, out empUserID)))
            {
                displayError("User ID must be an integer");
            }
            // check that userID exists
            else if (!(verifyAccount.empIDExists(empUserID)))
            {
                displayError("User ID does not exist");
            }
            // check that admin is not updating themselves
            else if (adminUserID == empUserID)
            { displayError("An administrator may not update their own account"); }

            else
            {

                // fill form fields with user info
                userInfo = new User(empUserID);
                txtFName.Text = userInfo.firstName;
                txtLName.Text = userInfo.lastName;
                txtAddress1.Text = userInfo.address1;
                txtAddress2.Text = userInfo.address2;
                txtCity.Text = userInfo.city;
                cBoxStates.SelectedItem = userInfo.state;
                txtZIP.Text = userInfo.zip.ToString();
                txtSalary.Text = userInfo.salary.ToString();
                txtEmail.Text = userInfo.email;
                cBoxDep.SelectedValue = userInfo.depID;
                cBoxRole.SelectedValue = userInfo.roleID;
                hireDateTimePicker.Value = (DateTime)userInfo.hireDate; 
                if(userInfo.endDate != null)
                {
                    endDatePicker.Value = (DateTime)userInfo.hireDate;
                }

                btnDelete.Visible = true;
                btnSave.Visible = true;
            }
        }

        // DESCRIPTION: Clears out end date datetime picker if no end date is specified
        public void resetEndDate()
        {
            endDatePicker.CustomFormat = " ";
            endDatePicker.Format = DateTimePickerFormat.Custom;
        }

        public void clearFields()
        {
            txtUserID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            cBoxStates.SelectedIndex = -1;
            cBoxRole.SelectedIndex = -1;
            cBoxDep.SelectedIndex = -1;
            txtZIP.Clear();
            resetEndDate();
            txtSalary.Clear();
            hireDateTimePicker.Value = DateTime.Now.Date;
        }
        // DESCRIPTION: sets datetime picker format if a date is picked
        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDatePicker.Format = DateTimePickerFormat.Long;
        }

        // DESCRIPTION: Deletes employee profile from database. Deletes login record if employee is in HR
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool deleteLogin = false;
            int deleteEmpID = userInfo.empID;
            if(userInfo.depID == 1)
            {
                deleteLogin = true;
            }
            if (deleteLogin == true)
            {
                DBConnect deleteLoginConn = new DBConnect();
                MySqlCommand deleteLoginCmd = new MySqlCommand(@" DELETE FROM employeemgmt.login
                                                                      WHERE loginEmployeeID = @empID");
                deleteLoginCmd.Parameters.Add("@empID", MySqlDbType.Int32).Value = deleteEmpID;
                if (deleteLoginConn.NonQuery(deleteLoginCmd) > 0)
                {
                    clearFields();
                    displaySuccess("Employee record and login record deleted successfully");
                }
                else
                {
                    displayError("Employee record deleted. Error deleting login record");
                }
            }
            DBConnect deleteEmpConn = new DBConnect();
            MySqlCommand deleteEmpCmd = new MySqlCommand(@"DELETE FROM employeemgmt.employee
                                                           WHERE employeeID = @empID;");
            deleteEmpCmd.Parameters.Add("@empID", MySqlDbType.Int32).Value = deleteEmpID;
            if(deleteEmpConn.NonQuery(deleteEmpCmd) > 0)
            {
                    clearFields();
                    displaySuccess("Employee record deleted successfully");
                
            }
            else
            {
                displayError("Error deleting employee record");
            }

        }
    }
} 
