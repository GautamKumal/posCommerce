using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pay
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void print1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void backsale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

