﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Entities;
using PrettyHair.Core.Interfaces;
using System.Collections.ObjectModel;

namespace PrettyHair.Core.Repositories
{
    internal class CustomerRepository
    {
        private List<ICustomer> Customers = new List<ICustomer>();
        
        private long ID;

        public List<ICustomer> GetAllCustomers()
        {
            return Customers;
        }

        public void RemoveCustomerByID(int ID)
        {
            Customers.RemoveAt(ID);
        }

        public void Clear()
        {
            Customers.Clear();
        }

        public bool CustomerExistFromID(long ID)
        {
            return Customers.Exists(x => x.CustomerId == ID);
        }

        public ICustomer GetCustomerByID(long ID)
        {
            return Customers.Find(x => x.CustomerId == ID);
        }

        private long NextID()
        {
            return ++ID;
        }

        private void AddCustomer(ICustomer customer)
        {
            Customers.Add(customer);
        }
    }
}
