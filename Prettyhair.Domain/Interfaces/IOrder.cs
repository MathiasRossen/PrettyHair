﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Domain.Interfaces
{
    public interface IOrder
    {
        DateTime OrderDate    { get; set; }
        DateTime DeliveryDate { get; set; }
        long     CustomerID   { get; set; }
        bool     Processed    { get; set; }
        long OrderId { get; }
    }
}
