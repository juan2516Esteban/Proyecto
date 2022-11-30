using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using Proyecto_Final.Views.PopUp;
using Rg.Plugins.Popup.Events;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParticipantesEvent2Viewxaml : ContentPage
    {
        public ParticipantesEvent2Viewxaml(SubirEventModel Item)
        {
            InitializeComponent();
            BindingContext = new ParticipantesEvent2ViewModel(Item);
            
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                await PopupNavigation.Instance.PushAsync(new PopUpParticipantes(e.SelectedItem as PartDeporIndiviModel));
            } catch (Exception ex)
            {
                await PopupNavigation.Instance.PushAsync(new PopUpEquipos(e.SelectedItem as PartEquiposModel));
            }
        }
    }
}