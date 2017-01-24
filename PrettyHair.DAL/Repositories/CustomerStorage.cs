using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Entities;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.DAL.Repositories
{
    internal class CustomerStorage
    {
        private static volatile CustomerStorage instance;
        private static object padLock;

        private Dictionary<long, ICustomer> customerCollection;
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

        public Dictionary<long, ICustomer> CustomerCollection
        {
            get { return customerCollection; }
        }

        private CustomerStorage()
        {
            customerCollection = new Dictionary<long, ICustomer>();
            keyGen = new EntityKeyGeneratorNext();

            customerCollection.Add(keyGen.NextKey, new Customer("Per", "Hansen"));
            customerCollection.Add(keyGen.NextKey, new Customer("Lone", "Christensen"));
            customerCollection.Add(keyGen.NextKey, new Customer("Tyrone", "Jackson"));
            customerCollection.Add(keyGen.NextKey, new Customer("Kim", "Møller"));
            customerCollection.Add(keyGen.NextKey, new Customer("Nikolaj", "Grill"));
        }

        public void AddCustomer(ICustomer customer)
        {
            customerCollection.Add(keyGen.NextKey, customer);
        }

        public void DeleteCustomerById(long index)
        {
            customerCollection.Remove(index);
        }

        public void EditCustomer(long index, string firstName, string lastName)
        {
            customerCollection[index].Firstname = firstName;
            customerCollection[index].Lastname = lastName;
        }
    }
}
