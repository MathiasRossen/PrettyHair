using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Core.Interfaces
{
    internal interface IOrder
    {
        DateTime OrderDate    { get; set; }
        DateTime DeliveryDate { get; set; }
        int      CustomerID   { get; set; }
        bool     Processed    { get; set; }
    }
}
