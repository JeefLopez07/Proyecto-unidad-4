using MySql.Data.MySqlClient;
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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }       
        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conexion.obtenerConexion();
            MessageBox.Show("Gracias por su visita");
            Form formTipo = new Tipo();
            formTipo.Show();           
                        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
