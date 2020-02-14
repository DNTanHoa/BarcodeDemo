using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace Barcode.Scanner.Views
{
    public partial class MainPage : ContentPage
    {
        INavigationService _navigationService;

        public MainPage(INavigationService service)
        {
            InitializeComponent();
            _navigationService = service;
        }
    }
}