using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Manager
    {
        static int KidId;
        static string ParentName;
        static int ParentId;
        static string KidName;

        public static int GetKidId()
        {
            return KidId;
        }
        public static void SetKidId(int KidID)
        {
            KidId = KidID;
        }

        public static string GetKidName()
        {
            return KidName;
        }

        public static void SetKidName(string Kidname)
        {
            KidName = Kidname;
        }

        public static string GetParentName()
        {
            return ParentName;
        }

        public static void SetParentName(string Parentname)
        {
            ParentName = Parentname;
        }

        public static int GetParentId()
        {
            return ParentId;
        }

        public static void SetParentId(int Id)
        {
            ParentId = Id;
        }
    }
}
