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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Session.Form = this;
            login.ShowDialog();
        }

        internal void UpdateMainForm()
        {
            foreach(Car item in Database.Cars)
            {
                GroupBox groupbox = new GroupBox();
                groupbox.Text = "Car01";
                groupbox.Size = new Size(194, 262);
                groupbox.Location = new Point(12, 92);

                Label label = new Label()
                {
                    Text = "Marka",
                    Location = new Point(7, 35)
                };

                Label label2 = new Label()
                {
                    Text = item.Marka.Name,
                    Location = new Point(6, 63)
                };

                Label label3 = new Label()
                {
                    Text = "Model",
                    Location = new Point(6, 63)
                };

                Label label4 = new Label()
                {
                    Text = item.Model.Name,
                    Location = new Point(97, 63)
                };

                groupbox.Controls.AddRange(new Control[] { label, label2, label3, label4 });
                this.Controls.Add(groupbox);
            }
           

        }
    }
}
