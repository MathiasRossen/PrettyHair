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
    public class ItemsViewModel
    {
        private CoreFacade coreFacade = CoreFacade.Instance;

        private ObservableCollection<IItem> testCollection = new ObservableCollection<IItem>();
        public ObservableCollection<IItem> ItemsCollection
        {
            //get { return new ObservableCollection<ICustomer>(coreFacade.GetCustomers()); }
            get { return testCollection; }
        }

        public ItemsViewModel()
        {
            testCollection.Add(new Item("Thing", "A thing", 2.4, 5, 1));
            testCollection.Add(new Item("Thing", "Another  thing", 2.4, 5, 2));

        }
    }
}
