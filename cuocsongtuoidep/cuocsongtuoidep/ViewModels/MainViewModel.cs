using cuocsongtuoidep.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Xml.XPath;
using Xamarin.Forms;

namespace cuocsongtuoidep.ViewModels
{
    class MainViewModel
    {
        public ICommand btnNextCommand{ get; set;}
        public INavigation Navigation { get; set; }
        public MainViewModel()
        {
            btnNextCommand = new Command<TiepTheo>;
        }

        private async void TiepTheo(object obj)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
