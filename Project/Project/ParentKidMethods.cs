using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Project
{
    public class ParentKidMethods
    {

        public static void AddParentKid(int ParentsID, int KidsID)
        {
            string com = "insert into ParentKid (ParentsID , KidsID) VALUES ('" + ParentsID + "' , '" + KidsID + "')";

            OLEDBHelper.Execute(com);
        }

        public static void DeleteParentKid(int ParentsID)
        {
            string com = "Delete From ParentKid where ParentsID = " + ParentsID ;
            OLEDBHelper.Execute(com);
        }

        public static DataTable GetParent(int KidsID)
        {
            string com = "select * from ParentKid where KidsID = " + KidsID ;
            return OLEDBHelper.GetTable(com);
        }

        public static DataTable GetKid(int ParentID)
        {
            string com = "select * from ParentKid where ParentID = " + ParentID ;
            return OLEDBHelper.GetTable(com);
        }

        public static int GetKidId(int ParentID)
        {
            string com = "select * from ParentKid where ParentsID = " + ParentID;
            DataTable dt =  OLEDBHelper.GetTable(com);
            DataRow dr = dt.Rows[0];
            return int.Parse(dr["KidsID"].ToString());
        }

        public static int HowMuch(int ParentID)
        {
            string com = "select * from ParentKid where ParentsID = " + ParentID;
                          
        

            DataTable dt = OLEDBHelper.GetTable(com);
            return dt.Rows.Count;
        }

        public static DataTable AllKidsName(int ParentID)
        {
            string com = "SELECT ParentKid.ParentsID, Kids.KidsID, Kids.KidsName FROM Kids INNER JOIN ParentKid ON Kids.KidsID = ParentKid.KidsID WHERE ParentKid.ParentsID = " + ParentID;
            DataTable dt = OLEDBHelper.GetTable(com);



            
            return dt;
        }
    }
}
