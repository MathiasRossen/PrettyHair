using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Domain.Interfaces;

namespace PrettyHair.DAL
{
    public class EntityKeyGeneratorRandom : IEntityKeyGenerator
    {
        private static volatile EntityKeyGeneratorRandom instance;
        private static object syncRoot = new object();
        private Random rand = new Random();

        public static EntityKeyGeneratorRandom Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new EntityKeyGeneratorRandom();
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

        private EntityKeyGeneratorRandom()
        {

        }
    }
}
