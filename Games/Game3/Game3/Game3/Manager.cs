using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3
{
    public class Manager
    {
        static bool plus  = false;
        static bool minus = false;
        static bool kefel = false;
        static bool hiluk = false;
        static bool seder = false;
        static bool sikum = false;
        public static int KidsId;

        public static void SetPlus(bool pluss)
        {
            plus = pluss;
        }

        public static bool Getplus()
        {
            return plus;
        }

        public static void Setminus(bool minuss)
        {
            minus = minuss;
        }

        public static bool Getminus()
        {
            return minus;
        }

        public static void Setkefel(bool kefels)
        {
            kefel = kefels;
        }

        public static bool Getkefel()
        {
            return kefel;
        }

        public static void Sethiluk(bool hiluks)
        {
            hiluk = hiluks;
        }

        public static bool Gethiluk()
        {
            return hiluk;
        }

        public static void Setseder(bool seders)
        {
            seder = seders;
        }

        public static bool Getseder()
        {
            return seder;
        }

        public static void Setsikum(bool sikums)
        {
            sikum = sikums;
        }

        public static bool Getsikum()
        {
            return sikum;
        }

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
