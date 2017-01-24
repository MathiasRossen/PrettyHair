using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.DAL
{
    public class EntityKeyGeneratorNext : IEntityKeyGenerator
    {
        //private static volatile EntityKeyGeneratorNext instance;
        //private static object syncRoot = new object();
        private long nextKey;

        //public static EntityKeyGeneratorNext Instance
        //{
        //    get
        //    {
        //        if(instance == null)
        //        {
        //            lock (syncRoot)
        //            {
        //                if( instance == null)
        //                {
        //                    instance = new EntityKeyGeneratorNext();
        //                }
        //            }
        //        }
        //        return instance;
        //    }
        //}

        public virtual long NextKey
        {
            get
            {
                return ++nextKey;
            }
        }

        //private EntityKeyGeneratorNext()
        //{

        //}

    }
}
