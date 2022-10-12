using ElectronNET.API;

namespace AspNetElectron.HostedServices;

public class ElectronHostedService: IHostedService
{
    public Task StartAsync(CancellationToken _) => Electron.WindowManager.CreateWindowAsync();

    public Task StopAsync(CancellationToken _)
    {
        Electron.App.Quit();

        return Task.CompletedTask;
    }
}