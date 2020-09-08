using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CSR.Core.Views
{
    public class MainScreen : Window
    {
        public MainScreen()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
