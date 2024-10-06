using System.Threading.Tasks;

namespace OrdemDeServico.Services; 
public interface IEmailSender {
    Task SendEmailAsync(string to, string subject, string htmlMessage);
}
