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
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.Hide();
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Random random = new Random();

            e.Cancel = true;
            Form3 frm3 = new Form3();
            frm3.StartPosition = FormStartPosition.Manual;
            frm3.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
            frm3.Show();
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
