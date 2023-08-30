using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Admin;
using WindowsFormsApp1.Usercontrol;

namespace WindowsFormsApp1
{
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProduct pobj =new addProduct();
            panel4.Controls.Clear();
            panel4.Controls.Add(pobj);
            pobj.Visible = true;
            pobj.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Adminpage_Load(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminData1 adminData1 = new AdminData1();
            panel4.Controls.Clear();
            panel4.Controls.Add(adminData1);
            adminData1.Visible = true;
            adminData1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salesmanData salesmanData = new salesmanData();
            panel4.Controls.Clear();
            panel4.Controls.Add(salesmanData);
            salesmanData.Visible = true;
            salesmanData.BringToFront();
        }

        private void adminData1_Load(object sender, EventArgs e)
        {

        }

        private void salesmanData1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerData customerData = new CustomerData();
            panel4.Controls.Clear();
            panel4.Controls.Add(customerData);
            customerData.Visible = true;
            customerData.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
