namespace Gateway;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddHttpClient("Fusion");

        builder.Services
            .AddFusionGatewayServer()
            .ConfigureFromFile("./gateway.fgp")
            .ModifyFusionOptions(options => options.AllowQueryPlan = true);

        var app = builder.Build();

        app.MapGraphQL();

        app.RunWithGraphQLCommands(args);
    }
}