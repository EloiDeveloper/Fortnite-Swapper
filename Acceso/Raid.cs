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


namespace Eloiswapper.Acceso
{
    public partial class Raid : Form
    {
        public Raid()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Process.Start("C:\\Users\\");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Process.Start("Tu enlace del Bot");
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("Estas seguro de que quieres cerrar Discord raid Bot?", "By Eloi35", MessageBoxButtons.OKCancel);
            if (cerrar == DialogResult.OK)
            {
                Application.Exit();

            }
        }
    }
}
