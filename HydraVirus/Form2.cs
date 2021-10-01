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
            e.Cancel = true;
            Form3 frm3 = new Form3();
            frm3.Show();
            Form1 frm1 = new Form1();
            frm1.Show();
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
