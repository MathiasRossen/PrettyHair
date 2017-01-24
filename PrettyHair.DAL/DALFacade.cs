using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.DAL.Repositories;
using System.Data.SqlClient;
using System.Data;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.DAL
{
    public class DALFacade
    {
        private static volatile DALFacade _instance;
        private static object _padLock;
        private static string connectionstring = "DATABASE CONNECTION STRING";

        ItemRepository _itemRepo;

        private DALFacade()
        {
            _itemRepo = new ItemRepository();
        }

        public static DALFacade Instance
        {
            

            get
            {
                lock (_padLock)
                {
                    if (_instance == null)
                    {
                       _instance = new DALFacade();
                    }
                }
                return _instance;
            }
        }

        public IDictionary<int, IItem> RefreshItems()
        {
            IDictionary<int, IItem> temp = new Dictionary<int, IItem>();

            using (SqlConnection db = new SqlConnection(connectionstring))
            {
                db.Open();

                SqlCommand sql = new SqlCommand("SELECT * FROM ITEMS", db);
                sql.CommandType = CommandType.Text;

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //IItem item = new Item();
                        string name = reader["ItemName"].ToString();
                        string description = reader["ItemDesc"].ToString();
                        double price = (double)reader["ItemPrice"];
                        int quantity = (int)reader["ItemAmount"];

                        int itemId = (int)reader["ItemID"];

                        //_itemRepo.AddItems(name, description, price, quantity, itemId);
                    }
                }
            }
            return null;
        }
    }
}
