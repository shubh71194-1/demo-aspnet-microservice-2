using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("ocelot.json");
            builder.Services.AddOcelot();
            var app = builder.Build();

            app.UseOcelot().Wait();
            app.MapControllers();

            app.Run();
        }
    }
}