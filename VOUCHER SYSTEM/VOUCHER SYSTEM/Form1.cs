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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            AddUserControl(R);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update U = new Update();
            AddUserControl(U);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete D = new Delete();
            AddUserControl(D);
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            Voucher V = new Voucher();
            AddUserControl(V);
        }

    }
}
