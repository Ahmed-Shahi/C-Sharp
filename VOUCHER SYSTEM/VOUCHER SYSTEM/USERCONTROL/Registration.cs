using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VOUCHER_SYSTEM
{
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            string connectionString = "server=localhost;user=root;password=ahmed038@;database=vgs;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            DataTable dataTable = new DataTable();
            string cmd = "SELECT * FROM STD;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, conn);
            adapter.Fill(dataTable);
            dgv1.DataSource = dataTable;
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            string Class = comboBoxClass.SelectedItem.ToString();
            string Age = textBoxAge.Text;
            string Batch = comboBoxBatch.SelectedItem.ToString();

            string connection = "server=localhost;user=root;password=ahmed038@;database=vgs;";
            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                conn.Open();
                string query = "INSERT INTO STD (Name, Class , Fee , Age, Batch) " +
                                  "VALUES (@name, @class, @fee , @Age, @Batch)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@class", Class);
                cmd.Parameters.AddWithValue("@fee", 0.00);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@Batch", Batch);

                cmd.ExecuteNonQuery();
                
                // Clear the Feilds 
                textBoxName.Text = "";
                comboBoxClass.SelectedIndex = -1;
                textBoxAge.Text = "";
                comboBoxBatch.SelectedIndex = -1;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                loadData();
                conn.Close();

            }
        }
    }
}
