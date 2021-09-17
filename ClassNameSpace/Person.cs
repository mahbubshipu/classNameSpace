using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNameSpace
{
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Designation { get; set; }
        public string District { get; set; }
        public string getName()
        {
            return FName +" " +LName;
        }
    }
}
