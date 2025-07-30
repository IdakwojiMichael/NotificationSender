using NotificationSender.Api.Interfaces;
using NotificationSender.Api.Services;
using NotificationSender.Api.Strategies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

// Register your services and strategy
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<INotificationContext, NotificationContext>();
builder.Services.AddScoped<INotificationStrategy, EmailNotificationStrategy>(); // ✅ This line fixes the error

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
