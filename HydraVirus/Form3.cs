using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydraVirus
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            this.Hide();
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Random random = new Random();

            e.Cancel = true;
            Form2 frm2 = new Form2();
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
            frm2.Show();
            Form1 frm1 = new Form1();
            frm1.StartPosition = FormStartPosition.Manual;
            frm1.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
            frm1.Show();
            Form4 frm4 = new Form4();
            frm4.StartPosition = FormStartPosition.Manual;
            frm4.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
            frm4.Show();
        }
    }
}
