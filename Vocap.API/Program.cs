
using Vocap.API.Extensions;
using Vocap.API.RabbitMQComsumer;
using Vocap.API.RabbitMQSender;

namespace Vocap.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.AppApplicationServices();
            builder.Services.AddSingleton<IRabbitMQMessageSender, RabbitMQSenderVocap>();

            // add consumservice
            builder.Services.AddHostedService<RabbitComsumer>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
