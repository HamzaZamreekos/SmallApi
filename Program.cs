using SmallApi.Builders;
using System.Net;

namespace SmallApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var endpointBuilder = new EndpointBuilder();
            endpointBuilder.WithIpAddress(IPAddress.Any);
            endpointBuilder.WithPort(1099);
            endpointBuilder.WithController<ExampleController>();
            var httpServer = new HttpServer();
        }
    }
}
