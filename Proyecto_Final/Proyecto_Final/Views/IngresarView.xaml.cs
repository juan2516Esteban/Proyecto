using Proyecto_Final.ViewModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IngresarView : ContentPage
    {
        public IngresarView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new registrate());
        }
    }
}