using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Domain.Entities;
using PrettyHair.Domain.Interfaces;
using PrettyHair.DAL;

namespace PrettyHair.Core.Repositories
{
    internal class OrderRepository
    {
        private List<IOrder> Orders = new List<IOrder>();
        private DALFacade DALF = DALFacade.Instance;

        public List<IOrder> GetAllOrders()
        {
            RefreshOrders();
            return Orders;
        }

        public void RefreshOrders()
        {
            Orders.Clear();
            Orders = DALF.OrderCollection;

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
