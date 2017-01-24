using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PrettyHair.Core.Interfaces;
using PrettyHair.Core.Entities;

namespace PrettyHair.DAL.Repositories
{
    internal class ItemStorage
    {
        private static volatile ItemStorage instance;
        private static object padLock = new object();

        private Dictionary<long, IItem> itemCollection;
        private IEntityKeyGenerator keyGen;

        public static ItemStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new ItemStorage();
                        }
                    }
                }
                return instance;
            }
        }

        public Dictionary<long, IItem> ItemCollection
        {
            get { return itemCollection; }
        }

        private ItemStorage()
        {
            itemCollection = new Dictionary<long, IItem>();
            keyGen = new KeyFactory(KeyType.Next).KeyCreator();

            itemCollection.Add(keyGen.NextKey, new Item("Saks", "Saks til hår", 299.95, 10));
            itemCollection.Add(keyGen.NextKey, new Item("Trimmer", "Mach 3 turbo!", 349.95, 5));
            itemCollection.Add(keyGen.NextKey, new Item("Shampoo", "Sanex", 29.95, 52));
            itemCollection.Add(keyGen.NextKey, new Item("Damplokomotiv", "Gammelt tog fra 1902", 1199995.95, 1));
            itemCollection.Add(keyGen.NextKey, new Item("Dank weed", "Don't let your memes be dreams!", 420, 9001));
            itemCollection.Add(keyGen.NextKey, new Item("Hår Børste", "Til håret!", 10, 3));
        }

        public void AddItem(IItem item)
        {
            itemCollection.Add(keyGen.NextKey, item);
        }

        public void DeleteItemById(long index)
        {
            itemCollection.Remove(index);
        }

        public void EditItem(long index, string name, string description, double price, int amount)
        {
            itemCollection[index].Name = name;
            itemCollection[index].Description = description;
            itemCollection[index].Price = price;
            itemCollection[index].Amount = amount;
        }
    }
}
