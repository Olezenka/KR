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
    public partial class Form3 : Form
    {
        Model1 db = new Model1();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            boatBindingSource.DataSource = db.Boat.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 frm = new Form4();
                frm.boa = null;
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    boatBindingSource.DataSource = null;
                    boatBindingSource.DataSource = db.Boat.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boat boa = (Boat)boatBindingSource.Current;
            Form4 frm = new Form4();
            frm.boa = boa;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                boatBindingSource.DataSource = null;
                boatBindingSource.DataSource = db.Boat.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Boat boa = (Boat)boatBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить запись " + boa.boat_ID + "?", " Удаление записи");
            if (dr == DialogResult.OK)
            {
                db.Boat.Remove(boa);
                try
                {
                    db.SaveChanges();
                    boatBindingSource.DataSource = db.Boat.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }
    }
}
