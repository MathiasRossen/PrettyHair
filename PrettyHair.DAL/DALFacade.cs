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
        private static volatile DALFacade instance;
        private static object padLock;

        ItemStorage itemRepo;

        private DALFacade()
        {
            itemRepo = new ItemStorage();
        }

        public static DALFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new DALFacade();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
