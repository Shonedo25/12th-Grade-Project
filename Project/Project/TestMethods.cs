using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Project
{
    public class TestMethods
    {
        public static void AddTest(string Theme)
        {
            string com = "insert into Tests (Theme) VALUES ('" + Theme + "')";

            OLEDBHelper.Execute(com);
        }

        public static void DeleteTest(string Theme)
        {
            string com = "Delete From Tests where Theme = '" + Theme + "'";
            OLEDBHelper.Execute(com);
        }

        public static DataTable GetAllTests()
        {
            string com = "select * from Tests";
            return OLEDBHelper.GetTable(com);
        }

        public static DataTable GetTest(string Theme)
        {
            string com = "select * from Tests where Theme = '" + Theme + "'";
            return OLEDBHelper.GetTable(com);
        }
    }
}
