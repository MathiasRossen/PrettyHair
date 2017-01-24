using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Entities;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.DAL.Repositories
{
    internal class OrderStorage
    {
        private static volatile OrderStorage instance;
        private static object padLock = new object();

        private Dictionary<long, IOrder> orderCollection;
        private IEntityKeyGenerator keyGen;

        public static OrderStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new OrderStorage();
                        }
                    }
                }
                return instance;
            }
        }

        public Dictionary<long, IOrder> OrderCollection
        {
            get { return orderCollection; }
        }

        private OrderStorage()
        {
            orderCollection = new Dictionary<long, IOrder>();
            keyGen = new KeyFactory(KeyType.Next).KeyCreator();

            orderCollection.Add(keyGen.NextKey, new Order(new DateTime(2017, 2, 5), new DateTime(2017, 1, 28), keyGen.NextKey));
            orderCollection.Add(keyGen.NextKey, new Order(new DateTime(2017, 1, 30), new DateTime(2017, 1, 24), keyGen.NextKey));
            orderCollection.Add(keyGen.NextKey, new Order(new DateTime(2017, 1, 25), new DateTime(2017, 1, 20), keyGen.NextKey));
            orderCollection.Add(keyGen.NextKey, new Order(new DateTime(2017, 2, 12), new DateTime(2017, 1, 23), keyGen.NextKey));
        }

        public void AddOrder(IOrder order)
        {
            orderCollection.Add(keyGen.NextKey, order);
        }

        public void DeleteOrderById(long index)
        {
            orderCollection.Remove(index);
        }

        public void EditOrder(long index, DateTime orderDate, DateTime deliveryDate)
        {
            orderCollection[index].OrderDate = orderDate;
            orderCollection[index].DeliveryDate = deliveryDate;
        }

        public void ProcessOrder(long index)
        {
            orderCollection[index].Processed = true;
        }
    }
}
