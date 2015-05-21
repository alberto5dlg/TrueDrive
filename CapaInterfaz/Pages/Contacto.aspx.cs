using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Drawing;

namespace CapaInterfaz.Pages
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_click(object sender, EventArgs e)
        {
            try
            {
                //Email que nos llega a nostros 
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(Nombre.Text + "<" + Email.Text + ">");
                correo.To.Add(new MailAddress("truedrivecars@gmail.com"));
                correo.Subject = Asunto.Text;
                correo.Body = Consulta.Text +
                 "\n ****************************************************************" +
                "\nEmail de Contacto : " + Email.Text +
                "\nMensaje enviado el   " + DateTime.Now.ToString("dd/MM/yyyy") + " a las   " + DateTime.Now.ToString("hh:mm:ss");
                SmtpClient client = new SmtpClient();
                client.Send(correo);
                Final.Text = " Mensaje enviado correctamente";
                Final.ForeColor = Color.Green;

                //Enviamos una copia al cliente que contacte 
                MailMessage correo2 = new MailMessage();
                correo2.From = new MailAddress("TrueDrive" + "<truedrivecars@gmail.com>");
                correo2.To.Add(new MailAddress(Email.Text));
                correo2.Subject = Asunto.Text;
                correo2.Body = "Esto es una copia del mensaje enviado como consulta \n" +
                " ----------------------------------------------------------------\n "
                 + Consulta.Text +
                 "\n ****************************************************************" +
                "\nEmail de Contacto : " + Email.Text +
                "\nMensaje enviado el   " + DateTime.Now.ToString("dd/MM/yyyy") + " a las   " + DateTime.Now.ToString("hh:mm:ss") +
                "\n -----------------------------------------------------------------\n ";
                SmtpClient client2 = new SmtpClient();
                client2.Send(correo2);
                

                Nombre.Text = "";
                Email.Text = "";
                Apellido.Text = "";
                Asunto.Text = "";
                Consulta.Text = "";

            }
            catch (Exception ex)
            {
                Final.Text = "Error al enviar, favor llamenos para resolver las dudas. ";
                Final.ForeColor = Color.Red;
            }
            finally
            {

            }
        }
    }
}