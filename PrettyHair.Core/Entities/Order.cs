using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.Core.Entities
{
    public class Order : IOrder
    {
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public long CustomerID { get; set; }
        public bool Processed { get; set; }
        public long OrderId { get; private set; }

        public Order(DateTime deliverydate, DateTime orderdate, long cID, long orderId)
        {
            if ((DateTime.Compare(deliverydate, orderdate)) < 0)
                throw new ArgumentOutOfRangeException();

            DeliveryDate = deliverydate;
            OrderDate    = orderdate;
            CustomerID   = cID;
            Processed    = false;
            OrderId = orderId;
        }
    }
}
