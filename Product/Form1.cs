using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Pay;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button7.Parent = panel2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {
            createCustomer objCustom = new createCustomer();
            objCustom.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            payment pay = new payment();
            pay.Show();

        }
    }
}
