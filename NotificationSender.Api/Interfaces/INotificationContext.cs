using System.Threading.Tasks;
using NotificationSender.Api.Models;

namespace NotificationSender.Api.Interfaces
{
    public interface INotificationContext
    {
        void SetStrategy(string type);
        Task<string> SendAsync(NotificationModel model);
    }
}
