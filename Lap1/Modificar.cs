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
    public partial class Modificar : Form
    {
        public List<Empleado> list = new List<Empleado>();
        public Modificar()
        {
            InitializeComponent();
        }

        private void enviarButton_Click(object sender, EventArgs e)
        {
            foreach (var empleado in list) 
            {
                if (empleado.Cedula.Equals(Cedulatxt))
                {

                    empleado.Cedula = Cedulatxt.Text;
                    empleado.Salario = double.Parse(Salariotxt.Text);
                    empleado.Nombre = Nombretxt.Text;
                    empleado.Apellido = Apellidotxt.Text;

                }
            }
        }
    }
}
