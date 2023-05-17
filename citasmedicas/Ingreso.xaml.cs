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
    public partial class Ingreso : ContentPage
    {

              public Ingreso()
        {
            InitializeComponent();
        }
        private void btnregistrarpaciente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new registroPaciente());
        }


        private void btnsolicitarcita_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new solicitarCita());
        }

        private void btncancelarcita_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new cancelarCita());
        }

        
    }
}