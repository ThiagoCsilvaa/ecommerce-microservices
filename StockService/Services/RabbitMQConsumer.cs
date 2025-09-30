using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using StockService.Data;
using Microsoft.Extensions.DependencyInjection;

namespace StockService.Services
{
    public class RabbitMQConsumer
    {
        private readonly IServiceProvider _serviceProvider;
        public RabbitMQConsumer(IServiceProvider serviceProvider) { _serviceProvider = serviceProvider; }

        public void Consume()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare(queue: "stock_queue", durable: false, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine("Mensagem recebida: " + message);
                // Aqui você atualizaria o estoque no banco
            };

            channel.BasicConsume(queue: "stock_queue", autoAck: true, consumer: consumer);
        }
    }
}
