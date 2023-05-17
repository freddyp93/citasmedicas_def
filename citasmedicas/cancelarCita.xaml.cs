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
    public partial class cancelarCita : ContentPage
    {
        public cancelarCita()
        {
            InitializeComponent();
        }

        private void Cancelar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Cita cancelada", "Su cita ha sido cancelada", "Cerrar");
            Navigation.PushAsync(new Ingreso());
        }
    }
}