using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Domain.Entities;
using PrettyHair.Domain.Interfaces;

namespace PrettyHair.DAL.Repositories
{
    internal class OrderStorage
    {
        private static volatile OrderStorage instance;
        private static object padLock = new object();

        private List<IOrder> orderCollection;
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

        public List<IOrder> OrderCollection
        {
            get { return orderCollection; }
        }

        private OrderStorage()
        {
            orderCollection = new List<IOrder>();
            keyGen = new KeyFactory(KeyType.Next).KeyCreator();

            orderCollection.Add(new Order(new DateTime(2017, 2, 5), new DateTime(2017, 1, 28), 1, keyGen.NextKey));
            orderCollection.Add(new Order(new DateTime(2017, 1, 30), new DateTime(2017, 1, 24), 3, keyGen.NextKey));
            orderCollection.Add(new Order(new DateTime(2017, 1, 25), new DateTime(2017, 1, 20), 3, keyGen.NextKey));
            orderCollection.Add(new Order(new DateTime(2017, 2, 12), new DateTime(2017, 1, 23), 2, keyGen.NextKey));
        }

        public void AddOrder(IOrder order)
        {
            orderCollection.Add(order);
        }

        public void DeleteOrderById(long id)
        {
            orderCollection.RemoveAll(x => x.OrderId == id);
        }

        public void EditOrder(long id, DateTime orderDate, DateTime deliveryDate)
        {
            orderCollection.Find(x => x.OrderId == id).OrderDate = orderDate;
            orderCollection.Find(x => x.OrderId == id).DeliveryDate = deliveryDate;
        }

        public void ProcessOrder(long id)
        {
            orderCollection.Find(x => x.OrderId == id).Processed = true;
        }
    }
}
