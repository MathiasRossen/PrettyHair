using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Core
{
    public enum KeyType { Next, Random, Date}
    public class KeyFactory
    {
        public KeyType KeyType { get; set; }

        public KeyFactory(KeyType keyType)
        {
            KeyType = keyType;
        }
        public IEntityKeyGenerator KeyCreator()
        {
            switch (KeyType)
            {
                case KeyType.Next:
                    return EntityKeyGeneratorNext.Instance;
                case KeyType.Random:
                    return EntityKeyGeneratorRandom.Instance;
                case KeyType.Date:
                    return EntityKeyGeneratorDate.Instance;
               
            }
            return EntityKeyGeneratorNext.Instance;
        }

    }
}
