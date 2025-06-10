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
    public partial class Delete : UserControl
    {
        public Delete()
        {
            InitializeComponent();
            loadData();
            dgv1.CellClick += dgv1_CellClick;
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
          
            string Id = textBoxId.Text;

            string connection = "server=localhost;user=root;password=ahmed038@;database=vgs;";
            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                conn.Open();
                string query = "DELETE FROM STD WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.ExecuteNonQuery();
                
                textBoxId.Text = "";
                textBoxName.Text = "";
                comboBoxClass.Text = "";
                textBoxAge.Text = "";
                comboBoxBatch.Text = "";
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
        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv1.Rows[index];

            textBoxId.Text = selectedRow.Cells[0].Value.ToString();
            textBoxName.Text = selectedRow.Cells[1].Value.ToString(); ;
            comboBoxClass.Text = selectedRow.Cells[2].Value.ToString(); ;
            textBoxAge.Text = selectedRow.Cells[3].Value.ToString();
            comboBoxBatch.Text = selectedRow.Cells[4].Value.ToString();
        }
    }
}
