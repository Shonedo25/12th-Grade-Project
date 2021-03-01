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
    public partial class Form6 : Form
    {
        double num1, num2, num3, num4, num5, num6, num7, num8,num9, num10, num11, num12;
        char chr;
        bool one, two, three;

        Random rnd = new Random();
        public Form6()
        {
            InitializeComponent();
            one = false;
            two = false;
            three = false;
            
            num1 = rnd.Next(1, 11);
            num2 = rnd.Next(1, 11);
            num3 = rnd.Next(1, 11);
            num4 = rnd.Next(1, 11);
            num5 = rnd.Next(1, 11);
            num6 = rnd.Next(1, 11);
            num7 = rnd.Next(1, 11);
            num8 = rnd.Next(1, 11);
            num9 = rnd.Next(1, 11);
            num10 = rnd.Next(1, 11);
            num11 = rnd.Next(1, 11);
            num12 = rnd.Next(1, 11);
            button5.Visible = false;

            label2.Text = num1 + " X (" + (Math.Max(num2, num3) + " - " + Math.Min(num2, num3)) + ") + " + num4 + " = ";
            label3.Text = num7 + " X (" + Math.Max(num5, num6) +" - " + Math.Min(num5,num6)  + ") + " + num8 + " = ";
            label4.Text = num9*num12 + " / " + num12 + " X ( " + (Math.Max(num10, num11) + " - " + Math.Min(num10, num11)) + " ) " + " = ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("אנא הכנס מספר ");

            }
            else
            {
                if (double.Parse(textBox1.Text) == num1 * (Math.Max(num2, num3) - Math.Min(num2, num3)) + num4)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {

                MessageBox.Show("אנא הכנס מספר ");

            }
            else
            {
                if (double.Parse(textBox3.Text) == num9 * num12 / num12 * ((Math.Max(num10, num11) - Math.Min(num10, num11))))
                {
                    textBox3.Text = textBox3.Text.TrimStart(new Char[] { '0' });
                    textBox3.BackColor = Color.Green;
                    textBox3.ForeColor = Color.White;
                    textBox3.ReadOnly = true;
                    two = true;
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
                if (double.Parse(textBox2.Text) == num7 * (Math.Max(num5, num6) - Math.Min(num5, num6)) + num8)
                {
                    textBox2.Text = textBox2.Text.TrimStart(new Char[] { '0' });
                    textBox2.BackColor = Color.Green;
                    textBox2.ForeColor = Color.White;
                    textBox2.ReadOnly = true;
                    three = true;
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
            Manager.Setseder(true);
            Form1 g = new Form1();
            this.Hide();
            g.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (one && two && three)
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
    }
}
