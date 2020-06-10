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
    public partial class Tipo : Form
    {
        public Tipo()
        {
            InitializeComponent();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Form formClave = new Clave();
            formClave.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form formRegistrarme = new Registrate();
            formRegistrarme.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
