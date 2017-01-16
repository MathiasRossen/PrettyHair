using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.Core
{
    internal interface IFacade
    {
        List<ICustomer> GetCustomers();

        List<IItem> GetItems();

        List<IOrder> GetOrders();

        void AddCustomer(string firstName, string lastName);

        void AddItem(string name, string description, double price, int amount);

        void RemoveItemById(int id);

        void CreateOrder(DateTime orderDate, DateTime deliveryDate, int customerID, bool Processed);

        void RemoveOrderById(int id);

    }
}
