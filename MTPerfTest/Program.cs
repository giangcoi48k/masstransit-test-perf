using MassTransit;
using MTPerfTest.BackgroundServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<StockseriesProducer>();
builder.Services.AddMassTransit(cfg =>
{
    cfg.SetKebabCaseEndpointNameFormatter();
    cfg.UsingRabbitMq((ctx, config) =>
    {
        config.Host("localhost", 5672, "/", h =>
        {
            h.Username("user");
            h.Password("password");
        });
        config.ConfigureEndpoints(ctx);
    });

    cfg.AddConsumers(typeof(Program).Assembly);
});
var app = builder.Build();

app.Run();
