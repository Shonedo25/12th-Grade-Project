using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Project
{
    public class TestKidMethod
    {
        public static void AddTestKid(int KidsID, int TestID, int TestResult)
        {
            string com = "insert into TestKid (KidsID , TestID, TestResult, TestDate) VALUES ('" + KidsID + "' , '" + TestID + "', " + TestResult + ", '" + DateTime.Today.ToString("dd/MM/yyyy")+ "')";

            OLEDBHelper.Execute(com);
        }

        public static void DeleteTestKid(int KidsID)
        {
            string com = "Delete From TestKid where KidsID = " + KidsID;
            OLEDBHelper.Execute(com);
        }

        public static DataTable GetTest(int KidsID)
        {
            string com = "select * from TestKid where KidsID = " + KidsID;
            return OLEDBHelper.GetTable(com);
        }

        public static DataTable GetKid(int TestID)
        {
            string com = "select * from TestKid where TestID = " + TestID;
            return OLEDBHelper.GetTable(com);
        }

        public static DataTable Getall(int KidId)
        {
            //string com = "SELECT * from KidDidTest WHERE KidsID = " + KidId + " ORDER BY TestDate DESC";
            string com = "SELECT KidsID as [תז של הילד], KidsName as [שם הילד], KidsLast as [שם משפחה], TestDate as [תאריך השלמת המשחק], Theme as [נושא המשחק], TestResult as [(תוצאה (מתוך 100]  from KidDidTest WHERE KidsID = " + KidId + " ORDER BY TestDate DESC";
            DataTable dt = OLEDBHelper.GetTable(com);
            return dt;
        }

        public static DataTable GetallMath(int KidId)
        {
            string com = "SELECT KidsID as [תז של הילד], KidsName as [שם הילד], KidsLast as [שם משפחה], TestDate as [תאריך השלמת המשחק], Theme as [נושא המשחק], TestResult as [(תוצאה (מתוך 100] from KidDidTest WHERE KidsID = " + KidId + " AND Theme = 'Math' ORDER BY TestDate DESC";
            DataTable dt = OLEDBHelper.GetTable(com);
            return dt;
        }

        public static DataTable GetallEnglish(int KidId)
        {
            string com = "SELECT KidsID as [תז של הילד], KidsName as [שם הילד], KidsLast as [שם משפחה], TestDate as [תאריך השלמת המשחק], Theme as [נושא המשחק], TestResult as [(תוצאה (מתוך 100] from KidDidTest WHERE KidsID = " + KidId + " AND Theme = 'English' ORDER BY TestDate DESC";
            DataTable dt = OLEDBHelper.GetTable(com);
            return dt;
        }


        public static DataTable GetallHebrew(int KidId)
        {
            string com = "SELECT KidsID as [תז של הילד], KidsName as [שם הילד], KidsLast as [שם משפחה], TestDate as [תאריך השלמת המשחק], Theme as [נושא המשחק], TestResult as [(תוצאה (מתוך 100] from KidDidTest WHERE KidsID = " + KidId + " AND Theme = 'Hebrew' ORDER BY TestDate DESC";
            DataTable dt = OLEDBHelper.GetTable(com);
            return dt;
        }

        public static void GetInfo(int KidId)
        {
            string s = "SELECT * from KidDidTest WHERE  KidsID = " + KidId + "";
            ;
            DataTable dt = OLEDBHelper.GetTable(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dr["KidsName"].ToString();

            }
                
            

        }
    }
}
