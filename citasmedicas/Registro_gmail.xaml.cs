using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace citasmedicas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro_gmail : ContentPage
    {
        public Registro_gmail()
        {
            InitializeComponent();
        }

        private void btnRegistrog_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnRegresarg_Clicked(object sender, EventArgs e)
        {
            //regreso a la ventana de login
            await Navigation.PushAsync(new Login());
        }

        private async void btnRegistrarg_Clicked(object sender, EventArgs e)
        {
            //llamo a la ventana para ingresar el gmail
            await Navigation.PushAsync(new ingreso_gmail());
        }
    }
}