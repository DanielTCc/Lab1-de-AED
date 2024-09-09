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
    public partial class Imprimir : Form
    {
        public List<Empleado> list = new List<Empleado>();
        public Imprimir()
        {
            InitializeComponent();
        }

        private void Imprimir_Load(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Cedula", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Salario", typeof(int));

            foreach (var empleado in list) 
            {
                dt.Rows.Add(
                    empleado.Cedula,
                    empleado.Nombre,
                    empleado.Apellido,
                    empleado.Salario
                );
            }

            ImpresoraDTG.DataSource = dt;
        }

        private void ImpresoraDTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
