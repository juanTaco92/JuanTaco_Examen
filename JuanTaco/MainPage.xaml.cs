using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JuanTaco
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnNotas_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje", "Bienvenido al sistema", "Cerrar");
            await Navigation.PushAsync (new Login());
        }
    }
}
