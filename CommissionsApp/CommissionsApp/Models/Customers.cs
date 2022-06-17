using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommissionsApp.Models
{
    public class Customers
    {
        private string _Name;

        public Customers(string name)
        {
            _Name = name;
        }

        public string Name { get { return _Name; } set { _Name = value; } }

    }
}
