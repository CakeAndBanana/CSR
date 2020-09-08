using System;
using System.Collections.Generic;
using System.Text;

namespace CSR.Core.ViewModels
{
    public class MainScreenViewModel : ViewModelBase
    {
        public MainScreenViewModel()
        {
            Startup = new StartupScreenViewModel();
        }

        public StartupScreenViewModel Startup { get; }
    }
}
