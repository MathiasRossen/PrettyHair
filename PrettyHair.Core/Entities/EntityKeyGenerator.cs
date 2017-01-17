using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Core.Entities
{
    class EntityKeyGenerator : IEntityKeyGenerator
    {
        private static volatile EntityKeyGenerator instance;
        private static object syncRoot = new object();
        private long nextKey;

        public static EntityKeyGenerator Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (syncRoot)
                    {
                        if( instance == null)
                        {
                            instance = new EntityKeyGenerator();
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
                return ++nextKey;
            }
        }

        private EntityKeyGenerator()
        {

        }

    }
}
