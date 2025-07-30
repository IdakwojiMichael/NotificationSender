using NotificationSender.Api.Interfaces;
using NotificationSender.Api.Models;
using NotificationSender.Api.Strategies;
using System;
using System.Threading.Tasks;

namespace NotificationSender.Api.Services
{
    public class NotificationContext : INotificationContext
    {
        private INotificationStrategy _strategy;

        public void SetStrategy(string type)
        {
            _strategy = type.ToLower() switch
            {
                "email" => new EmailNotificationStrategy(),
                "sms" => new SmsNotificationStrategy(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }

        public async Task<string> SendAsync(NotificationModel model)
        {
            if (_strategy == null)
                throw new InvalidOperationException("Notification strategy not set");

            return await _strategy.SendAsync(model);
        }
    }
}
