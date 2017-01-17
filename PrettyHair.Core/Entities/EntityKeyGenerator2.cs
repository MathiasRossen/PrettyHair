using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Core.Entities
{
    class EntityKeyGenerator2 : IEntityKeyGenerator
    {
        private static volatile EntityKeyGenerator2 instance;
        private static object syncRoot = new object();
        private long nextKey;
        private DateTime dateKey;

        public static EntityKeyGenerator2 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new EntityKeyGenerator2();
                        }
                    }
                }
                return instance;
            }
        }

        public virtual long NextKey
        {
            get
            {
                dateKey = DateTime.Now;
                string outputString = ""+ dateKey.Year + dateKey.Month + dateKey.Day + dateKey.Hour + dateKey.Minute + dateKey.Second;
                return long.Parse(outputString);
            }
        }

        private EntityKeyGenerator2()
        {

        }

    }

}
