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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             Register rg=new Register();
            rg.Show();
            this.Hide();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                registerUser login = new registerUser();
                string username = textBox1.Text;
                string password = textBox2.Text;
                login.UserName = username;
                login.PassWord = password;
                login.UserType = "SalesManLogin";
                using(posEntities10 entity=new posEntities10())
                {
                    entity.registerUsers.Add(login);
                    entity.SaveChanges();

                }
            }
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pos pointofsale = new pos();
            pointofsale.Show();
            this.Hide();

        }
    }
}
