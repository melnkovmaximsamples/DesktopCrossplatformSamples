using ElectronNET.API;
using ElectronNET.API.Entities;

namespace AspNetElectron.HostedServices;

public class ElectronHostedService: IHostedService
{
    public Task StartAsync(CancellationToken _)
    {
        var windowsOptions = new BrowserWindowOptions()
        {
            Width = 920,
            Height = 800
        };
        
        return Electron.WindowManager.CreateWindowAsync(windowsOptions);
    }

    public Task StopAsync(CancellationToken _)
    {
        Electron.App.Quit();

        return Task.CompletedTask;
    }
}