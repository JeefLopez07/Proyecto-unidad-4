using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto.mysql;


namespace Proyecto.mysql
{
    class Funciones
    {
        public static int Agregar(Persona add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into persone(nombre,lada,telefono,edad)values('{0}','{1}','{2}','{3}')",
            add.Nombre, add.Lada, add.Telefono, add.Edad),Conexion.obtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }        
        public static List<Persona>mostrar()
        {
            List<Persona> lista = new List<Persona>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from persone"),Conexion.obtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona a = new Persona();
                a.Id = reader.GetInt32(0);
                a.Nombre = reader.GetString(1);
                a.Lada = reader.GetInt32(2);
                a.Telefono = reader.GetInt32(3);
                a.Edad = reader.GetInt32(4);
                lista.Add(a);
            }
            return lista;
        }

        public static List<Productos> mostrarInv()
        {
            List<Productos> lista = new List<Productos>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from productos"), Conexion.obtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Productos a = new Productos();
                a.idProducto = reader.GetInt32(0);
                a.Nombre = reader.GetString(1);
                a.Precio = reader.GetInt32(2);
                a.Stock = reader.GetInt32(3);
                lista.Add(a);
            }
            return lista;
        }

        public static List<Persona> Buscar(int id)
        {
            List<Persona> listaBusacar = new List<Persona>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from persone where id='{0}'", id), Conexion.obtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            while(reader.Read())
            {
                Persona a = new Persona();
                a.Id = reader.GetInt32(0);
                a.Nombre = reader.GetString(1);
                a.Lada = reader.GetInt32(2);
                a.Telefono = reader.GetInt32(3);
                a.Edad = reader.GetInt32(4);
                listaBusacar.Add(a);
            }
            return listaBusacar;
        }
        
        public static List<Productos> BuscarProducto(int id)
        {
            List<Productos> listaBusacar = new List<Productos>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from productos where idProducto='{0}'", id), Conexion.obtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Productos a = new Productos();
                a.idProducto = reader.GetInt32(0);
                a.Nombre = reader.GetString(1);
                a.Precio = reader.GetInt32(2);
                a.Stock = reader.GetInt32(3);                
                listaBusacar.Add(a);
            }
            return listaBusacar;
        }
       
        public static int eliminar(int id)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("delete from persone where id='{0}'", id), Conexion.obtenerConexion());
            int eliminado = comando.ExecuteNonQuery();
            return eliminado;
        }

        public static int eliminarProducto(int id)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("delete from productos where idProducto='{0}'", id), Conexion.obtenerConexion());
            int eliminado = comando.ExecuteNonQuery();
            return eliminado;
        }
    }
}
