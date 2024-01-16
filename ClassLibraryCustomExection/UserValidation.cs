using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customexception
{
    public class UserValidation
    {
        public string ValidateLoginData(LoginInformation loginInformation)
        {
            if (!IsValidUsername(loginInformation.Username))
            {
                throw new UserNameExeption();
                //throw new Exception("Username was not in corret format");
            }

            if (!IsValidPassword(loginInformation.Password))
            {
                throw new PasswordExeption();
                //throw new Exception("Password was not in corret format");
            }
            return "Login was succesfull";
        }


        public bool IsValidUsername(string username)
        {
            
            if (string.IsNullOrEmpty(username)) { return false; }
            if (username.Length < 4 || username.Length > 20) { return false; }
            return true;
        }

        public bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) { return false; }
            if (password.Length < 4 || password.Length > 20) { return false; }
            return true;
        }
    }
}

