using DonationApi.Models;

namespace DonationApi.Services
{
    public interface IMailService
    {
        Task SendEmailAsync();
    }
}
