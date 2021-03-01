using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Project
{
    public class KidsMethods
    {

        public static void AddKid(int KidsID, string KidsName, string KidsLast)
        {
            string com = "insert into Kids (KidsID , KidsName , KidsLast) VALUES ('" + KidsID + "', '" + KidsName + "' , '" + KidsLast + "')";

            OLEDBHelper.Execute(com);
        }

        internal static void GetAllKids(int v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public static DataTable GetAllKids()
        {
            string com = "select * from Kids";
            return OLEDBHelper.GetTable(com);
        }


        public static void UpdateKid(int KidsID, string KidsName, string KidsLast)
        {
            string com = "update Kids set KidsName = '" + KidsName + "' , KidsLast = '" + KidsLast + "' where KidsID=" + KidsID;
            OLEDBHelper.Execute(com);
        }

        public static void DeleteKid(int KidsID)
        {
            string com = "Delete From Kids where KidsID =" + KidsID;
            OLEDBHelper.Execute(com);
        }

        public static string FindKid(int KidsID)
        {
            string s = "SELECT * from Kids WHERE  KidsID = " + KidsID + "";
            DataTable dt = OLEDBHelper.GetTable(s);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return dr["KidsName"].ToString();
            }

            else
            {
                return "";
            }
        }

        public static bool check(string KidsName, int KidsID)
        {
            string s = "SELECT * from Kids WHERE KidsName = '" + KidsName + "' AND KidsID = " + KidsID + "";
            DataTable dt = OLEDBHelper.GetTable(s);
            if (dt.Rows.Count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }



        public static bool checkID(int KidsID)
        {
            string s = "SELECT * from Kids WHERE KidsID = " + KidsID + "";
            DataTable dt = OLEDBHelper.GetTable(s);
            if (dt.Rows.Count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
