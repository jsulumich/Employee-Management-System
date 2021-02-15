using Human_Relations;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;

public class User
{
    public int empID;
    public string firstName;
    public string lastName;
    public string email;
    public DateTime? hireDate;
    public DateTime? endDate;
    public double salary;
    public int roleID;
    public int depID;
    public string address1;
    public string address2;
    public string city;
    public string state;
    public int zip;


//DESCRIPTION: populates user object with employee information
    public User(int employeeID)
    {
        // declare and parameterize mySQL Command

        MySqlCommand cmd = new MySqlCommand("SELECT * FROM employeemgmt.employee WHERE employeeID = @empID");
        cmd.Parameters.Add("@empID", MySqlDbType.Int32).Value = employeeID;

        // connect to database
        DBConnect UserProfileConn = new DBConnect();

        //Create a data reader and Execute the command
        MySqlDataReader dataReader = UserProfileConn.ExecuteReader(cmd);

        //Read the data and store them in the list
        while (dataReader.Read())
        {
            empID = Convert.ToInt32(dataReader["employeeID"]);
            firstName = dataReader["firstName"].ToString();
            lastName = dataReader["lastName"].ToString();
            email = dataReader["email"].ToString();
            hireDate = Convert.ToDateTime(dataReader["hireDate"]);
            if(dataReader["endDate"] == DBNull.Value) //cannot convert null to DateTime
            {
                endDate = null;
            }
            else
            {
                endDate = Convert.ToDateTime(dataReader["endDate"]);
            }
            salary = Convert.ToDouble(dataReader["salary"]);
            roleID = Convert.ToInt32(dataReader["roleID"]);
            depID = Convert.ToInt32(dataReader["depID"]);
            address1 = Convert.ToString(dataReader["addressLine1"]);
            address2 = Convert.ToString(dataReader["addressLine2"]);
            city = Convert.ToString(dataReader["city"]);
            state = Convert.ToString(dataReader["state"]);
             zip = Convert.ToInt32(dataReader["zip"]);

        }

        //close Data Reader
        dataReader.Close();
    }

    // DESCRIPTION: updates information on user record
    public bool updateUser(User userinfo)
    {
        DBConnect updateUserConn = new DBConnect();
        MySqlCommand updateUserCmd = new MySqlCommand(@"UPDATE employeemgmt.employee
                                                        SET
                                                        firstName  = @firstName,
                                                        lastName = @lastName,
                                                        addressLine1 = @address1,
                                                        addressLine2 = @address2,
                                                        city = @city,
                                                        state = @state,
                                                        zip = @zip,
                                                        email = @email,
                                                        hireDate = @hireDate,
                                                        endDate = @endDate,
                                                        depID = @depID,
                                                        roleID = @roleID, 
                                                        salary = @salary
                                                        WHERE employeeID = @empID;");
        updateUserCmd.Parameters.Add("@firstName", MySqlDbType.VarChar, 45).Value = userinfo.firstName;
        updateUserCmd.Parameters.Add("@lastName", MySqlDbType.VarChar, 45).Value = userinfo.lastName;
        updateUserCmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = userinfo.email;
        updateUserCmd.Parameters.Add("@hireDate", MySqlDbType.DateTime).Value = userinfo.hireDate;
        updateUserCmd.Parameters.Add("@endDate", MySqlDbType.DateTime).Value = userinfo.endDate;
        updateUserCmd.Parameters.Add("@salary", MySqlDbType.Decimal).Value = userinfo.salary;
        updateUserCmd.Parameters.Add("@roleID", MySqlDbType.Int32).Value = userinfo.roleID;
        updateUserCmd.Parameters.Add("@depID", MySqlDbType.Int32).Value = userinfo.depID;
        updateUserCmd.Parameters.Add("@address1", MySqlDbType.VarChar, 45).Value = userinfo.address1;
        updateUserCmd.Parameters.Add("@address2", MySqlDbType.VarChar, 45).Value = userinfo.address2;
        updateUserCmd.Parameters.Add("@city", MySqlDbType.VarChar, 45).Value = userinfo.city;
        updateUserCmd.Parameters.Add("@state", MySqlDbType.VarChar, 2).Value = userinfo.state;
        updateUserCmd.Parameters.Add("@zip", MySqlDbType.Int32).Value = userinfo.zip;
        updateUserCmd.Parameters.Add("@empID", MySqlDbType.Int32).Value = userinfo.empID;

        if (updateUserConn.NonQuery(updateUserCmd) > 0)
            return true;
        return false;
    }

}

