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
    public partial class Bailes : Form
    {
        public Bailes()
        {
            InitializeComponent();
        }

        private void Bailes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Objetos.Bailes.scenario().Show();
        }

        private void Skinrenegada_Click(object sender, EventArgs e)
        {
            new Objetos.Bailes.Floss().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Objetos.Bailes.sacapico().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Objetos.Bailes.Takethel().Show();
        }
    }
}
