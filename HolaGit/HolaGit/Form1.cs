using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BOTON ok
            MessageBox.Show(Saludar(textBox1.Text));
            //agregamos picturebox
            
        }


        private string Saludar(string nombre)
        {
            return "Hola como estas " + nombre + " gracias por usar esta aplicacion";
        }
    }
}
