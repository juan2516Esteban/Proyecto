using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using Proyecto_Final.Views.PopUp;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParticipantesEventView : ContentPage
    {
        public ParticipantesEventView()
        {
            InitializeComponent();
            BindingContext = new ParticipantesEventViewModel();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopUpCodigoParticipantes(e.SelectedItem as SubirEventModel));
        }
    }
}