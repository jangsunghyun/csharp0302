using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace EmailSmtp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var credentials = new NetworkCredential("mokacoffee195@gmail.com", "");
                // Mail message                 
                var mail = new MailMessage()
                {
                    From = new MailAddress("mokacoffee195@gmail.com"),
                    Subject = "Test email.",  Body = "Test email body" };
                mail.To.Add(new MailAddress("mokacoffee195@gmail.com"));
                // Smtp client                 
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network, UseDefaultCredentials = false, Host = "smtp.gmail.com", EnableSsl = true,  Credentials = credentials
                };
                // Send it...                          
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in sending email: " + ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Email sccessfully sent");
            Console.ReadKey();   
        }
    }
}
