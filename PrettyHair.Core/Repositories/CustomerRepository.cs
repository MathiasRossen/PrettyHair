using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Entities;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.Core.Repositories
{
    internal class CustomerRepository
    {
        private Dictionary<long, ICustomer> Customers = new Dictionary<long, ICustomer>();
        private long ID;

        public Dictionary<long, ICustomer> GetAllCustomers()
        {
            return Customers;
        }

        public void CreateCustomer(ICustomer customer)
        {
            AddCustomer(customer, NextID());
        }

        public void RemoveCustomerByID(long ID)
        {
            Customers.Remove(ID);
        }

        public void Clear()
        {
            Customers.Clear();
        }

        public bool CustomerExistFromID(long ID)
        {
            return Customers.ContainsKey(ID);
        }

        public ICustomer GetCustomerByID(long ID)
        {
            return Customers[ID];
        }

        private long NextID()
        {
            return ++ID;
        }

        private void AddCustomer(ICustomer customer, long ID)
        {
            Customers.Add(ID, customer);
        }
    }
}
