using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

string apiKey = config["Settings:ApiKey"];
int maxAttempts = int.Parse(config["Settings:MaxAttempts"]);

Console.WriteLine($"API Key: {apiKey}");
Console.WriteLine($"MaxAttempts: {maxAttempts}");

