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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movie = textBox1.Text;
            string connectionString = "Data Source=(DESCRIPTION = " +
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
            //textBox1.Text = dr.GetString(0);
            string output = "Search Results: \n";
            output += dr.GetString(0) + "\n";
            label1.Text = output;
        }
    }
}
