using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using Proyecto_Final.Views.PopUp;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using Proyecto_Final.Views.PopUp;
using Proyecto_Final.Model;

namespace Proyecto_Final
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new EventosViewModel();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopUpView(e.SelectedItem as SubirEventModel));
        }
    }
}
