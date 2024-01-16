using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customexception
{
    public  class UserNameExeption : Exception
    {        

        public UserNameExeption()
        {
            
        }


        public UserNameExeption(string message):base(message) 
        {
            
        }

        public override string Message
        {
        
                get { return "Username was not in the correct format"; }
            }
        
    }
}
