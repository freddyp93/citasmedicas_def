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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            if (usuario == "estudiante2023" && contrasena == "uisrael2023")
            {
                await Navigation.PushAsync(new Ingreso());
            }
            else
            {
                //bota la alerta y se limpia el cuadro 
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }

        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Reseteol());
        }

        private async void btnOcontrasena_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reseteol());
        }

        private async void btnRegistroGmail_Clicked(object sender, EventArgs e)
        {
            //llamo a la ventana para registro con gmail
            await Navigation.PushAsync(new Registro_gmail());
        }
    }
}
