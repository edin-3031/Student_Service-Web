using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApplication1.Service
{
    public class EMailSender : IEmailSender
    {
        public Task sendEMailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("ITAcademy", "itacademynoreply@gmail.com"));
            message.To.Add(new MailboxAddress(email, email));
            message.Subject = subject;

            var builder = new BodyBuilder();

            builder.HtmlBody = htmlMessage;

            // builder.Attachments.Add(@"C:\file\data.xlxs");

            message.Body = builder.ToMessageBody();

            try
            {
                var client = new SmtpClient();

                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("itacademynoreply@gmail.com", "Mostar2019");
                client.Send(message);
                client.Disconnect(true);

                Console.WriteLine("Send Mail Success.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Send Mail Failed : " + e.Message);
            }
            return Task.CompletedTask;
        }
    }
}
