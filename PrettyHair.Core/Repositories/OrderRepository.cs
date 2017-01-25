using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Entities;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.Core.Repositories
{
    internal class OrderRepository
    {
        private List<IOrder> Orders = new List<IOrder>();

        public List<IOrder> GetAllOrders()
        {
            return Orders;
        }

        private void AddOrder(IOrder order)
        {
            Orders.Add(order);
        }
        
        public void RemoveByID(long ID)
        {
            Orders.RemoveAll(x => x.CustomerID == ID);
        }

        public void Clear()
        {
            Orders.Clear();
        }

        public IOrder GetOrderByID(long ID)
        {
            return Orders.Find(x => x.CustomerID == ID);
        }
    }
}
