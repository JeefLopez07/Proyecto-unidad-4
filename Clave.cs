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
    public partial class Clave : Form
    {
        public Clave()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int clave = int.Parse(txtClave.Text);
            if (clave == 4517)
            {
                MessageBox.Show($"Bienvenido al inventario {nombre}");
                Form formInventario = new Registro();
                formInventario.Show();
            }
            else
            {
                MessageBox.Show($"{nombre} usted no es un empleado");
                Application.Exit();
            }
        }
    }
}
