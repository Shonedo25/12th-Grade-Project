using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Project
{
    public class ParentsMethods
    {
        public static void AddParent(int ParentsID, string ParentsName, string ParentsLast)
        {
            string com = "insert into Parents (ParentsID , ParentsName , ParentsLast) VALUES ('" + ParentsID + "', '" + ParentsName + "' , '" + ParentsLast + "')";

            OLEDBHelper.Execute(com);
        }


        public static DataTable GetAllParents()
        {
            string com = "select * from Parents";
            return OLEDBHelper.GetTable(com);
        }


        public static void UpdateParent(int ParentsID, string ParentsName, string ParentsLast)
        {
            string com = "update Parents set ParentsName = '" + ParentsName + "' , ParentsLast = '" + ParentsLast + "' where ParentsID=" + ParentsID;
            OLEDBHelper.Execute(com);
        }

        public static void DeleteParent(int ParentsID)
        {
            string com = "Delete From Parents where ParentsID =" + ParentsID;
            OLEDBHelper.Execute(com);

        }

        public static bool check(string ParentsName, int ParentsID)
        {
            string s = "SELECT * from Parents WHERE ParentsName = '" + ParentsName + "' AND ParentsID = " + ParentsID + "";
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
