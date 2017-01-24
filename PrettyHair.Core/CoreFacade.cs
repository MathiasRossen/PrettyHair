using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Interfaces;
using PrettyHair.Core.Repositories;
using PrettyHair.Core.Entities;

namespace PrettyHair.Core
{
    public class CoreFacade : IFacade
    {
        private static volatile CoreFacade instance;
        private static object padLock;

        CustomerRepository cr;
        OrderRepository or;
        ItemRepository ir;

        public static CoreFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new CoreFacade();
                        }
                    }
                }
                return instance;
            }
        }

        private CoreFacade()
        {
            cr = new CustomerRepository();
            or = new OrderRepository();
            ir = new ItemRepository();
        }

        public void AddCustomer(string firstName, string lastName)
        {
            cr.CreateCustomer(new Customer(firstName, lastName));  
        }

        public void AddItem(string name, string description, double price, int amount)
        {
            ir.AddItems(name, description, price, amount, 1);
        }

        public void CreateOrder(DateTime orderDate, DateTime deliveryDate, int customerID)
        {
            or.CreateOrder(new Order(deliveryDate, orderDate, customerID));
        }

        public Dictionary<int,ICustomer> GetCustomers()
        {
            return cr.GetAllCustomers();
        }

        public Dictionary<int, IItem> GetItems()
        {
            return ir.GetItems();
        }

        public Dictionary<long,IOrder> GetOrders()
        {
            return or.GetAllOrders(); 
        }

        public void RemoveItemById(int id)
        {
            ir.RemoveItemByID(id);
        }

        public void RemoveOrderById(int id)
        {
            or.RemoveByID(id);
        }
    }
}
