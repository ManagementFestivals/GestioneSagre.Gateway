namespace GestioneSagre.Gateway;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        //builder.Configuration.AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true);
        builder.Configuration.AddJsonFile("ocelot.json");

        Startup startup = new(builder.Configuration);

        startup.ConfigureServices(builder.Services);

        var app = builder.Build();

        startup.Configure(app);

        app.Run();
    }
}