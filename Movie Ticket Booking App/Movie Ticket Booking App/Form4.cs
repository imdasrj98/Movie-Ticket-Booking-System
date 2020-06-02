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
    public partial class Form4 : Form
    {
        string uid = "", movie = "", date = "", hall = "";

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox2.Text = uid;
            textBox3.Text = movie;
            textBox4.Text = hall;
            textBox5.Text = date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form4(string uid, string movie, string date, string hall)
        {
            this.uid = uid;
            this.movie = movie;
            this.date = date;
            this.hall = hall;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
