using Proyecto.mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text))
                MessageBox.Show("Ingrerse un id para poder realizar la busqueda");
            else
            {
                dataGridView1.DataSource = Funciones.BuscarProducto(int.Parse(txtID.Text));

            }
        }
        public void limpiar()
        {
            txtID.Clear();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int eliminado = Funciones.eliminarProducto(int.Parse(txtID.Text));
            if (eliminado > 0)
            {
                MessageBox.Show("El registro fue eliminado con exito");
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
