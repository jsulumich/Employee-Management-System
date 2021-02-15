using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Human_Relations.Pages
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {     
            // loads data into the 'employeemgmtDataSet.role' table. 
            this.roleTableAdapter.Fill(this.employeemgmtDataSet.role);
            // loads data into the 'employeemgmtDataSet.department' table
            this.departmentTableAdapter.Fill(this.employeemgmtDataSet.department);

        }

        // dataTable object and bindingSource declarations
        DBConnect reportConn = new DBConnect();
        DataTable reportData = new DataTable();
        BindingSource reportBindingSource = new BindingSource();

// DESCRIPTION: Fills datagrid with report of employees in selected role
        private void btnRole_Click(object sender, EventArgs e)
        {
            if (cBoxRole.SelectedIndex != -1)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = (@"SELECT
                                        e.employeeID AS 'Employee ID',
                                        concat(e.firstName, ' ' , e.lastName) AS 'Name',
                                        d.departmentName AS 'Department',
                                        e.email as 'email Address',
                                        e.salary AS 'Salary',
                                        e.hireDate AS 'Hire Date',
                                        e.endDate as 'Last Date'
                                        from employeemgmt.employee e
                                        JOIN employeemgmt.department d
	                                        on d.departmentID = e.depID
                                        where e.roleID = @roleID");   
                    cmd.Parameters.Add("@roleID", MySqlDbType.Int32).Value = cBoxRole.SelectedValue;

                    reportData = reportConn.ExecuteDataTable(cmd);
                    reportBindingSource.DataSource = reportData;
                    reportDataGrid.DataSource = reportBindingSource;
                    reportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    lblError.Visible = false;
                }
                catch (Exception ex)
                {
                    displayError("Unable to generate report. " + ex);
                }
            }
            else
            {
                // if no role selected
                displayError("No role selected.");
            }
        }     

// DESCRIPTION: Fills datagrid with report of employees in selected department

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            if (cBoxDepartment.SelectedIndex != -1)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = (@"SELECT
                                        e.employeeID AS 'Employee ID',
                                        concat(e.firstName, ' ' , e.lastName) AS 'Name',
                                        r.roleName AS 'Role',
                                        e.email as 'email Address',
                                        e.salary AS 'Salary',
                                        e.hireDate AS 'Hire Date',
                                        e.endDate as 'Last Date'
                                        from employeemgmt.employee e
                                        JOIN employeemgmt.role r
	                                        on r.roleID = e.roleID
                                        where e.depID = @departmentID");
                    cmd.Parameters.Add("@departmentID", MySqlDbType.Int32).Value = cBoxDepartment.SelectedValue;

                    reportData = reportConn.ExecuteDataTable(cmd);
                    reportBindingSource.DataSource = reportData;
                    reportDataGrid.DataSource = reportBindingSource;
                    reportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    lblError.Visible = false;

                }
                catch (Exception ex)
                {
                    displayError("Unable to generate report. " + ex);
                }

            }
            else
            {
                // if no department selected
                displayError("No department selected.");
            }
        }

//DESCRIPTION: Logs user out of system
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

//DESCRIPTION: Returns to menu screen

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//DESCRIPTION: Utility function to display error message
        public void displayError(string error)
        {
            lblError.Text = "Error: " + error;
            lblError.Visible = true;
        }
    }
}
