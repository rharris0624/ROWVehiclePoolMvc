//using MailKit.Net.Smtp;
//using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using RowVehiclePoolMVC.Settings;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;
using System;

namespace RowVehiclePoolMVC.Services
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var message = new MailMessage(mailRequest.From, mailRequest.To, mailRequest.Subject, mailRequest.Body);

            var client = new SmtpClient(_mailSettings.Host);
            client.UseDefaultCredentials = true;
            try
            {
                string userState = "test Message";
                message.IsBodyHtml= true;
                client.SendAsync(message, userState);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in MailService.SendEmailAsync(): {0}", ex.ToString());
            }
         }
    }
}
