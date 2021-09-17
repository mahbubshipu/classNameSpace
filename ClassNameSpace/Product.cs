using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNameSpace
{
    public class Product
    {
        public string ProductName;
        public string ProductType;
        private string _category;

        private string Category
        {
            get
            {
                if (_category == null)
                    return string.Empty;
                else
                    return _category;

            }
            set
            {
                if (value == null)
                    _category= string.Empty;
                else
                    _category= value;
            }
        }

    }
}
