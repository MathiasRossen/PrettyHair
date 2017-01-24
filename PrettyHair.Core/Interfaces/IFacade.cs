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
        Dictionary<int,ICustomer> GetCustomers();

        Dictionary<int,IItem> GetItems();

        Dictionary< long,IOrder> GetOrders();

        void AddCustomer(string firstName, string lastName);

        void AddItem(string name, string description, double price, int amount);

        void RemoveItemById(int id);

        void CreateOrder(DateTime orderDate, DateTime deliveryDate, int customerID);

        void RemoveOrderById(int id);

    }
}
