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
    public partial class Ingresar : Form
    {
        public List<Empleado> list = new List<Empleado>();
        public Ingresar()
        {
            InitializeComponent();
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {

        }

        private void enviarButton_Click(object sender, EventArgs e)
        {
           Empleado empleado = new Empleado();
            empleado.Cedula = Cedulatxt.Text;
            empleado.Salario = double.Parse(Salariotxt.Text);
            empleado.Nombre = Nombretxt.Text;
            empleado.Apellido = Apellidotxt.Text;
        }
    }
}
