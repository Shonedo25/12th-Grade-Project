using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public class Track
    {
        static int Id;
        static string name;
        static string last;
        static DateTime date;
        static string theme;


        public static void SetId(int ID)
        {
            Id = ID;
        }

        public static int GetId()
        {
            return Id;
        }

        public static void SetName(string Name)
        {
            name = Name;
        }

        public static string GetName()
        {
            return name;
        }

        public static void SetLast(string Last)
        {
            last = Last;
        }

        public static string GetLast()
        {
            return last;
        }

        public static void SetDate(DateTime Date)
        {
            date = Date;
        }

        public static DateTime GetDate()
        {
            return date;
        }

        public static void SetTheme(string Theme)
        {
            theme = Theme;
        }

        public static string GetTheme()
        {
            return theme;
        }

    }
}
