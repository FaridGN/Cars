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
    public partial class Addcar : Form
    {
        public Addcar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Addcar_Load(object sender, EventArgs e)
        {
            List<Marka> markas = Database.Markas;
            comb1.DataSource = markas;
            comb1.DisplayMember = "Name";
            comb1.ValueMember = "Id";
            comb1_SelectedIndexChanged(null, null);
        }

        private void comb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(comb1.SelectedValue is Marka))
            {
                int markaid = Convert.ToInt32(comb1.SelectedValue.ToString());
                List<Model> models = Database.Getmodels(markaid);
                comb2.DataSource = models;
                comb2.DisplayMember = "Name";
                comb2.ValueMember = "Id";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int modelid = Convert.ToInt32(comb2.SelectedValue.ToString());
            int markid = Convert.ToInt32(comb1.SelectedValue.ToString());
            Car car = new Car()
            {
                Detailedinfo = textBox1.Text,
                Marka = new Marka()
                {
                    Id = markid,
                    Name = Database.GetMarkaNameById(markid)
                },
                Model = new Model()
                {
                    Id = modelid,
                    MarkaId = markid,
                    Name = Database.GetModelNameById(modelid)
                },
                   ModelID = modelid,
                   Year = Convert.ToUInt16(yeartxt.Text)
                
            };

            Database.Cars.Add(car);

            Session.Form.UpdateMainForm();

        }
    }
}
