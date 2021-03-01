using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Game2
{
   public class QuestionMethods
    {
        public static int GetNumQuestion()
        {
            int result = 0;
            string com = "select * from Questions";
            DataTable dt = OLEDBHelper.GetTable(com);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result++;
            }
            return result;

        }  
        public static Question GetQuestion()
        {
            Question q = null;
            string com = "select TOP 1 * from Questions ORDER BY Rnd([ID])";
            DataTable dt= OLEDBHelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                q = new Question(Convert.ToInt32(dr["ID"]), dr["Word1"].ToString(), dr["Word2"].ToString(), dr["Word3"].ToString(), dr["Word4"].ToString(), dr["Word5"].ToString(),dr["Answer"].ToString(), dr["Answer2"].ToString());
                  
           }
            return q;
        }        
    }
}
