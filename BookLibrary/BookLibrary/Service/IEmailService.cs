using BookLibrary.Models;
using System.Threading.Tasks;

namespace BookLibrary.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmailOptions);
    }
}