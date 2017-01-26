using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Domain.Entities;
using PrettyHair.Domain.Interfaces;

namespace PrettyHair.DAL.Repositories
{
    internal class CustomerStorage
    {
        private static volatile CustomerStorage instance;
        private static object padLock = new object();

        private List<ICustomer> customerCollection;
        private IEntityKeyGenerator keyGen;

        public static CustomerStorage Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (padLock)
                    {
                        if(instance == null)
                        {
                            instance = new CustomerStorage();
                        }
                    }
                }
                return instance;
            }
        }

        public List<ICustomer> CustomerCollection
        {
            get { return customerCollection; }
        }

        private CustomerStorage()
        {
            customerCollection = new List<ICustomer>();
            keyGen = new KeyFactory(KeyType.Next).KeyCreator();

            customerCollection.Add(new Customer("Per", "Hansen", keyGen.NextKey));
            customerCollection.Add(new Customer("Lone", "Christensen", keyGen.NextKey));
            customerCollection.Add(new Customer("Tyrone", "Jackson", keyGen.NextKey));
            customerCollection.Add(new Customer("Kim", "Møller", keyGen.NextKey));
            customerCollection.Add(new Customer("Nikolaj", "Grill", keyGen.NextKey));
        }

        public void AddCustomer(ICustomer customer)
        {
            customerCollection.Add(customer);
        }

        public void DeleteCustomerById(long id)
        {
            customerCollection.RemoveAll(x => x.CustomerId == id);
        }

        public void EditCustomer(long id, string firstName, string lastName)
        {
            customerCollection.Find(x => x.CustomerId == id).Firstname = firstName;
            customerCollection.Find(x => x.CustomerId == id).Lastname = lastName;
        }
    }
}
