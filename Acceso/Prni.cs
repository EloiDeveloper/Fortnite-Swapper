using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eloiswapper.Acceso
{
    public partial class Prni : Form
    {
        public Prni()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Swapper().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Server.Menu().Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Prni_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Swapper desactualizado, creado con metodo viejo(no recomendado). No lo voy a actualizar");
        }
    }
}
