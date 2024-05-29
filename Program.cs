using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddJsonFile("app-settings.json")
    .AddEnvironmentVariables()
    .Build();
Settings? settings = config.GetRequiredSection("Settings").Get<Settings>();
var message = settings?.Message;

Console.WriteLine(""+message);
