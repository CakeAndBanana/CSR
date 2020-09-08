using System;
using System.Collections.Generic;
using System.Text;

namespace CSR.Core.ViewModels
{
    public class StartupScreenViewModel : ViewModelBase
    {
        public StartupScreenViewModel()
        {
            Greeting = "Welcome to CSR!";
            StartButton = "Click to open CSR!";
        }

        public string Greeting { get; }
        public string StartButton { get; }
    }
}
