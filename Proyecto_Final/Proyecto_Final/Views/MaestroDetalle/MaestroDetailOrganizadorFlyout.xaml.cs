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

            BindingContext = new MaestroDetailOrganizadorFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class MaestroDetailOrganizadorFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MaestroDetailOrganizadorFlyoutMenuItem> MenuItems { get; set; }

            public MaestroDetailOrganizadorFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MaestroDetailOrganizadorFlyoutMenuItem>(new[]
                {
                    new MaestroDetailOrganizadorFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new MaestroDetailOrganizadorFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new MaestroDetailOrganizadorFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new MaestroDetailOrganizadorFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new MaestroDetailOrganizadorFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}