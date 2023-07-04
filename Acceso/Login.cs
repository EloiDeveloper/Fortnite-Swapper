using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Eloiswapper.Acceso
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        


        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textPassword.Text == "Eloi" && textUsername.Text == "353535")
            {
                MessageBox.Show("¡Correcto! :)");
                new Loader().Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contrasenya es incorreto/a");
                textUsername.Clear();
                textPassword.Clear();
                textUsername.Focus();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
