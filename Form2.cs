using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Proyecto.mysql;

namespace Proyecto
{
    public partial class Registro : Form
    {
        Persona miPersona = new Persona();       
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegDatos_Click(object sender, EventArgs e)
        {
            miPersona.Nombre = txtNomPer.Text;
            miPersona.Lada = int.Parse(txtLad.Text);
            miPersona.Telefono = int.Parse(txtTelefono.Text);
            miPersona.Edad = int.Parse(txtEdad.Text);
            int retorno = Funciones.Agregar(miPersona);

            if (retorno > 0) MessageBox.Show("Se agrego una nueva persona");
            else MessageBox.Show("No se pudo agregaar una nueva persona");
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            Mostrar ver = new Mostrar();
            ver.ShowDialog();
            this.Show();            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buscador b = new Buscador();
            b.ShowDialog();
            this.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario verInv = new Inventario();
            verInv.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarProducto b = new BuscarProducto();
            b.ShowDialog();
            this.Show();
        }

        private void btnRegProducto_Click(object sender, EventArgs e)
        {
            
            miPersona.Lada = int.Parse(txtLad.Text);
            miPersona.Telefono = int.Parse(txtTelefono.Text);
            miPersona.Edad = int.Parse(txtEdad.Text);
            int retorno = Funciones.Agregar(miPersona);

            if (retorno > 0) MessageBox.Show("Se agrego una nueva persona");
            else MessageBox.Show("No se pudo agregaar una nueva persona");
        }
    }
}
