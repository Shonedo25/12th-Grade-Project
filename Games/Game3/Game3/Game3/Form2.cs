using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game3
{
    public partial class Form2 : Form
    {
        double num1, num2, num3, num4, num5, num6, num7, num8;
        char chr;
        bool one, two ,three ,four;
        Random rnd = new Random();

        public Form2()
        {
            one = false;
            two = false;
            three = false;
            four = false;
            InitializeComponent();
            
            num1 = rnd.Next(1, 10);
            num2 = rnd.Next(1, 10);
            num3 = rnd.Next(1, 11);
            num4 = rnd.Next(1, 11);
            num5 = rnd.Next(1, 16);
            num6 = rnd.Next(1, 16);
            num7 = rnd.Next(1, 21);
            num8 = rnd.Next(1, 21);
            button5.Visible = false;
            label2.Text = num1 + " + " + num2 + " = ";
            label3.Text = num3 + " + " + num4 + " = ";
            label4.Text = num5 + " + " + num6 + " = ";
            label5.Text = num7 + " + " + num8 + " = ";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                    MessageBox.Show("אנא הכנס מספר ");
                
            }

            else
            {
                if (double.Parse(textBox1.Text) == num1 + num2)
                {
                    textBox1.Text = textBox1.Text.TrimStart(new Char[] { '0' });
                    textBox1.BackColor = Color.Green;
                    textBox1.ForeColor = Color.White;
                    textBox1.ReadOnly = true;
                    

                    one = true;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                    textBox1.ForeColor = Color.White;
                }
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {

                MessageBox.Show("אנא הכנס מספר ");

            }

            else
            {
                if (double.Parse(textBox4.Text) == num7 + num8)
                {
                    textBox4.Text = textBox4.Text.TrimStart(new Char[] { '0' });
                    textBox4.BackColor = Color.Green;
                    textBox4.ForeColor = Color.White;
                    textBox4.ReadOnly = true;
                    four = true;
                }
                else
                {
                    textBox4.BackColor = Color.Red;
                    textBox4.ForeColor = Color.White;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (textBox3.Text == "")
            {

                MessageBox.Show("אנא הכנס מספר ");

            }

            else
            {
                if (double.Parse(textBox3.Text) == num5 + num6)
                {
                    textBox3.Text = textBox3.Text.TrimStart(new Char[] { '0' });
                    textBox3.BackColor = Color.Green;
                    textBox3.ForeColor = Color.White;
                    textBox3.ReadOnly = true;
                    three = true;
                }
                else
                {
                    textBox3.BackColor = Color.Red;
                    textBox3.ForeColor = Color.White;
                }
            }


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {

                MessageBox.Show("אנא הכנס מספר ");

            }
            else
            {
                if (double.Parse(textBox2.Text) == num3 + num4)
                {
                    textBox2.Text = textBox2.Text.TrimStart(new Char[] { '0' });
                    textBox2.BackColor = Color.Green;
                    textBox2.ForeColor = Color.White;
                    textBox2.ReadOnly = true;

                    two = true;
                }


                else
                {
                    textBox2.BackColor = Color.Red;
                    textBox2.ForeColor = Color.White;
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
            Manager.SetPlus(true);
            Form1 g = new Form1();
            this.Hide();
            g.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (one && two && three && four)
            {
                button5.Visible = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 13)
            {
                e.Handled = true;
                MessageBox.Show("אנא הכנס מספר תקין");
            }

            else
            {
                if (!one)
                {
                    textBox1.BackColor = Color.White;
                    textBox1.ForeColor = Color.Black;

                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 13)
            {
                e.Handled = true;
                MessageBox.Show("אנא הכנס מספר תקין");
            }

            else
            {
                if (!two)
                {
                    textBox2.BackColor = Color.White;
                    textBox2.ForeColor = Color.Black;

                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 13)
            {
                e.Handled = true;
                MessageBox.Show("אנא הכנס מספר תקין");
            }
            else
            {
                if (!three)
                {
                    textBox3.BackColor = Color.White;
                    textBox3.ForeColor = Color.Black;

                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 13)
            {
                e.Handled = true;
                MessageBox.Show("אנא הכנס מספר תקין");
            }
            else
            {
                if (!four)
                {
                    textBox4.BackColor = Color.White;
                    textBox4.ForeColor = Color.Black;

                }
            }
        }
    }
}
