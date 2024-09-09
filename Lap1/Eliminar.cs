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
    public partial class Eliminar : Form
    {
        public List<Empleado> list = new List<Empleado>();
 
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            foreach (var empleado in list)
            {

                if (empleado.Cedula.Equals(Cedulatxt.Text))
                {
                    list.Remove(empleado);
                }
            }
        }

        private void enviarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
