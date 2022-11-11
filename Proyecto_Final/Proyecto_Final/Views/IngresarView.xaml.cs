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
    }
}