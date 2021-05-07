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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            String snombre = txtnombre.Text;
            String sedad = txtedad.Text;

            if ((snombre == null) && (sedad == null))
            {

                label.Text = "Rellenar campos";
            }
            else
            {
                await Navigation.PushAsync(new F2());
                await DisplayAlert("Mensaje", "Datos validos", "OK");
            }
        }
    }
}

