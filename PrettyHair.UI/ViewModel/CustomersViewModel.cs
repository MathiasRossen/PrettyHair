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
        public ObservableCollection<ICustomer> CustomerCollection
        {
            get { return new ObservableCollection<ICustomer>(coreFacade.GetCustomers()); }
        }

    }
}
