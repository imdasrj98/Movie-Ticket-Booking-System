using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Ticket_Booking_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] userlist = { "debayan", "riju" };
            string[] passwordlist = { "debayan", "riju" };
            string uid = Convert.ToString(textBox2.Text);
            string upass = Convert.ToString(textBox3.Text);
            int f = 0;
            for (int i = 0; i < 2; i++)
            {
                if (userlist[i] == uid)
                { 
                    if(passwordlist[i]== upass)
                    {
                        this.Hide();
                        f = 1;
                        Form1 f1 = new Form1(uid);
                        f1.Show();
                    }
                }
            }
            if (f == 0)
            {
                MessageBox.Show("Wrong Credentials");
            }
        }
    }
}
