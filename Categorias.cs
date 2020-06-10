using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Proyecto.mysql;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace Proyecto
{
    public partial class Categorias : Form
    {
        Productos miJersey1 = new Productos();
        Productos miJersey2 = new Productos();
        Productos miJersey3 = new Productos();
        Productos miShort1 = new Productos();
        Productos miShort2 = new Productos();
        Productos miShort3 = new Productos();
        Productos miGuante1 = new Productos();
        Productos miGuante2 = new Productos();
        Productos miGuante3 = new Productos();
        Productos miTachon1 = new Productos();
        Productos miTachon2 = new Productos();
        Productos miTachon3 = new Productos();
        Productos miTachon4 = new Productos();
        Productos miBalon1 = new Productos();
        Productos miBalon2 = new Productos();
        Productos miBalon3 = new Productos();
        Productos miAccesorio1 = new Productos();
        Productos miAccesorio2 = new Productos();
        Productos miAccesorio3 = new Productos();
        MailMessage miMensaje = new MailMessage();

        public Categorias()
        {
            InitializeComponent();
            
        }

        int CantidadJerseys()
        {
            miJersey1.CantidadComprada = Convert.ToInt32(nudChivas.Value);
            miJersey2.CantidadComprada = Convert.ToInt32(nudSantos.Value);
            miJersey3.CantidadComprada = Convert.ToInt32(nudAmerica.Value);
            miJersey1.Stock = 150 - miJersey1.CantidadComprada;
            miJersey2.Stock = 150 - miJersey2.CantidadComprada;            
            miJersey3.Stock = 150 - miJersey3.CantidadComprada;

            int sumaJerseys = miJersey1.CantidadComprada + miJersey2.CantidadComprada + miJersey3.CantidadComprada;
            return sumaJerseys;
        }
        int CantidadShort()
        {
            miShort1.CantidadComprada = Convert.ToInt32(nudSNike.Value);
            miShort2.CantidadComprada = Convert.ToInt32(nudSAdidas.Value);
            miShort3.CantidadComprada = Convert.ToInt32(nudSPuma.Value);
            miShort1.Stock = 150 - miShort1.CantidadComprada;
            miShort2.Stock = 150 - miShort2.CantidadComprada;
            miShort3.Stock = 150 - miShort3.CantidadComprada;

            int sumaShort = miShort1.CantidadComprada + miShort2.CantidadComprada + miShort3.CantidadComprada;
            return sumaShort;
        }
        int CantidadGuantes()
        {
            miGuante1.CantidadComprada = Convert.ToInt32(nudRinat.Value);
            miGuante2.CantidadComprada = Convert.ToInt32(nudPredator.Value);
            miGuante3.CantidadComprada = Convert.ToInt32(nudGMercurial.Value);
            miGuante1.Stock = 150 - miGuante1.CantidadComprada;
            miGuante2.Stock = 150 - miGuante2.CantidadComprada;
            miGuante3.Stock = 150 - miGuante3.CantidadComprada;

            int sumaGuantes = miGuante1.CantidadComprada + miGuante2.CantidadComprada + miGuante2.CantidadComprada;
            return sumaGuantes;
        }
        int CantidadTachones()
        {
            miTachon1.CantidadComprada = Convert.ToInt32(nudCopaMundial.Value);
            miTachon2.CantidadComprada = Convert.ToInt32(nudMercurial.Value);
            miTachon3.CantidadComprada = Convert.ToInt32(nudCopa20.Value);
            miTachon4.CantidadComprada = Convert.ToInt32(nudOne.Value);
            miTachon1.Stock = 150 - miTachon1.CantidadComprada;
            miTachon2.Stock = 150 - miTachon2.CantidadComprada;
            miTachon3.Stock = 150 - miTachon3.CantidadComprada;
            miTachon4.Stock = 150- -miTachon4.CantidadComprada;

            int sumaTachones = miTachon1.CantidadComprada + miTachon2.CantidadComprada + miTachon3.CantidadComprada + miTachon4.CantidadComprada;
            return sumaTachones;
        }
        int CantidadBalones()
        {
            miBalon1.CantidadComprada = Convert.ToInt32(nudVoit.Value);
            miBalon2.CantidadComprada = Convert.ToInt32(nudLaliga.Value);
            miBalon3.CantidadComprada = Convert.ToInt32(nudMLS.Value);
            miBalon1.Stock = 150 - miBalon1.CantidadComprada;
            miBalon2.Stock = 150 - miBalon2.CantidadComprada;
            miBalon3.Stock = 150 - miBalon3.CantidadComprada;

            int sumaBalones = miBalon1.CantidadComprada + miBalon2.CantidadComprada + miBalon3.CantidadComprada;
            return sumaBalones;
        }
        int CantidadAccesorios()
        {
            miAccesorio1.CantidadComprada = Convert.ToInt32(nudConjunto.Value);
            miAccesorio2.CantidadComprada = Convert.ToInt32(nudKit.Value);
            miAccesorio3.CantidadComprada = Convert.ToInt32(nudMaleta.Value);
            miAccesorio1.Stock = 150 - miAccesorio1.CantidadComprada;
            miAccesorio2.Stock = 150 - miAccesorio2.CantidadComprada;
            miAccesorio3.Stock = 150 - miAccesorio3.CantidadComprada;

            int sumaAccesorios = miAccesorio1.CantidadComprada + miAccesorio2.CantidadComprada + miAccesorio3.CantidadComprada;
            return sumaAccesorios;
        }
        int PagoTotal()
        {
            int PagoJerseys = CantidadJerseys() * 1100;
            int PagoShort = CantidadShort() * 750;
            int PagoGuante = CantidadGuantes() * 1600;
            int PagoTachones = CantidadTachones() * 1600;
            int PagoBalones = CantidadBalones() * 900;
            int PagoAccesorios = CantidadAccesorios() * 900;
            int CompraTotal = PagoJerseys + PagoShort + PagoGuante + PagoTachones + PagoBalones + PagoAccesorios;
            return CompraTotal;
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Jerseys    {CantidadJerseys()}\n" +
                            $"Shorts     {CantidadShort()}\n" +
                            $"Guantes    {CantidadGuantes()}\n" +
                            $"Tachones   {CantidadTachones()}\n" +
                            $"Balones    {CantidadBalones()}\n" +
                            $"Accesorios {CantidadAccesorios()}\n");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnChivas_Click(object sender, EventArgs e)
        {            
            miJersey1.idProducto = 1;          

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miJersey1.Stock} where idProducto={miJersey1.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miJersey1.idProducto);
        }

        private void btnSantos_Click(object sender, EventArgs e)
        {

            miJersey2.idProducto = 2;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miJersey2.Stock} where idProducto={miJersey2.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miJersey2.idProducto);
        }

        private void btnAmerica_Click(object sender, EventArgs e)
        {
            miJersey3.idProducto = 3;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miJersey3.Stock} where idProducto={miJersey3.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miJersey3.idProducto);            
        }

        private void btnAgShortNike_Click(object sender, EventArgs e)
        {
            miShort1.idProducto = 4;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miShort1.Stock} where idProducto={miShort1.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miShort1.idProducto);
        }

        private void btnSAdidas_Click(object sender, EventArgs e)
        {
            miShort2.idProducto = 5;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miShort2.Stock} where idProducto={miShort2.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miShort2.idProducto);
        }

        private void btnSPuma_Click(object sender, EventArgs e)
        {
            miShort3.idProducto = 6;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miShort3.Stock} where idProducto={miShort3.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miShort3.idProducto);            
        }

        private void btnRinat_Click(object sender, EventArgs e)
        {
            miGuante1.idProducto = 11;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miGuante1.Stock} where idProducto={miGuante1.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miGuante1.idProducto);            
        }

        private void bntPredator_Click(object sender, EventArgs e)
        {
            miGuante2.idProducto = 12;           

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miGuante2.Stock} where idProducto={miGuante2.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miGuante2.idProducto);            
        }

        private void btnGNike_Click(object sender, EventArgs e)
        {
            miGuante3.idProducto = 13;
            
            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miGuante3.Stock} where idProducto={miGuante3.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miGuante3.idProducto);
        }

        private void btnCopaMundial_Click(object sender, EventArgs e)
        {
            miTachon1.idProducto = 7;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miTachon1.Stock} where idProducto={miTachon1.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miTachon1.idProducto);
        }

        private void btnMercurial_Click(object sender, EventArgs e)
        {
            miTachon2.idProducto = 8;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miTachon2.Stock} where idProducto={miTachon2.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miTachon2.idProducto);
        }

        private void btnCopa_Click(object sender, EventArgs e)
        {
            miTachon3.idProducto = 9;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miTachon3.Stock} where idProducto={miTachon3.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miTachon3.idProducto);
        }

        private void btnPumaOne_Click(object sender, EventArgs e)
        {
            miTachon4.idProducto = 10;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miTachon4.Stock} where idProducto={miTachon4.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miTachon4.idProducto);
        }

        private void btnVoit_Click(object sender, EventArgs e)
        {
            miBalon1.idProducto = 14;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miBalon1.Stock} where idProducto={miBalon1.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miBalon1.idProducto);
        }

        private void btnLaLiga_Click(object sender, EventArgs e)
        {
            miBalon2.idProducto = 15;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miBalon2.Stock} where idProducto={miBalon2.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miBalon2.idProducto);
        }

        private void btnMLS_Click(object sender, EventArgs e)
        {
            miBalon3.idProducto = 10;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miBalon3.Stock} where idProducto={miBalon3.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miBalon3.idProducto);
        }

        private void btnConjunto_Click(object sender, EventArgs e)
        {
            miAccesorio1.idProducto = 17;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miAccesorio1.Stock} where idProducto={miAccesorio1.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miAccesorio1.idProducto);
        }

        private void btnKit_Click(object sender, EventArgs e)
        {
            miAccesorio2.idProducto = 18;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miAccesorio2.Stock} where idProducto={miAccesorio2.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miAccesorio2.idProducto);
        }

        private void btnMaleta_Click(object sender, EventArgs e)

        {
            miAccesorio3.idProducto = 19;

            int ActualizarStock(int id)
            {
                int retorna = 0;
                MySqlCommand comando = new MySqlCommand(String.Format($"update productos set stock={miAccesorio3.Stock} where idProducto={miAccesorio3.idProducto}"), Conexion.obtenerConexion());
                retorna = comando.ExecuteNonQuery();
                return retorna;
            }
            int retorno = ActualizarStock(miAccesorio3.idProducto);
        }        

        private void btnComprar_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\Usuario\Desktop\tikets\Tiket.txt");
            try
            {
                   escribir.WriteLine($"*************DepShop*************\n" +
                                       $"     {DateTime.Now}        \n" +
                                       $"\n" +
                                       $"\n" +
                                       $"\n" +
                                       $"Articulos    Cantidad       Precio\n" +
                                       $"Jerseys          {CantidadJerseys()}          {CantidadJerseys() * 1100}\n" +
                                       $"Short            {CantidadShort()}            {CantidadShort() * 750}\n" +
                                       $"Guantes          {CantidadGuantes()}            {CantidadGuantes() * 1600}\n" +
                                       $"Tachones         {CantidadTachones()}            {CantidadTachones() * 1600}\n" +
                                       $"Balones          {CantidadBalones()}            {CantidadBalones() * 900}\n" +
                                       $"Accesorios       {CantidadAccesorios()}            {CantidadAccesorios() * 900}\n" +
                                       $"Total a Pagar                 {PagoTotal()}");                
                MessageBox.Show("La compra se realiza con exito");
                Application.Exit();
            }
            catch
            {
                MessageBox.Show($"Error");
            }                       
            escribir.Close();
            Random aleatorio = new Random();
            int numero;
            numero = aleatorio.Next(0, 45000);

            string Origen = "jeeflopez07@gmail.com";
            string Destino = txtEMail.Text;
            string Contraseña = "r1j2l3m4yo";
            string Archivo = @"C:\Users\Usuario\Desktop\tikets\Tiket.txt";

            MailMessage miMensaje = new MailMessage();
            miMensaje.Subject = "Tiket de compra";
            miMensaje.To.Add(new MailAddress(Destino));
            miMensaje.From = new MailAddress(Origen);
            miMensaje.Attachments.Add(new Attachment(Archivo));
            miMensaje.Body = ($"Buen dia..... Gracias por su compra en ***DepShop***, un placer estar a su servicio\n" +
                              $"Direccion {txtDireccion.Text}\n" +
                              $"Su numero de guia es {numero}");
            int intPuerto = 0;
            switch (cboNombreServidor.Text)
            {
                case "smtp.live.com":
                    intPuerto = 465;
                    break;
                case "smtp.yahoo.com":
                    intPuerto = 426;
                    break;
                case "smtp.gmail.com":
                    intPuerto = 587;
                    break;
            }
            SmtpClient smtpCliente = new SmtpClient(cboNombreServidor.Text);
            smtpCliente.EnableSsl = true;
            smtpCliente.UseDefaultCredentials = false;
            smtpCliente.Port = intPuerto;
            smtpCliente.Credentials = new System.Net.NetworkCredential(Origen, Contraseña);
            smtpCliente.Send(miMensaje);
            smtpCliente.Dispose();
            escribir = null;
        }
    }
}
