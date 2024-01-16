using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customexception
{
    public class PasswordExeption : Exception
    {
        public PasswordExeption()
        {

        }

        public PasswordExeption(string message) : base(message)
        {

        }

        public override string Message
        {
            get { return "Password was not in the correct format"; }
        }

    }
   
}
