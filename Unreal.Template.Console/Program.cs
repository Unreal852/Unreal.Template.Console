using Serilog;

namespace Unreal.Template.Console;

internal static class Program
{
    private static void Main(string[] args)
    {
        ConfigureLogger();

        Log.Information("Hello world, the current date is {Date}", DateTime.Now);
    }

    private static void ConfigureLogger()
    {
        Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
    }
}
