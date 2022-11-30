using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using Proyecto_Final.Views.PopUp;
using Rg.Plugins.Popup.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModificarEventoView : ContentPage
    {
        public ModificarEventoView()
        {
            InitializeComponent();
            BindingContext = new ModificarEventoViewModel();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopUpModificar(e.SelectedItem as SubirEventModel));
        }
    }
}