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
    public partial class registroPaciente : ContentPage
    {
        public registroPaciente()
        {
            InitializeComponent();
        }

        private void registrarfoto_Clicked(object sender, EventArgs e)
        {

        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ingreso());
        }
    }
}