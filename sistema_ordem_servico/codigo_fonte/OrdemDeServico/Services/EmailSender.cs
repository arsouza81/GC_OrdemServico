using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace OrdemDeServico.Services {
    public class EmailSender : IEmailSender {
        private readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration) {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string to, string subject, string htmlMessage) {
            var smtpSettings = _configuration.GetSection("Smtp");
            var smtpClient = new SmtpClient(smtpSettings["Host"]) {
                Port = int.Parse(smtpSettings["Port"]),
                Credentials = new NetworkCredential(smtpSettings["Username"], smtpSettings["Password"]),
                EnableSsl = true
            };

            var mailMessage = new MailMessage {
                From = new MailAddress(smtpSettings["From"]),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            mailMessage.To.Add(to);

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
