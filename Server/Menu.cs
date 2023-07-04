using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Eloiswapper.Server
{
    public partial class Menu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AbrirFormEnPanel(object form)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();

        }

        public Menu()
        {
            InitializeComponent();
        }

        private void Launcher_MouseDown(object sender, MouseEventArgs e)
        {
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }

        private void panelcontenedor_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Server.Launcher());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Server.Ayuda());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Server.Social());
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Acceso.Prni().Show();
            this.Hide();
        }
    }
}
