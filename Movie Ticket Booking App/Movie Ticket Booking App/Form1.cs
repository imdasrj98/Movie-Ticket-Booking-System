using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Movie_Ticket_Booking_App
{
    public partial class Form1 : Form
    {
        string uid = "";
        string movie = "";
        public Form1(string uid)
        {
            InitializeComponent();
            this.uid = uid;
            textBox3.Text = "Hello " + uid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movie = textBox1.Text;
            string[] movielist = { "The Avegers", "Jurrassic Park", "Anaconda" };
            /*string connectionString = "Data Source=(DESCRIPTION = " +
    "(ADDRESS = (PROTOCOL = TCP)(HOST = 0.0.0.0)(PORT = 1521))" +
    "(CONNECT_DATA =" +
      "(SERVER = DEDICATED)" +
      "(SERVICE_NAME = XE)" +
    ")" +
  "); User Id = debayan; password = debayan; ";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select mname from movies where mname like '" + movie + "%'";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            //textBox1.Text = dr.GetString(0);*/
            string output = "Search Results: \n";
            for (int i = 0; i < 3; i++)
            {
                if (movielist[i].Contains(movie))
                {
                    comboBox1.Items.Add(movielist[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string m = comboBox1.SelectedItem.ToString();
            this.Hide();
            Form3 f3 = new Form3(m, uid);
            //MessageBox.Show("Movie : " + m);
            f3.Show();
        }
    }
}
