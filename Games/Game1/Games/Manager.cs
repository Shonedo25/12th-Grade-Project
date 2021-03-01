using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
   public class Manager
    {
        public static int check = 0;
        public static int score = 0;
        public static int flip = 0;
        public static int KidsId;
        public static bool active = false;
        public static Form1 start;
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
