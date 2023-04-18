using Evangzat.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Evangzat.Views
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