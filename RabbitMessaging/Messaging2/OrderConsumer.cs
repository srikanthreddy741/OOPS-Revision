using MassTransit;
using Messaging2.Model;
using System.Threading.Tasks;

namespace Messaging2
{
    public class OrderConsumer :
       IConsumer<Order>
    {
        public async Task Consume(ConsumeContext<Order> context)
        {
            var data = context.Message;
            // message received.
        }
    }
}
