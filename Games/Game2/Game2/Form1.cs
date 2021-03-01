using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Game2.ServiceReference1;

namespace Game2
{
    public partial class Form1 : Form
    {
        int num;  // QuestionMethods.GetNumQuestion();
        int score;
        string[] arr;/*QuestionMethods.GetNumQuestion()*/
        Question q;
        Random rnd;
        Label[] labelarr;
        string answer;
        int counter ;
        int sum;
        Service1Client s;
        int GameID;

        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            num = 4;  // QuestionMethods.GetNumQuestion();
            score = 0;
            sum = 0;
            arr = new string[4];/*QuestionMethods.GetNumQuestion()*/
            q = new Question();
            rnd = new Random();
            labelarr = new Label[5];
            string answer;
            counter = 0;
            s = new Service1Client();
            GameID = 7;

            textBox1.RightToLeft = RightToLeft.Yes;
            q = QuestionMethods.GetQuestion();
            int y = 250;
            for (int i = 0; i < 5; i++)
            {
                labelarr[i] = new Label();
                labelarr[i].Top = 150;
                labelarr[i].Width = 90;
                labelarr[i].Height = 30;
                labelarr[i].Left = y;
                labelarr[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                y = y + labelarr[i].Width + 10;
                labelarr[i].BringToFront();
                this.Controls.Add(labelarr[i]);

            }

            labelarr[0].Text = q.GetWord1();
            labelarr[1].Text = q.GetWord2();
            labelarr[2].Text = q.GetWord3();
            labelarr[3].Text = q.GetWord4();
            labelarr[4].Text = q.GetWord5();
            // labelarr[5].Text = q.GetAnswer();


            int num1, num2;
            for (int i = 0; i < 15; i++)
            {
                num1 = rnd.Next(1, 50) / 10;
                num2 = rnd.Next(1, 50) / 10;
                string temp = labelarr[num1].Text;
                labelarr[num1].Text = labelarr[num2].Text;
                labelarr[num2].Text = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sum < 4)
            {
                answer = textBox1.Text;

                q = QuestionMethods.GetQuestion();
                labelarr[0].Text = q.GetWord1();
                labelarr[1].Text = q.GetWord2();
                labelarr[2].Text = q.GetWord3();
                labelarr[3].Text = q.GetWord4();
                labelarr[4].Text = q.GetWord5();
                // labelarr[5].Text = q.GetAnswer();
                textBox1.Text = "";

                int num1, num2;
                for (int i = 0; i < 15; i++)
                {
                    num1 = rnd.Next(1, 50) / 10;
                    num2 = rnd.Next(1, 50) / 10;
                    string temp = labelarr[num1].Text;
                    labelarr[num1].Text = labelarr[num2].Text;
                    labelarr[num2].Text = temp;
                }

                button1.Visible = false;
                button2.Visible = true;

            }

            else
            {
                MessageBox.Show("המשחק נגמר, תודה ששיחקת");
                s.AddTestKid(Manager.GetId(), GameID, score);
                
                this.Close();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter < 3)
            {
                answer = textBox1.Text;
                if (q.GetAnswer() == answer || q.GetAnswer2() == answer && textBox1.Text.Length !=0)
                {
                    counter = 0;
                    MessageBox.Show("כל הכבוד! הצלחת!");
                    button1.Visible = true;
                    button2.Visible = false;
                    score += 25;
                    sum++;
                }

                else
                {

                    MessageBox.Show("טעית נסה שוב");
                    counter++;
                }
            }

            else
            {
                MessageBox.Show("התשובה היא " + q.GetAnswer());
                score -= 15;
                q = QuestionMethods.GetQuestion();
                labelarr[0].Text = q.GetWord1();
                labelarr[1].Text = q.GetWord2();
                labelarr[2].Text = q.GetWord3();
                labelarr[3].Text = q.GetWord4();
                labelarr[4].Text = q.GetWord5();
                // labelarr[5].Text = q.GetAnswer();
                textBox1.Text = "";

                int num1, num2;
                for (int i = 0; i < 15; i++)
                {
                    num1 = rnd.Next(1, 50) / 10;
                    num2 = rnd.Next(1, 50) / 10;
                    string temp = labelarr[num1].Text;
                    labelarr[num1].Text = labelarr[num2].Text;
                    labelarr[num2].Text = temp;
                }

                counter = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
