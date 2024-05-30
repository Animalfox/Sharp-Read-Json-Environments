using Microsoft.Extensions.Configuration;
using Read_Json_Environments;

var config = new ConfigurationBuilder()
    .AddJsonFile("app-settings.json")
    .AddEnvironmentVariables()
    .Build();
var settings = config.GetRequiredSection("Settings").Get<Settings>();
var message = settings?.Message;

Console.WriteLine(""+message);
