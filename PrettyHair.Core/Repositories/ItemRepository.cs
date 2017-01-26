using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PrettyHair.Domain.Interfaces;
using PrettyHair.Domain.Entities;

namespace PrettyHair.Core.Repositories
{
    internal class ItemRepository
    {
        private List<IItem> Items = new List<IItem>();

        public ItemRepository()
        {

        }

        public List<IItem> GetItems()
        {
            return Items;
        }


        public void AddItems(string name, string description, double itemPrice, int quantity, long itemId)
        {
            IItem item = new Item();
            item.Name = name;
            item.Description = description;
            item.Price = itemPrice;
            item.Amount = quantity;
                  
            AddItem(item);
        
        }

        private void AddItem(IItem item)
        {
            Items.Add(item);
        }

        public void RemoveItemByID(long ID)
        {
        }

        public IItem GetItemByID(long ID)
        {
            return Items.Find(x => x.ItemId == ID);
        }

        public void Clear()
        {
            Items.Clear();
        }
    }
}
