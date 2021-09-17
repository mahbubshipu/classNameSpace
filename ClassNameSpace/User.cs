using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNameSpace
{
    public abstract class User
    {
        public void Login(string userName, string Password)
        {

        }
        public abstract void Registration(string userName, string Password, string FullName);
    }
}
