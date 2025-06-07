using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connction = "server=localhost;user=root;password=ahmed038@;database=csharpdb";
            MySqlConnection con = new MySqlConnection(connction);
            string cmd = "insert into data value ('farooq','akram',24);";
            MySqlCommand cm = new MySqlCommand(cmd,con);
            try
            {
            con.Open();
            cm.ExecuteNonQuery();
                MessageBox.Show("Connected Successfully!!!");
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }
    }
}
