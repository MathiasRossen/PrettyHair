using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.DAL
{
    public class EntityKeyGeneratorDate : IEntityKeyGenerator
    {
        private static volatile EntityKeyGeneratorDate instance;
        private static object syncRoot = new object();
        private DateTime dateKey;

        public static EntityKeyGeneratorDate Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new EntityKeyGeneratorDate();
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
                string outputString = "" + dateKey.Year + dateKey.Month + dateKey.Day + dateKey.Hour + dateKey.Minute + dateKey.Second;
                return long.Parse(outputString);
            }
        }

        private EntityKeyGeneratorDate()
        {

        }

    }

}
