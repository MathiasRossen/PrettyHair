using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Domain.Entities;
using PrettyHair.Domain.Interfaces;
using System.Collections.ObjectModel;
using PrettyHair.DAL;

namespace PrettyHair.Core.Repositories
{
    internal class CustomerRepository
    {
        private DALFacade DALF = DALFacade.Instance;
        private List<ICustomer> Customers = new List<ICustomer>();
        
        private long ID;

        public List<ICustomer> GetAllCustomers()
        {
            RefreshCustomers();
            return Customers;
        }

        public void RefreshCustomers()
        {
            Customers.Clear();
            Customers = DALF.CustomerCollection;
        }

        public ICustomer GetCustomerByID(long ID)
        {
            return Customers.Find(x => x.CustomerId == ID);
        }

        private void AddCustomer(ICustomer customer)
        {
            DALF.AddCustomer(customer);
        }
    }
}
