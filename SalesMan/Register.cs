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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                registerUser regUser = new registerUser();
            string fname = textBox5.Text;
            string username=textBox1.Text;
            string phone = textBox2.Text;
            string email = textBox3.Text;
            string password = textBox4.Text;
            regUser.Email = email;
            regUser.FullName = fname;
            regUser.UserName = username;
            regUser.PassWord = password;
            regUser.PhoneNo = phone;
                regUser.UserType = "salesman";
                using (posEntities10 entity = new posEntities10())
                {
                    entity.registerUsers.Add(regUser);
                    entity.SaveChanges();
                    
                }
                label7.Text = "Registered";   
              }
            catch(Exception ex)
            {
                label7.Text = "Failed "+ex;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
    

