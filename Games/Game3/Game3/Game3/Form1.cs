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
    public partial class Form1 : Form
    {
        Service1Client s = new Service1Client();
        int score;
        int sum;
        int GameId;
        public Form1()
        {
            
            score = 0;
            sum = 0;
            GameId = 6;
            InitializeComponent();
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            label4.Text = score.ToString();

            if (Manager.Getplus())
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button1.Enabled = false;
                score++;
                sum++;
                label4.Text = score.ToString();
            }

            if (Manager.Getminus())
            {
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                button2.Enabled = false;
                score++;
                sum++;
                label4.Text = score.ToString();
            }

            if (sum >= 2)
            {
                button3.Visible = true;
                button4.Visible = true;
                score = 0;
                
                label4.Text = score.ToString();
            }

            if (Manager.Getkefel())
            {
                button3.BackColor = Color.Green;
                button3.ForeColor = Color.White;
                button3.Enabled = false;
                score++;
                sum++;
                label4.Text = score.ToString();
            }

            if (Manager.Gethiluk())
            {
                button4.BackColor = Color.Green;
                button4.ForeColor = Color.White;
                button4.Enabled = false;
                score++;
                sum++;
                label4.Text = score.ToString();
            }

            if (sum >= 4)
            {
                button5.Visible = true;
                button6.Visible = true;
                score = 0;
                label4.Text = "";
                label3.Text = "";
                label5.Text = "";
                label2.Text = "";
            }

            if (Manager.Getseder())
            {
                button5.BackColor = Color.Green;
                button5.ForeColor = Color.White;
                button5.Enabled = false;
                score++;
                sum++;
                
            }

            if (Manager.Getsikum())
            {
                button6.BackColor = Color.Green;
                button6.ForeColor = Color.White;
                button6.Enabled = false;
                score++;
                sum++;
                button7.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 g = new Form3();
            g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 h = new Form4();
            h.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 j = new Form5();
            j.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("המשחק נגמר. תודה ששיחקת");
            s.AddTestKid(Manager.GetId(), GameId, 100);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 k = new Form6();
            k.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 l = new Form7();
            l.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
