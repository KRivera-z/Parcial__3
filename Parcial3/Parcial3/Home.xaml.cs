using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
           
        }

        private  async void txtf1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private  async void txtf2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new F2());
        }

        private async void txtf3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new F3());
        }

        private async void txtf4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new F4());
        }
    }
}