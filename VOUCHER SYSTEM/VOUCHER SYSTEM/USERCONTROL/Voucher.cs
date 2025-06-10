using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOUCHER_SYSTEM
{
    public partial class Voucher : UserControl
    {
        public Voucher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id = textBoxId.Text;

            if (string.IsNullOrEmpty(Id))
            {
                MessageBox.Show("Please enter a valid student ID.");
                return;
            }

            string connectionString = "server=localhost;user=root;password=ahmed038@;database=vgs;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "SELECT * FROM STD WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Name = reader["NAME"].ToString();
                    string Class = reader["Class"].ToString();
                    string Fee = reader["Fee"].ToString();
                    string Batch = reader["Batch"].ToString();
                    string ID = reader["ID"].ToString();

                    label1.Text = "STUDENT COPY";
                    labelId.Text = "ID : "+ID;
                    labelName.Text = "Name : "+Name;
                    labelClass.Text = Class;
                    labelBatch.Text = "Batch : "+Batch;
                    labelFee.Text = "Fee : "+Fee;

                    label8.Text = "BANK COPY";
                    labelIB.Text = "ID : " + ID;
                    labelNB.Text = "Name : " + Name;
                    labelCB.Text = Class;
                    labelBB.Text = "Batch : " + Batch;
                    labelFB.Text = "Fee : " + Fee;

                    label9.Text = "SCHOOL COPY";
                    labelIS.Text = "ID : " + ID;
                    labelNS.Text = "Name : " + Name;
                    labelCS.Text = Class;
                    labelBS.Text = "Batch : " + Batch;
                    labelFS.Text = "Fee : " + Fee;
                }
                else
                {
                    MessageBox.Show("No record found with the provided ID.");
                }
                

                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

    }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
