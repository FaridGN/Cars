using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = loguser.Text,
                Password = logpassword.Text

            };
           
            if (!Database.FindUser(user))
            {
                Addcar newcar = new Addcar();
                newcar.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }
    }
}
