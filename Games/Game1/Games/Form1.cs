using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games.ServiceReference1;

namespace Games
{
    
    public partial class Form1 : Form
    {
        int GameId = 5;
        Service1Client s = new Service1Client();
        public static Word one = new Word("Car", 1);
        static Word two = new Word("מכונית", 1);
        static Word three = new Word("Door", 2);
        static Word four = new Word("דלת", 2);
        static Word five = new Word("Mom", 3);
        static Word six = new Word("אמא", 3);
        static Word seven = new Word("Dad", 4);
        static Word eight = new Word("אבא", 4);
        static Word nine = new Word("Red", 5);
        static Word ten  = new Word("אדום", 5);
        static Word eleven = new Word("Blue", 6);
        static Word twelve = new Word("כחול", 6);
        static Word thirteen = new Word("Green", 7);
        static Word fourteen = new Word("ירוק", 7);
        static Word fifteen = new Word("Black", 8);
        static Word sixteen = new Word("שחור", 8);
         
       
        Random random = new Random();
        
        List<Word> icons = new List<Word>()
        {
            one , two , three , four , five , six , seven , eight ,
            nine , ten , eleven , twelve , thirteen , fourteen , fifteen , sixteen
        };
        
        Label FirstClicked , SecondClicked;

        public Form1()
        {
            
            InitializeComponent();
            AssignIconsToSquares();

            this.Text = "You have: " + Manager.score + " points";
            Manager.start = this;
            
            
        }

        private void label_Click(object sender, EventArgs e)
        {
            
            if (FirstClicked != null && SecondClicked != null)
            {
                return;
            }

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
            {
                return;
            }

            if (Manager.active)
            {
                return;
            }

            if (clickedLabel.ForeColor == Color.Black)
            {
                return;
            }
             
            if (FirstClicked == null)
            {
                FirstClicked = clickedLabel;
                FirstClicked.ForeColor = Color.Black;
                
                return;
            }

            SecondClicked = clickedLabel;
            SecondClicked.ForeColor = Color.Black;

            Form2 g = new Form2();
            g.ShowDialog();

            //if (Manager.check == 0)
            //{
            //    //if (Manager.check == 1)
            //{
            //    if (FirstClicked.Text == SecondClicked.Text)
            //    {
            //        FirstClicked = null;
            //        SecondClicked = null;
            //        Manager.score += 10;
            //        MessageBox.Show("כל הכבוד! הניקוד החדש שלך הוא " + Manager.score);
            //    }

            //    else
            //    {
            //        if (Manager.score >= 10)
            //        {
            //            Manager.score -= 10;
            //        }
            //        MessageBox.Show("טעית! הניקוד החדש שלך הוא " + Manager.score);
            //        timer1.Start();
            //    }

            //}

                

                    
          


            //}



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            FirstClicked.ForeColor = FirstClicked.BackColor;
            SecondClicked.ForeColor = SecondClicked.BackColor;

            FirstClicked = null;
            SecondClicked = null;
            timer1.Stop();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Manager.flip < 8)
            {


                if (Manager.check == 1)
                {
                    if (FirstClicked != null && SecondClicked != null)
                    {


                        if (FirstClicked.Tag.ToString() == SecondClicked.Tag.ToString())
                        {
                            
                            Manager.score += 10;
                            this.Text = "You have: " + Manager.score + " points";
                            FirstClicked = null;
                            SecondClicked = null;
                            Manager.flip += 1;
                        }
                        else
                        {
                            MessageBox.Show("אתה טעית, נסה שוב");
                           
                            if (Manager.score >= 10)
                            {
                                Manager.score -= 10;
                                this.Text = "You have: " + Manager.score + " points";
                            }
                            FirstClicked.ForeColor = FirstClicked.BackColor;
                            SecondClicked.ForeColor = SecondClicked.BackColor;
                            FirstClicked = null;
                            SecondClicked = null;
                        }
                    }

                }

                else
                {
                    if (FirstClicked != null && SecondClicked != null)
                    {
                        if (FirstClicked.Tag.ToString() == SecondClicked.Tag.ToString())
                        {
                            MessageBox.Show("אתה טעית");
                          
                            if (Manager.score >= 10)
                            {
                                Manager.score -= 10;
                                this.Text = "You have: " + Manager.score + " points";
                            }
                            FirstClicked.ForeColor = FirstClicked.BackColor;
                            SecondClicked.ForeColor = SecondClicked.BackColor;
                            FirstClicked = null;
                            SecondClicked = null;
                            
                        }


                        else
                        {
                            timer1.Start();
                        }
                    }
                }
                
            }

            if (Manager.flip == 8)
            {
                MessageBox.Show("!כל הכבוד!ניצחת");
                s.AddTestKid(Manager.GetId(), GameId, Manager.score);
                this.Close();
                
            }
        } 

        private void AssignIconsToSquares()
        {
            Label label;
            int randomNumber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }

                else
                    continue;

                randomNumber = random.Next(0, icons.Count);
                label.Text = (icons[randomNumber]).GetText();
                label.Tag = icons[randomNumber].num;
                icons.RemoveAt(randomNumber);
            }
        }
    }
}
