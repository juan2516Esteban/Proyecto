using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpModificar
    {
        public PopUpModificar()
        {
            InitializeComponent();
        }

        public PopUpModificar(SubirEventModel Item)
        {
            InitializeComponent();
            BindingContext = new ModificarEventoViewModel(Item);
        }
    }
}