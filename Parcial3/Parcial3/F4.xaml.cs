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
    public partial class F4 : ContentPage
    {
        public F4()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            String scarnet = txtcarnet.Text;
            if ((scarnet == null))
            {

                label.Text = "Rellenar campo";
            }
            else
            {
                await Navigation.PushAsync(new Home());
                await DisplayAlert("Mensaje", "Datos validos", "OK");
            }
        }
    }
}