using cuocsongtuoidep.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace cuocsongtuoidep.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}