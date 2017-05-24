using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.Services
{
    /// <summary>
    /// Interface used for sending an e-mail. 
    /// Params: toEmail - email of the client; subject -  subject of the email ; message - body of the email
    /// </summary>
    public interface IEmailService
    {
        void SendEmail(string toEmail, string subject, string message);
    }
}
