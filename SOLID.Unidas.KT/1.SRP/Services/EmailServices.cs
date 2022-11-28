using System.Net.Mail;

namespace _1.SRP
{
    public class EmailServices
    {
        public void Enviar(string emailCliente)
        {
            var mail = new MailMessage("empresa@empresa.com", emailCliente);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem Vindo.";
            mail.Body = "Parabéns! Você está cadastrado.";
            client.Send(mail);
        }
    }
}