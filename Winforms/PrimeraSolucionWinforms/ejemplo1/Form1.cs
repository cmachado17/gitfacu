using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e) //evento de click
        {
            //MessageBox.Show("Hola mundo"); //mostrar un cartelito de mensaje
            string nombre = txtNombre.Text;
            labelSaludo.Text = "Hola " + nombre;
        }

        private void Form1_Load(object sender, EventArgs e) //cuando carga
        {
            //MessageBox.Show("Bienvenido");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Nos vemos perri");
        }
    }
}
