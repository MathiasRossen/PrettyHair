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
        private static object padLock = new object();

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
            //cr.CreateCustomer(new Customer(firstName, lastName));  
        }

        public void AddItem(string name, string description, double price, int amount)
        {
            //ir.AddItems(name, description, price, amount, 1);
        }

        public void CreateOrder(DateTime orderDate, DateTime deliveryDate, long customerID)
        {
            //or.CreateOrder(new Order(deliveryDate, orderDate, customerID));
        }

        public List<ICustomer> GetCustomers()
        {
            return cr.GetAllCustomers();
        }

        public List<IItem> GetItems()
        {
            return ir.GetItems();
        }

        public List<IOrder> GetOrders()
        {
            return or.GetAllOrders(); 
        }

        public void RemoveItemById(long id)
        {
            ir.RemoveItemByID(id);
        }

        public void RemoveOrderById(long id)
        {
            or.RemoveByID(id);
        }
    }
}
