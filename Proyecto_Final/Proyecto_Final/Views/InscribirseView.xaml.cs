using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InscribirseView : ContentPage
    {
        public InscribirseView(SubirEventModel Item)
        {
            InitializeComponent();
            BindingContext = new InscribirseViewModel(Item);
        }
    }
}