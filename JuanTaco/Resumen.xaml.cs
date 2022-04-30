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
    public partial class Resumen : ContentPage
    {
        public Resumen(String usuario, string password)
        {
            InitializeComponent();
            lblUser.Text = usuario;
            lblPass.Text = password;
        }
    }
}