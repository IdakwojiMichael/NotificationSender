using NotificationSender.Api.Interfaces;
using NotificationSender.Api.Models;
using System.Threading.Tasks;

namespace NotificationSender.Api.Strategies
{
    public class SmsNotificationStrategy : INotificationStrategy
    {
        public Task<string> SendAsync(NotificationModel model)
        {
            // TODO: Add actual SMS sending logic here.
            return Task.FromResult($"SMS sent to {model.Recipient}");
        }
    }
}
