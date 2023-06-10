using cuocsongtuoidep.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cuocsongtuoidep
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            var vn = (MainViewModel)BindingContext;
            if (vn != null)
            {
                vn.Navigation = Navigation;
            }
        }

    }
}