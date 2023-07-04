using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Eloiswapper.Properties;

namespace Eloiswapper
{
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Buscarcarpeta_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Settings.Default.paksPath = dialog.FileName;
                Settings.Default.Save();
                textBox1.Text = Settings.Default.paksPath;
            }
        }

        public static string GetPaksFolder
        {
            get { return Settings.Default.paksPath; }
        }



        public static string GetStrechedFolder
        {
            get { return Settings.Default.strechedFolder; }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Ajustes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("com.epicgames.launcher://apps/Fortnite?action=launch&silent=true");
            while (true)
            {
                Process[] ProcessID = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
                if (ProcessID.Length == 0);

                else
                {
                    ProcessID[0].WaitForExit();
                    Process.GetProcessesByName("EpicGamesLauncher")[0].Kill();
                    Environment.Exit(0);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string PakFolder = Properties.Settings.Default.paksPath;
            System.IO.DirectoryInfo di = new DirectoryInfo(PakFolder);
            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Extension == ".ucas")
                {
                    var Matching = FindMatchingLength(file.Length, file.Name);
                    if (Matching != null)
                    {
                        //So Which Ever File Is Smaller Will Be Our Normal Ucas And Which Ever Is Bigger Name Length Is Duped
                        if (Matching.Length > file.Name.Length)
                        {
                            try
                            {
                                File.Delete(PakFolder + "\\" + Matching);
                                if (File.Exists(PakFolder + "\\" + Matching.Replace(".ucas", ".utoc")))
                                    File.Delete(PakFolder + "\\" + Matching.Replace(".ucas", ".utoc"));
                                if (File.Exists(PakFolder + "\\" + Matching.Replace(".ucas", ".pak")))
                                    File.Delete(PakFolder + "\\" + Matching.Replace(".ucas", ".pak"));
                                if (File.Exists(PakFolder + "\\" + Matching.Replace(".ucas", ".sig")))
                                    File.Delete(PakFolder + "\\" + Matching.Replace(".ucas", ".sig"));
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show(this, $"error!\n{error.ToString()}\nERror.", "Rr!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                                return;
                            }
                        }
                    }
                }
            }
           
            foreach (DirectoryInfo PakDirList in di.GetDirectories())
            {
                try
                {
                    foreach (string Paks in Directory.EnumerateFiles(PakDirList.FullName, "*.pak*", SearchOption.AllDirectories))
                        File.Delete(Paks);
                    foreach (string Sigs in Directory.EnumerateFiles(PakDirList.FullName, "*.sig*", SearchOption.AllDirectories))
                        File.Delete(Sigs);
                    foreach (string Ucas in Directory.EnumerateFiles(PakDirList.FullName, "*.ucas*", SearchOption.AllDirectories))
                        File.Delete(Ucas);
                    foreach (string Utocs in Directory.EnumerateFiles(PakDirList.FullName, "*.utoc*", SearchOption.AllDirectories))
                        File.Delete(Utocs);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error");
                }
            }
            
            System.Diagnostics.Process.Start("com.epicgames.launcher://apps/Fortnite?action=verify&silent=false");
            MessageBox.Show("Verificando");
        }

        public static string FindMatchingLength(long length, string CurrentPakName)
        {
            string PakFolder = Properties.Settings.Default.paksPath;
            System.IO.DirectoryInfo di = new DirectoryInfo(PakFolder);

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Extension == ".ucas")
                {
                    if (file.Length == length)
                        if (file.Name != CurrentPakName)
                            return file.Name;
                }
            }
            return null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo para Creadores");
            new Acceso.Raid().Show(); 
        }
    }


}