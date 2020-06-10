using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.mysql
{
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID.Text))
                MessageBox.Show("Ingrerse un nombre para poder realizar la busqueda");
            else
            {
                dataGridView1.DataSource = Funciones.Buscar(int.Parse(txtID.Text));
                
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        
        
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int eliminado = Funciones.eliminar(int.Parse(txtID.Text));
            if(eliminado>0)
            {
                MessageBox.Show("El registro fue eliminado con exito");
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }
        public void limpiar()
        {
            txtID.Clear();
        }

        private void Buscador_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
