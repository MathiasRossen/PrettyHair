using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core;
using PrettyHair.Domain.Interfaces;
using PrettyHair.Domain.Entities;
using System.Collections.ObjectModel;

namespace PrettyHair.UI.ViewModel
{
    public class CustomersViewModel
    {
        private CoreFacade coreFacade = CoreFacade.Instance;

        private ObservableCollection<ICustomer> testCollection = new ObservableCollection<ICustomer>();
        public ObservableCollection<ICustomer> CustomerCollection
        {
            //get { return new ObservableCollection<ICustomer>(coreFacade.GetCustomers()); }
            get { return testCollection; }
        }

        public CustomersViewModel()
        {
            testCollection.Add(new Customer("Hans", "Hansen", 1));
            testCollection.Add(new Customer("Peter", "Petersen", 2));
            testCollection.Add(new Customer("Jens", "Jensen", 3));
            testCollection.Add(new Customer("Kim", "Fuhrer", 4));
            testCollection.Add(new Customer("Søren", "Hansen", 5));
        }
    }
}
