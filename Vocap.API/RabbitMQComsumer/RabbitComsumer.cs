
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using Vocap.API.RabbitMessage;

namespace Vocap.API.RabbitMQComsumer
{
    public class RabbitComsumer : BackgroundService
    {
        private IConnection _connection;
        private IModel _channel;


        public RabbitComsumer()
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: "vocabularyqueue", false, false, false, arguments: null);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (chanel, evt) =>
            {
                var body = evt.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);


                Console.WriteLine($" [x] Received {message}");
            };

            _channel.BasicConsume(queue: "vocabularyqueue",
                     autoAck: false,
                     consumer: consumer);
            return Task.CompletedTask;
        }
    }
}
