using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Human_Relations
{
    class Utilities
    {
        // DESCRIPTION: Checks to see if user-entered email address is in valid format
        public bool isValidEmail(string email)
        {
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        // DESCRIPTION: Checks to see if user-entered email exists 
        public bool emailExists(string email)
        {
            // declare and parameterize mySQL Command

            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from employeemgmt.employee where email = @email");
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = email;

            // connect to database
            DBConnect emailExistsConn = new DBConnect();

            // if records exist
            if (emailExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Checks to see if user-entered username exists

        public int getUserIDFromEmail(string email)
        {
            DBConnect getUserIDConn = new DBConnect();
            MySqlCommand cmd = new MySqlCommand("SELECT employeeID from employeemgmt.employee where email = @email");
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = email;
            // if records exist
            int returnEmpID = -1;
            returnEmpID = getUserIDConn.intScalar(cmd);
            return returnEmpID;
        }
        public bool usernameExists(string username)
        {
            // declare and parameterize mySQL Command
            DBConnect usernameExistsConn = new DBConnect();
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from employeemgmt.login where username = @username");
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;
            // if records exist
            if (usernameExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }

        // DESCRIPTION: Checks to see if user ID exists
        public bool empIDExists(int empID)
        {
            // declare and parameterize mySQL Command
            MySqlCommand cmd = new MySqlCommand("SELECT Count(*) from employeemgmt.employee where employeeID = @empID");
            cmd.Parameters.Add("@empID", MySqlDbType.Int32).Value = empID;

            // connect to database
            DBConnect empIDExistsConn = new DBConnect();

            // if records exist
            if (empIDExistsConn.intScalar(cmd) > 0)
                return true;
            else
                return false;
        }
     
        // DESCRIPTION: Gets userID based on username
        public int getLoginEmpIDFromUsername(string username)
        {
            int loginEmpID = -1;
            DBConnect getUserIDFromUsernameConn = new DBConnect();
           
            // build query
            MySqlCommand cmd = new MySqlCommand("SELECT loginEmployeeID from employeemgmt.login where username = @username");
            cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = username;

            // assign value to variable
            loginEmpID = getUserIDFromUsernameConn.intScalar(cmd);
            return loginEmpID;
        }
    }
}
