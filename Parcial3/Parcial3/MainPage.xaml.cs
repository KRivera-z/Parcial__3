using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using Parcial3.Modelos;
using System.Net.Http;
using System.Net;

namespace Parcial3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {

            String semail = txtEmail.Text;
            String spin = txtPin.Text;

            if ((semail== null) && (spin == null))
            {

                label.Text = "Informacion faltante";
            }
            else
            {
                await Navigation.PushAsync(new Home());
                await DisplayAlert("Mensaje", "Datos validos", "OK");
            }

        }
    }
}
