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
    public class OrdersViewModel
    {
        private CoreFacade coreFacade = CoreFacade.Instance;

        private ObservableCollection<IOrder> testCollection = new ObservableCollection<IOrder>();
        public ObservableCollection<IOrder> OrdersCollection
        {
            //get { return new ObservableCollection<ICustomer>(coreFacade.GetCustomers()); }
            get { return testCollection; }
        }

        public OrdersViewModel()
        {
            testCollection.Add(new Order(DateTime.Now.AddDays(1), DateTime.Now, 65, 66));
        }
    }
}
