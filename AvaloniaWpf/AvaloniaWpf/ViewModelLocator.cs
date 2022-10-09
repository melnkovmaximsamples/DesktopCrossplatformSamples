using AvaloniaWpf.ViewModels;

namespace AvaloniaWpf
{
    public class ViewModelLocator
    {
        public static MainWindowViewModel MainWindowViewModel => IoC.Resolve<MainWindowViewModel>();
    }
}