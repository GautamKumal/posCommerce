using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class pos : Form
    {
        internal object registerUser;

        public pos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginAdmin lg = new loginAdmin(); 
            lg.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void pos_Load(object sender, EventArgs e)
        {

        }
    }
}
