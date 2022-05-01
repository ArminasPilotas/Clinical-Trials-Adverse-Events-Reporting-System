using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Utilities
{
    public class Mailer
    {
        private readonly MailAddress fromAddress;
        public MailAddress toAddress;
        private const string fromPassword = "Simplepassword";

        public Mailer()
        {
            this.fromAddress = new MailAddress("ctaers@gmail.com", "CTAERS");
        }
        public void SendEmail(string toEmailAddress, string? toDisplayName, string institutionName, string regNo, string address, string country, string eventType,string adverseEventId, string study, string description)
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
                Subject = "Adverse Event",
                IsBodyHtml = true,
                Body = $@"<html>
                <body>
                <p>This e-mail is designated to:</p>
                <p>{institutionName} (Reg No: {regNo}</p>
                <p>{address}</p>
                <p>{country}</p>

                <p>We would like to inform you about an {eventType} (Case Number: MFR-{adverseEventId})
                that has occurred in the study {study}.</p>

                <p>The event description as follows: {description}</p>

                <p>Please find the detailed report attached to this letter.</p>

                <p>Best regards,</p>               
                <p>CTAERS team</p>

                <p>If this e-mail message is not addressed to you, please delete it immediately, or send a e-mail message to us</p>
                </body>
                </html>"
            })
            {
                smtp.Send(message);
            }

        }

    }
}
