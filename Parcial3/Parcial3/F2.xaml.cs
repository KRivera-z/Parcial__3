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
    public partial class F2 : ContentPage
    {
        public F2()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            String snumero = txtnumero.Text;
           

            if ((snumero == null))
            {

                label.Text = "Rellenar campo";
            }
            else
            {
                await Navigation.PushAsync(new F3());
                await DisplayAlert("Mensaje", "Datos validos", "OK");
            }
        }
    }
}