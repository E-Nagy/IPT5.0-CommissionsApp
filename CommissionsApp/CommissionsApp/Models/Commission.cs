using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommissionsApp.Models
{
    public class Commissions 
    {

        public Commissions()
        {

        }

        public Commissions(string title, string customer, DateTime takenOn, double price, string additionalInfo)
        {
            
        }

        public string Title { get; set; }

        public string Customer { get; set; }

        public DateTime TakenOn { get; set; }

        public double Price { get; set; }   

        public String additionalInfo { get; set; }

    }
}
