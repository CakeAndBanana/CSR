using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using CSR.Core.ViewModels;
using CSR.Core.Views;

namespace CSR.Core
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainScreen
                {
                    DataContext = new MainScreenViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
