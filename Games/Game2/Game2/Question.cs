using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Question
    {
        int ID;
        string Word1;
        string Word2;
        string Word3;
        string Word4;
        string Word5;
        string Answer;
        string Answer2;

        public string GetWord1()
        {
            return Word1;
        }

        public string GetWord2()
        {
            return Word2;
        }
        public string GetWord3()
        {
            return Word3;
        }
        public string GetWord4()
        {
            return Word4;
        }
        public string GetWord5()
        {
            return Word5;
        }
        public string GetAnswer()
        {
            return Answer;
        }
        public string GetAnswer2()
        {
            return Answer2;
        }


        public Question()
        {
            
        }

        public Question(int ID, string Word1, string Word2,string Word3,string Word4,string Word5, string Answer)
        {
            this.ID = ID;
            this.Word1 = Word1;
            this.Word2 = Word2;
            this.Word3 = Word3;
            this.Word4 = Word4;
            this.Word5 = Word5;
            this.Answer = Answer;
        }

        public Question(int ID, string Word1, string Word2, string Word3, string Word4, string Word5, string Answer,string Answer2)
        {
            this.ID = ID;
            this.Word1 = Word1;
            this.Word2 = Word2;
            this.Word3 = Word3;
            this.Word4 = Word4;
            this.Word5 = Word5;
            this.Answer = Answer;
            this.Answer2 = Answer2;
        }

    }
}
