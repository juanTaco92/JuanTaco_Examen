using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JuanTaco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String usuario, string password)
        {
            InitializeComponent();
            lblUser.Text = usuario;
            lblPass.Text = password;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            {
                try
                {
                    Decimal cuotaInicial = Decimal.Parse(txtCuotaInicial.Text);
                    if (cuotaInicial <= 3000)
                    {
                        string nombres = txtNombres.Text;
                        double cuotaInicial1 = Convert.ToDouble(txtCuotaInicial.Text);                        
                        double datoSubCuota = (3000 - cuotaInicial1);
                        double datoInteres = (3000 * 0.5);
                        double datoTotCuota = (datoSubCuota+datoInteres)/5 ;
                        txtResultado.Text = datoTotCuota.ToString();
                        

                    }
                    else
                    {
                        DisplayAlert("Error", "Cuota Inicial Mayor a $3000", "Cerrar");
                    }

                    }
                catch (Exception ex)
                {
                    DisplayAlert("ERROR", ex.Message, "Cerrar");
                }
            }
    }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            double cuotaInicial = Convert.ToDouble(txtCuotaInicial.Text);
            string nombres = txtNombres.Text;
            double datoResultadoTotal = (3000 - cuotaInicial) + (3000 * 0.5);
            String datoResultadoTotal1 = Convert.ToString(cuotaInicial);
            double datoSubCuota = (3000 - cuotaInicial);
            double datoInteres = (3000 * 0.5);
            double datoTotPagar = (datoSubCuota + datoInteres)
            double datoTotCuota = (datoSubCuota + datoInteres) / 5;
            
            DisplayAlert("Mensaje", "Dato Ingresado Correctamente", "Cerrar");
            string user = lblUser.Text;
            string pass = lblPass.Text;
            await Navigation.PushAsync(new Resumen(nombres, datoTotPagar,user,pass));
        }
    }
}