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
    public partial class Mochilas : Form
    {
        public Mochilas()
        {
            InitializeComponent();
        }

        private void Mochilas_Load(object sender, EventArgs e)
        {

        }

        private void picominty_Click(object sender, EventArgs e)
        {
            new Objetos.Mochilas.Blackshield().Show();
        }
    }
}
