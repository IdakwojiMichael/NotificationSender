using NotificationSender.Api.Models;
using System.Threading.Tasks;

namespace NotificationSender.Api.Interfaces
{
    public interface INotificationStrategy
    {
        Task<string> SendAsync(NotificationModel model);
    }
}
