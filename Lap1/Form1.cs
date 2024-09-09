using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.MdiParent = this;
            ingresar.Show();
        }

        private void ingresarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar();
            modificar.MdiParent = this;
            modificar.Show();
        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.MdiParent = this;
            eliminar.Show();
        }

        private void imprimirGestioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir imprimir = new Imprimir();
            imprimir.MdiParent = this;
            imprimir.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
