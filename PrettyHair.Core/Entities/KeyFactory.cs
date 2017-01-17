using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Core.Entities
{
    public enum KeyType { Next, Random, Date}
    class KeyFactory
    {
        public IEntityKeyGenerator KeyCreator(KeyType keyType)
        {
            switch (keyType)
            {
                case KeyType.Next:
                    return EntityKeyGenerator.Instance;
                case KeyType.Random:
                    return EntityKeyGenerator3.Instance;
                case KeyType.Date:
                    return EntityKeyGenerator2.Instance;
               
            }
            return EntityKeyGenerator.Instance;
        }

    }
}
