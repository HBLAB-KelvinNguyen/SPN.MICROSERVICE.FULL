using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Abstractions
{
    public class RBMQBaseComsumer : BackgroundService
    {

        private IConnection _connection;
        protected RabbitMQ.Client.IModel _channel;

        public RBMQBaseComsumer(string queuename, string hostname )
        {
            
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }
    }
}
