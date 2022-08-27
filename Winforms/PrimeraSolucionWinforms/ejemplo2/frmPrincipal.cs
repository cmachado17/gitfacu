using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            //agrego un comentario para ver si me modifica la consola
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)//accedo a la coleccion de formularios de la aplicacion
            {
                if(item.GetType() == typeof(Form1)) // si el mismo tipo de objeto
                {
                    MessageBox.Show("Ya existe esta ventana abierta, trabaje alli");
                    return;
                }
            } 

            Form1 ventana = new Form1();
            ventana.MdiParent = this;//para indicarle cual es su ventana padre
            //ventana.Show();
            ventana.Show(); //contexto del momento (para no instanciarlo de nuevo)
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.MdiParent = this;//para indicarle cual es su ventana padre
            ventana.Show(); //contexto del momento (para no instanciarlo de nuevo)
        }
    }
}
