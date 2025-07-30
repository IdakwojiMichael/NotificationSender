using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using NotificationSender.Api.Controllers;
using NotificationSender.Api.Strategies;
using NotificationSender.Api.Interfaces;
using NotificationSender.Api.Models;

namespace NotificationSender.Tests.Controllers
{
    public class NotificationControllerTests
    {
        [Fact]
        public void SendNotification_ReturnsOkResult_WhenCalledWithValidModel()
        {
            // Arrange
            var strategy = new EmailNotificationStrategy();
            var contactServiceMock = new Mock<IContactService>();
            var controller = new NotificationController(strategy, contactServiceMock.Object);

            var notification = new NotificationModel
            {
                Type = "Email",
                Recipient = "john@example.com",
                Message = "Hello, this is a test."
            };

            // Act
            var result = controller.SendNotification(notification);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }
    }
}
