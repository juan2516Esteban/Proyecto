using Proyecto_Final.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views.MaestroDetalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaestroDetailOrganizadorFlyout : ContentPage
    {
        public ListView ListView;

        public MaestroDetailOrganizadorFlyout()
        {
            InitializeComponent();

            BindingContext = new MaestroDetailOrganizadorViewModel();
            ListView = MenuItemsListView;
        }
    }
}