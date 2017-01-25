using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.Core.Entities
{
    public class Customer : ICustomer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FullName
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }
        public long CustomerId { get; private set; }

        public Customer(string f, string l, long customerId)
        {
            Firstname = f;
            Lastname = l;
            CustomerId = customerId;
        }

        public override string ToString()
        {
            return "[Name: " + Firstname + " " + Lastname + "]";
        }
    }
}
