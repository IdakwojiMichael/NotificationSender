using NotificationSender.Api.Interfaces;
using NotificationSender.Api.Models;
using System.Threading.Tasks;

namespace NotificationSender.Api.Strategies
{
    public class EmailNotificationStrategy : INotificationStrategy
    {
        public Task<string> SendAsync(NotificationModel model)
        {
            // TODO: Add actual email sending logic here.
            return Task.FromResult($"Email sent to {model.Recipient}");
        }
    }
}
