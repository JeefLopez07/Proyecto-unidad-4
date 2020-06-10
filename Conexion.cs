using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto.mysql;


namespace Proyecto.mysql
{
    class Conexion
    {
        public static  MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;database=proyecto;Uid=root;pwd=r123;");
            conexion.Open();
            return conexion;
        }
    }
    
}
