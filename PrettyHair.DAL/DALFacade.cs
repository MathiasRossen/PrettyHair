using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.DAL.Repositories;
using System.Data.SqlClient;
using System.Data;
using PrettyHair.Domain.Interfaces;

namespace PrettyHair.DAL
{
    public class DALFacade
    {
        private static volatile DALFacade instance;
        private static object padLock = new object();

        ItemStorage itemStorage;
        CustomerStorage customerStorage;
        OrderStorage orderStorage;        

        public static DALFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new DALFacade();
                        }
                    }
                }
                return instance;
            }
        }

        public List<ICustomer> CustomerCollection
        {
            get
            {
                return customerStorage.CustomerCollection;
            }
        }

        public List<IItem> ItemCollection
        {
            get
            {
                return itemStorage.ItemCollection;
            }
        }

        public List<IOrder> OrderCollection
        {
            get
            {
                return orderStorage.OrderCollection;
            }
        }

        private DALFacade()
        {
            itemStorage = ItemStorage.Instance;
            customerStorage = CustomerStorage.Instance;
            orderStorage = OrderStorage.Instance;
        }

        public void AddCustomer(ICustomer customer)
        {
            customerStorage.AddCustomer(customer);
        }

        public void AddItem(IItem item)
        {
            itemStorage.AddItem(item);
        }

        public void AddOrder(IOrder order)
        {
            orderStorage.AddOrder(order);
        }

        public void EditCustomer(long index, string firstName, string lastName)
        {
            customerStorage.EditCustomer(index, firstName, lastName);
        }

        public void EditItem(long index, string name, string description, double price, int amount)
        {
            itemStorage.EditItem(index, name, description, price, amount);
        }

        public void EditOrder(long index, DateTime orderDate, DateTime deliveryDate)
        {
            orderStorage.EditOrder(index, orderDate, deliveryDate);
        }

        public void DeleteCustomer(long index)
        {
            customerStorage.DeleteCustomerById(index);
        }

        public void DeleteItem(long index)
        {
            itemStorage.DeleteItemById(index);
        }

        public void DeleteOrder(long index)
        {
            orderStorage.DeleteOrderById(index);
        }

        public void ProcessOrder(long index)
        {
            orderStorage.ProcessOrder(index);
        }
    }
}
