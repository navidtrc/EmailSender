using EmailSender.Models;
using System.Threading.Tasks;

namespace EmailSender.Service
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
