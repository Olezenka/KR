using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Канторольная
{
    public partial class Form4 : Form
    {
        Model1 db = new Model1();
        public Boat boa { get; set; } = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (boa == null)
            {
                boatBindingSource.AddNew();
                this.Text = " Добавление новой записи";
            }
            else
            {
                boatBindingSource.Add(boa);
                boat_IDTextBox.ReadOnly = true;
                this.Text = " Корректировка  записи " + boa.boat_ID;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (boa == null)
            {
                boa = (Boat)boatBindingSource.List[0];
                db.Boat.Add(boa);
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
