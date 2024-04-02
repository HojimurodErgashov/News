using Contracts.Services;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class EmailRepository : IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "ergashovhojimurod4@gmail.com";
            var pw = "cnzdtmpdvwgiawkt";

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail , pw)
            };

            return client.SendMailAsync(
                new MailMessage(from:mail,
                to:email,
                subject,
                message
                ));
        }
    }
}
