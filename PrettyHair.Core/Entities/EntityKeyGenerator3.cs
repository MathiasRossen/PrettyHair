using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Core.Entities
{
    class EntityKeyGenerator3 : IEntityKeyGenerator
    {
        private static volatile EntityKeyGenerator3 instance;
        private static object syncRoot = new object();
        private long nextKey;
        private Random rand = new Random();

        public static EntityKeyGenerator3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new EntityKeyGenerator3();
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
                 return rand.Next(1, 100000);
            }
        }

        private EntityKeyGenerator3()
        {

        }

    }

}
