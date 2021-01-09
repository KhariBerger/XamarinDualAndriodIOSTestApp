using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Plugin.Toast;

namespace Test1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
            Kaboom = new Command(async () => CrossToastPopUp.Current.ShowToastMessage("Kaboom!"));
        }

        public ICommand OpenWebCommand { get; }

        public ICommand Kaboom { get; }

    }
}