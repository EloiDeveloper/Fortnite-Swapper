using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eloiswapper
{
    public partial class Picos : Form
    {
        public Picos()
        {
            InitializeComponent();
        }

        private void picominty_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.Picominty().Show();

        }

        private void Picos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.picogalaxy().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.Pala().Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.Vision().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.guadaña().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.Picofncs2().Show();
        }

        private void picofncs_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.Fncs().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.Star().Show();
        }

        private void picorenegada_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.Renegada().Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.Studed().Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.Quarterstaff().Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new Objetos.Picos.galaxyrenegade().Show();
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            new Objetos.Picos.harley().Show();
        }
    }
}
