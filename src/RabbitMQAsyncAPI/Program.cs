using RabbitMQAsyncAPI.Configurations;
using RabbitMQAsyncAPI.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddRabbitMq(builder.Configuration);
builder.Services.AddSwaggerDocumentation();

// Build the app
var app = builder.Build();

// Use Swagger
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Weather API v1"));

// Map endpoints
app.MapWeatherEndpoints();

// Run
app.Run();