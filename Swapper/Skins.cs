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
    public partial class Skins : Form
    {
        public Skins()
        {
            InitializeComponent();
        }

        private void skinhonor_Click(object sender, EventArgs e)
        {

        }

        private void skinikonik_Click(object sender, EventArgs e)
        {
            
        }

        private void Skins_Load(object sender, EventArgs e)
        {

        }

        private void Skinrenegada_Click(object sender, EventArgs e)
        {
            new Objetos.Piels.RenegadeRaider().Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Objetos.Skins.Ariadnagrande().Show();

        }

        private void skinwonder_Click(object sender, EventArgs e)
        {
            new Objetos.Skins.Wonder().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Objetos.Skins.Klombo().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Objetos.Skins.Psycho_Bandit().Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Objetos.Piels.cenaconosin().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Objetos.Piels.Sculltrupper().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Objetos.Piels.Galaxyrenegade().Show();
        }

        private void skinzombirosa_Click(object sender, EventArgs e)
        {
            new Objetos.Piels.goultropper().Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new Objetos.Piels.Goku().Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            new Objetos.Piels.Travisscoot().Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new Objetos.Piels.Wildcat().Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            new Objetos.Piels.Eliteagent().Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new Objetos.Piels.iconic().Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            new Objetos.Piels.cenaconosin().Show();
        }
    }
}
