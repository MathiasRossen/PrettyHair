using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Domain.Interfaces
{
    public interface ICustomer
    {
        string Firstname { get; set; }
        string Lastname  { get; set; }
        long CustomerId { get; }
    }
}
