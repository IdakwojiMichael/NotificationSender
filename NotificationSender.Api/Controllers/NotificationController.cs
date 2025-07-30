using Microsoft.AspNetCore.Mvc;
using NotificationSender.Api.Models;
using NotificationSender.Api.Strategies;
using NotificationSender.Api.Services;
using NotificationSender.Api.Interfaces;

namespace NotificationSender.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationStrategy _notificationStrategy;
        private readonly IContactService _contactService;

        public NotificationController(INotificationStrategy notificationStrategy, IContactService contactService)
        {
            _notificationStrategy = notificationStrategy;
            _contactService = contactService;
        }

        [HttpPost("send")]
        public IActionResult SendNotification([FromBody] NotificationModel model)
        {
            _notificationStrategy.SendAsync(model);
            return Ok(new { message = "Notification sent successfully." });
        }

        [HttpPost("contact")]
        public IActionResult ContactUs([FromBody] ContactModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name) || string.IsNullOrWhiteSpace(model.Message))
                return BadRequest(new { message = "Name and message are required." });

            _contactService.SaveMessage(model);
            return Ok(new { message = "Your message has been received. Thank you!" });
        }
    }
}