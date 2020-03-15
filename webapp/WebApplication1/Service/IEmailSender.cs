using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Service
{
    public interface IEmailSender
    {
        Task sendEMailAsync(string email, string subject, string htmlMessage);

        
    }
}
