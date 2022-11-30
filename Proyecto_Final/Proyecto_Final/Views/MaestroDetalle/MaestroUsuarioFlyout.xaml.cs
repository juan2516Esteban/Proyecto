using Proyecto_Final.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views.MaestroDetalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaestroUsuarioFlyout : ContentPage
    {
        public ListView ListView;

        public MaestroUsuarioFlyout()
        {
            InitializeComponent();

            BindingContext = new MestroDetailUsuarioViewModel();
            ListView = MenuItemsListView;
        }

    }
}