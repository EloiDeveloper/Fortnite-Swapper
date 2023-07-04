using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eloiswapper.Server
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            {
                {
                    {
                        string[] FNStuff = { "FortniteClient-Win64-Shipping_EAC.exe", "FortniteClient-Win64-Shipping_BE.exe", "FortniteLauncher.exe" };

                        foreach (string procname in FNStuff)
                        {
                            var process = Process.GetProcessesByName(procname);
                            foreach (var proc in process)
                            {
                                proc.Kill();
                            }
                        }
                        string TempPath = Path.GetTempPath();
                        var Path1 = "";
                        var version = "1";

                        var path1 = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
                        dynamic Json = Newtonsoft.Json.JsonConvert.DeserializeObject(path1);

                        foreach (var installion in Json.InstallationList)
                        {
                            if (installion.AppName == "Fortnite")
                            {
                                Path1 = installion.InstallLocation.ToString() + "\\FortniteGame\\Binaries\\Win64";
                                version = installion.AppVersion.ToString().Split('-')[1];
                            }
                        }
                        if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.old")) { }
                        else
                        {
                            File.Move(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe.old");
                        }

                        if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.old")) { }
                        else
                        {
                            File.Move(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe.old");
                        }

                        WebClient webClient = new WebClient();

                        await webClient.DownloadFileTaskAsync("anti ac link", TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe");
                        await webClient.DownloadFileTaskAsync("anti ac link", TempPath + "\\FortniteClient-Win64-Shipping_BE.exe");
                        if (!File.Exists(TempPath + "\\dllname.dll"))
                        {
                            await webClient.DownloadFileTaskAsync("dll link", TempPath + "\\dllname.dll");
                        }

                        if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe"))
                        {
                            File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
                        }
                        else
                        {
                            File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
                            File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
                        }

                        if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe"))
                        {
                            File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
                        }
                        else
                        {
                            File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
                            File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
                        }

                        if (!File.Exists(Path1 + "\\dllname.dll"))
                        {
                            File.Move(TempPath + "\\dllname.dll", Path1 + "\\dllname.dll");
                        }
                        else
                        {
                            File.Delete(Path1 + "\\dllname.dll");
                            File.Move(TempPath + "\\dllname.dll", Path1 + "\\dllname.dll");
                        }


                        var Proc = new ProcessStartInfo();
                        Proc.CreateNoWindow = true;
                        Proc.FileName = "cmd.exe";
                        Proc.Arguments = "/C start com.epicgames.launcher://apps/Fortnite?action=launch";
                        Process.Start(Proc);
                        MessageBox.Show("Eloi35 Fn se ha iniciado correctamente");


                    }

                }

            }


        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }
    }
    
}
