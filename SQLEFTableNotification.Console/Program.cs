
using Microsoft.Extensions.DependencyInjection;
using SQLEFTableNotification.Console.Services;
using SQLEFTableNotification.Interfaces;

public class MainProgram
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    //[STAThread]
    public static void Main()
    {
        var serviceProvider = new ServiceCollection()
                 .AddScoped(typeof(IChangeTableService<>), typeof(ChangeTableService<,>))
                 .AddScoped<ISQLTableMonitorManager, SQLTableMonitorManager>()
        .BuildServiceProvider();

        ISQLTableMonitorManager tableMonitorManager = serviceProvider.GetRequiredService<ISQLTableMonitorManager>();
        Task.Run(async () => await tableMonitorManager.Invoke()).Wait();
    }


}