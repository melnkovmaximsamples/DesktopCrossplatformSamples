using System;
using AvaloniaWpf.Data;
using AvaloniaWpf.Repositories;
using AvaloniaWpf.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaWpf;

public static class IoC
{
    private static readonly IServiceProvider _provider;
    
    static IoC()
    {
        var services = new ServiceCollection();

        services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("InMemory"));
        services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        services.AddSingleton<ApplicationDbContext>();
        services.AddSingleton<MainWindowViewModel>();

        _provider = services.BuildServiceProvider();
    }

    public static T Resolve<T>() where T: notnull => _provider.GetRequiredService<T>();
}