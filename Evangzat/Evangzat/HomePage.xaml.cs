using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Evangzat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void NotificationsLog_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notifications(), true);

        }
        private async void CartLog_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cart(), true);
        }
        private async void SearchLog_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Search(), true);
        }
        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}