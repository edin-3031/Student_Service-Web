using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebApplication1.Service
{
    public class EMailSender : IEmailSender
    {
        public async Task sendEMailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage()
            {
                From = new MailAddress("itacademy.noreply1@gmail.com", "IT Akademija"),
            };
            message.To.Add(new MailAddress(email, email));
            message.Subject = subject;

            message.Body = htmlMessage;
            message.IsBodyHtml = true;
            message.Priority = MailPriority.High;


            try
            {
                using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
                {

                    client.Credentials = new NetworkCredential("itacademy.noreply1@gmail.com", "Mostar2019");
                    client.EnableSsl = true;
                    await client.SendMailAsync(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Send Mail Failed : " + e.Message);
            }
        }
       
    }
}
