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
    public partial class Form3 : Form
    {
        string movie;
        string uid;
        public Form3(string movie, string uid)
        {
            InitializeComponent();
            this.movie = movie;
            this.uid = uid;
            label4.Text = movie;
            string[] halllist = { "Inox", "PVR", "IMax" };
            for (int i = 0; i < 3; i++)
            {
                comboBox1.Items.Add(halllist[i]);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(uid + " " + movie);
            string date = Convert.ToString(dateTimePicker1.Value);
            string hall = comboBox1.SelectedItem.ToString();
            Form4 f4 = new Form4(uid, movie, date, hall);
            this.Hide();
            f4.Show();
        }
    }
}
