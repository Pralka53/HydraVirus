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
    public partial class Form4 : Form
    {
        public Form4()
        {
            this.Hide();
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, 1270);
            int y = random.Next(0, 920);

            e.Cancel = true;
            Form2 frm2 = new Form2();
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(x, y);
            frm2.Show();
            Form1 frm1 = new Form1();
            frm1.StartPosition = FormStartPosition.Manual;
            frm1.Location = new Point(x, y);
            frm1.Show();
            Form3 frm3 = new Form3();
            frm3.StartPosition = FormStartPosition.Manual;
            frm3.Location = new Point(x, y);
            frm3.Show();
        }
    }
}
