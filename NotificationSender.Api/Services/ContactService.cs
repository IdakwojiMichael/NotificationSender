using NotificationSender.Api.Interfaces;
using NotificationSender.Api.Models;

namespace NotificationSender.Api.Services
{
    public class ContactService : IContactService
    {
        private readonly List<ContactModel> _messages = new();

        public void SaveMessage(ContactModel model)
        {
            // For now, just storing in memory
            _messages.Add(model);
        }
    }
}
