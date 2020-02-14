using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode.Scanner.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            callScannerCommand = new DelegateCommand(async () => await CallScannerCommandExecute());
        }

        public DelegateCommand callScannerCommand { get; }

        public async Task CallScannerCommandExecute()
        {
            await NavigationService.NavigateAsync("ScannerPage");
        }
    }
}
