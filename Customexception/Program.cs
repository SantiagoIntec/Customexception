using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginInformation loginInformation = new LoginInformation();
            Console.Write("ENTER Username: ");
            loginInformation.Username = Console.ReadLine();

            Console.Write("ENTER Password: ");
            loginInformation.Password = Console.ReadLine();
            UserValidation validation = new UserValidation();

            try
            {
                string result = validation.ValidateLoginData(loginInformation);
                Console.WriteLine(result);
            }
            catch (UserNameExeption ex) { Console.WriteLine(ex.Message); }
            catch (PasswordExeption ex) { Console.WriteLine(ex.Message); }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();
        }
    }
}
