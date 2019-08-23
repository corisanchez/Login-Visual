using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
          
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "juancho" & contra.Text == "123tamarindo")
            {
                MessageBox.Show("Ta' bien, si eres.");
            }
            else
            {
                MessageBox.Show("Sacate de aqui, no eres.");
            }
        }
    }
}
