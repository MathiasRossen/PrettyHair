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
        public ObservableCollection<IOrder> OrdersCollection
        {
            get { return new ObservableCollection<IOrder>(coreFacade.GetOrders()); }
        }
    }
}
