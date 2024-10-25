using System.Net.Mail;
using System.Net;
using Medicio.DAL.Models;

namespace Medicio.PL.Helpers
{
    public class EmailSettings
    {
        public static void SendEmail(Email email)
        {
           var client=new SmtpClient("smtp.gmail.com",587);
               client.EnableSsl = true;
            client.Credentials = new NetworkCredential("sohaibshaltafaltrefe@gmail.com", "gjua yewi htol zifj");
            client.Send("sohaibshaltafaltrefe@gmail.com",email.Recivers,email.Subject,email.Body);

        }
    }
}
