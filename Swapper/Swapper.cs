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


namespace Eloiswapper
{
    
    public partial class Swapper : Form
    {
        public Swapper()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Skins());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No ponga emoticonos en la primera fila de bailes!");
            AbrirFormEnPanel(new Bailes());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/KSaGx5RxmV");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Picos());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Mochilas());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC_JU1GYEe7A7iUnpQ6z_wcg");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Swapper_Load(object sender, EventArgs e)
        {
           /* System.Diagnostics.Process.Start("https://discord.gg/KSaGx5RxmV"); */
            MessageBox.Show("Este Swapper a Sido Creado Por Eloi35!" +
                "" +
                "                          Y los codigos por Xoid");

            MessageBox.Show("¿Para que no te quiten de la partida pon solo dos cosas!");
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e) 
        {
            DialogResult cerrar = MessageBox.Show("Estas seguro de que quieres cerrar Eloi35 Swapper?", "Cerrar Eloi35 Swapper", MessageBoxButtons.OKCancel);
            if (cerrar == DialogResult.OK)
            {
                Application.Exit();

            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Skins());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Picos());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Bailes());
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Mochilas());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new Ajustes().Show();
        }

        private void Swapper_MouseDown(object sender, MouseEventArgs e)
        { 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
           
        }

        private void panelcontenedor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            new Acceso.Prni().Show();
            this.Hide();
        }
    }
}
