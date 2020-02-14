using Barcode.Scanner.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Barcode.Scanner.ViewModels
{
    public class ScannerPageViewModel : ViewModelBase, INavigatedAware
    {
        public ScannerPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            scanResultCommand = new DelegateCommand(ScanResultCommandExecute);
        }

        public DelegateCommand scanResultCommand { get; }

        private ZXing.Result _result;
        public ZXing.Result result
        {
            get => _result;
            set
            {
                SetProperty(ref _result, value);
                RaisePropertyChanged(nameof(result));
            }
        }

        public void ScanResultCommandExecute()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Application.Current.MainPage.DisplayAlert("Your Code", result.Text, "OK");
            });
        }
    }
}
