using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using dotenv.net;

namespace SendGridLib
{
        interface ISMTP
        {
            string EmailAddress(string ConfEmail);
        }

        public class EmailConf
        {
            public void VerifyEmail(string ConfEmail)
            {
            Execute().Wait();

             async Task Execute()
            {
            DotEnv.Config();
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("troyreeves2@gmail.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("troyreeves2@gmail.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
            }
        }        
    }
