using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.mysql;

namespace Proyecto
{
    public partial class Registrate : Form
    {
        Persona miPersona = new Persona();
        public Registrate()
        {
            InitializeComponent();
        }

        private void btnRegistrame_Click(object sender, EventArgs e)
        {
            miPersona.Nombre = txtNomPer.Text;
            miPersona.Lada = int.Parse(txtLad.Text);
            miPersona.Telefono = int.Parse(txtTelefono.Text);
            miPersona.Edad = int.Parse(txtEdad.Text);
            int retorno = Funciones.Agregar(miPersona);

            if (retorno > 0)
            {
                MessageBox.Show($"{txtNomPer.Text} fue realizado con exito");
                Form formCategorias = new Categorias();
                formCategorias.Show();
                this.Close();
            }
            else MessageBox.Show($"{txtNomPer.Text} lo sentimos no pudimos realizar tu registro");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYaRegistrado_Click(object sender, EventArgs e)
        {
            Form formRegistrado = new Cliente_registrado();
            formRegistrado.Show();
        }
    }
}
