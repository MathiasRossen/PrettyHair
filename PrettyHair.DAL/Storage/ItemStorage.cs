using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PrettyHair.Domain.Interfaces;
using PrettyHair.Domain.Entities;

namespace PrettyHair.DAL.Repositories
{
    internal class ItemStorage
    {
        private static volatile ItemStorage instance;
        private static object padLock = new object();

        private List<IItem> itemCollection;
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

        public List<IItem> ItemCollection
        {
            get { return itemCollection; }
        }

        private ItemStorage()
        {
            itemCollection = new List<IItem>();
            keyGen = new KeyFactory(KeyType.Next).KeyCreator();

            itemCollection.Add(new Item("Saks", "Saks til hår", 299.95, 10, keyGen.NextKey));
            itemCollection.Add(new Item("Trimmer", "Mach 3 turbo!", 349.95, 5, keyGen.NextKey));
            itemCollection.Add(new Item("Shampoo", "Sanex", 29.95, 52, keyGen.NextKey));
            itemCollection.Add(new Item("Damplokomotiv", "Gammelt tog fra 1902", 1199995.95, 1, keyGen.NextKey));
            itemCollection.Add(new Item("Dank weed", "Don't let your memes be dreams!", 420, 9001, keyGen.NextKey));
            itemCollection.Add(new Item("Hår Børste", "Til håret!", 10, 3, keyGen.NextKey));
        }

        public void AddItem(IItem item)
        {
            itemCollection.Add(item);
        }

        public void DeleteItemById(long id)
        {
            itemCollection.RemoveAll(x => x.ItemId == id);
        }

        public void EditItem(long id, string name, string description, double price, int amount)
        {
            itemCollection.Find(x => x.ItemId == id).Name = name;
            itemCollection.Find(x => x.ItemId == id).Description = description;
            itemCollection.Find(x => x.ItemId == id).Price = price;
            itemCollection.Find(x => x.ItemId == id).Amount = amount;
        }
    }
}
