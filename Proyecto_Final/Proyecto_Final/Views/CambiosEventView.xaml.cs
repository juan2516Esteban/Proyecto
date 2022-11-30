using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CambiosEventView : ContentPage
    {
        public CambiosEventView()
        {
            InitializeComponent();
        }

        public CambiosEventView(SubirEventModel Item)
        {
            InitializeComponent();
            BindingContext = new CambiosEventViewModel(Item, PikerDeporte, PikerMunicipio);
        }

        private void PikerDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            var deporte = PikerDeporte.SelectedIndex;

            if (deporte == 0 || deporte == 2 || deporte == 4 || deporte == 5)
            {
                LabelPartcipantes.Text = "Numero limite de equipos a participar";
            }
            else
            {
                LabelPartcipantes.Text = "Numero limite de participantes";
            }
        }
    }
}