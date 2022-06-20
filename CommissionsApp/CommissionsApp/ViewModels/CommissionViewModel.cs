using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommissionsApp.Models;

namespace CommissionsApp.ViewModels
{
    internal class CommissionViewModel
    {
        private Commissions _Commissions;

        public CommissionViewModel()
        {
       
            _Commissions = new Commissions("Test1", "TestCustomer", DateTime.Now, 30.00, "");
        }

        public Commissions Commissions { get { return _Commissions; } }

        
        

    }
}
