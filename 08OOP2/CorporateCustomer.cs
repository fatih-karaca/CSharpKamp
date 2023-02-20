using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08OOP2
{
    internal class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
