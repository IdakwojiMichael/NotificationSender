using NotificationSender.Api.Models;

namespace NotificationSender.Api.Interfaces
{
    public interface IContactService
    {
        void SaveMessage(ContactModel model);
    }
}
