using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Utilities
{
    public class Mailer
    {
        private readonly MailAddress fromAddress;
        public MailAddress toAddress;
        private const string fromPassword = "************";

        public Mailer()
        {
            this.fromAddress = new MailAddress("**********", "************");
        }
        public void SendEmail(string toEmailAddress, string? toDisplayName, string subject, string body)
        {
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, new MailAddress(toEmailAddress, toDisplayName))
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

        }

    }
}
