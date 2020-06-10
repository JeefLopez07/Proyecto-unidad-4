using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class CorreoElectronico
    {
        private string _strEmailRemitente;
        public string EmailRemitente
        {
            get { return _strEmailRemitente; }
            set
            {
                if (value == "")
                    throw new Exception("No deje en blanco la dirección de correo electrónico del remitente");
                else
                    _strEmailRemitente = value;
            }
        }
        private string _strPassword;
        public string Password
        {
            set
            {
                if (value == "")
                    throw new Exception("No deje en blanco la contraseña del correo electrónico del remitente");
                else
                    _strPassword = value;
            }
            private get { return _strPassword; }
        }
        private string _strDireccionServidor;
        private string DireccionServidor
        {
            get { return _strDireccionServidor; }
            set
            {
                if (value == "")
                    throw new Exception("No deje en blanco la dirección del servidor SMTP");
                else
                    _strDireccionServidor = value;
            }
        }
        private int _intPuerto;
        public int Puerto
        {
            set
            {
                if (value <= 0)
                    _intPuerto = 25;
                else
                    _intPuerto = value;
            }
            private get { return _intPuerto; }
        }
        public void Enviar(System.Net.Mail.MailMessage miMensaje)
        {
            System.Net.Mail.SmtpClient miCliente = new System.Net.Mail.SmtpClient(DireccionServidor, Puerto);
            
            miCliente.Credentials = new System.Net.NetworkCredential(EmailRemitente, Password);
            
            miCliente.EnableSsl = true;
            
            miCliente.Send(miMensaje);
        }

        public CorreoElectronico(string strDireccionServidor, int intPuerto, string strEmailRemitente, string strPassword)
        {
            DireccionServidor = strDireccionServidor;
            Puerto = intPuerto;
            EmailRemitente = strEmailRemitente;
            Password = strPassword;
        }

    }
}
