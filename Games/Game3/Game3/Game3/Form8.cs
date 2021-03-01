using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game3.ServiceReference1;

namespace Game3
{
    public partial class Form8 : Form
    {

        Service1Client s = new Service1Client();
        char chr;

        public Form8()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Length == 9)
            {
                if (s.check(textBox1.Text, int.Parse(textBox2.Text)))
                {
                    Manager.SetId(int.Parse(textBox2.Text));

                    Form1 g = new Form1();
                    g.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("אנא הכנס שם ות.ז תקינים אשר רשומים במערכת");
                }
            }
            else
            {
                MessageBox.Show("אנא הכנס מספר ת.ז תקין");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            chr = e.KeyChar;
            if (Char.IsDigit(chr) && chr != 8 && chr != 13)
            {
                e.Handled = true;
                MessageBox.Show("אנא הכנס שם תקין");
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
        }
    }
}
    





