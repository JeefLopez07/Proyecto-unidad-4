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
using MySql.Data.MySqlClient;

namespace Proyecto
{
    public partial class Cliente_registrado : Form
    {
        public Cliente_registrado()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuaaa_Click(object sender, EventArgs e)
        {
            Persona a = new Persona();
            string Buscar(int id)
            {
                Persona listaBusacar = new Persona();
                MySqlCommand comando = new MySqlCommand(String.Format("select * from persone where id='{0}'", id), Conexion.obtenerConexion());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {                    
                    a.Id = reader.GetInt32(0);
                    a.Nombre = reader.GetString(1);
                }
                return a.Nombre=reader.GetString(1);
            }
            

            if (String.IsNullOrWhiteSpace(txtID.Text))
                MessageBox.Show("Ingrerse un nombre para poder realizar la busqueda");
            else
            {
                MessageBox.Show($"Bienvenido {Buscar(int.Parse(txtID.Text))}");
            }            
            Form formCategorias = new Categorias();
            formCategorias.Show();
        }
    }
}
