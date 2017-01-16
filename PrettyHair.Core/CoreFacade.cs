using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.Core
{
    public class CoreFacade : IFacade
    {
        public void AddCustomer(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public void AddItem(string name, string description, double price, int amount)
        {
            throw new NotImplementedException();
        }

        public void CreateOrder(DateTime orderDate, DateTime deliveryDate, int customerID, bool Processed)
        {
            throw new NotImplementedException();
        }

        public List<ICustomer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public List<IItem> GetItems()
        {
            throw new NotImplementedException();
        }

        public List<IOrder> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void RemoveItemById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrderById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
