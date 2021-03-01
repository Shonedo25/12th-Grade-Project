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
    public partial class Form2 : Form
    {
        Service1Client s = new Service1Client();
        public Form2()

        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Manager.check = 1;
            Manager.active = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Manager.check = 2;
            Manager.active = false;
            this.Close();

        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            Manager.active = true;
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show(Manager.GetId().ToString());
        //    s.AddTestKid(Manager.GetId(), 5 , Manager.score);
            
        //}
    }
}
