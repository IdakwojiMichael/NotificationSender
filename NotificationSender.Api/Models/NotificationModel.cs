namespace NotificationSender.Api.Models
{
    public class NotificationModel
    {
        public string Type { get; set; }      // "Email", "SMS", etc.
        public string Recipient { get; set; } // Email address or phone number
        public string Message { get; set; }
    }
}
