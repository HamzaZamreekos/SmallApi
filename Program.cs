using SmallApi.Builders;
using System.Net;

namespace SmallApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var builder = new EndpointBuilder();
            builder.WithIpAddress(IPAddress.Any);
            builder.WithPort(1099);
            builder.WithController<ExampleController>();
            var app = builder.Build();
            var httpServer = new HttpServer(app);
        }
    }
}
