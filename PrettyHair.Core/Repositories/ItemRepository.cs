using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PrettyHair.Core.Interfaces;
using PrettyHair.Core.Entities;

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

        //public void RefreshItems()
        //{
        //    Clear();

        //    using (SqlConnection db = new SqlConnection(connectionstring))
        //    {
        //        db.Open();

        //        SqlCommand sql = new SqlCommand("SELECT * FROM ITEMS", db);
        //        sql.CommandType = CommandType.Text;

        //        SqlDataReader reader = sql.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                IItem item       = new Item();
        //                item.Name        = reader["ItemName"].ToString();
        //                item.Description = reader["ItemDesc"].ToString();
        //                item.Price       = (double)reader["ItemPrice"];
        //                item.Amount      = (int)reader["ItemAmount"];

        //                AddItem(item, (int)reader["ItemID"]);
        //            }
        //        }
        //    }
        //}

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
