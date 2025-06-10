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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VOUCHER_SYSTEM
{
    public partial class Update : UserControl
    {
        public Update()
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
            string Name = textBoxName.Text;
            string Class = comboBoxClass.SelectedItem.ToString();
            string Age = textBoxAge.Text;
            string Batch = comboBoxBatch.SelectedItem.ToString();




            string connection = "server=localhost;user=root;password=ahmed038@;database=vgs;";
            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                conn.Open();

                string query = "UPDATE STD SET Name = @name , Class = @class , Age = @Age, Batch = @Batch  WHERE ID = @id;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@class", Class);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@Batch", Batch);

                cmd.ExecuteNonQuery();

                // Clear the Feilds 
                textBoxId.Text = "";
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
