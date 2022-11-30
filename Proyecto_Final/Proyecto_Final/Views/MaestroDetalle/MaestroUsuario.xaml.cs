using Proyecto_Final.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views.MaestroDetalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaestroUsuario : FlyoutPage
    {
        public MaestroUsuario()
        {
            InitializeComponent();
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuLateralModel;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new CustomNav(page);
            IsPresented = false;

            FlyoutPage.ListView.SelectedItem = null;
        }
    }
}