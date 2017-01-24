using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core;
using PrettyHair.Core.Interfaces;
using PrettyHair.Core.Entities;

namespace PrettyHair.UI.ViewModel
{
    public class CustomersViewModel
    {
        private CoreFacade coreFacade = CoreFacade.Instance;
        public Dictionary<long, ICustomer> CustomerCollection
        {
            get { return coreFacade.GetCustomers(); }
        }
    }
}
