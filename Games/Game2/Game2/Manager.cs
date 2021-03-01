using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class Manager
    {
        public static int KidsId;

        public static void SetId(int KidsIds)
        {
            KidsId = KidsIds;
        }

        public static int GetId()
        {
            return KidsId;
        }

    }
}
