using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpView

    {
        public PopUpView()
        {
            InitializeComponent();
        }

        public PopUpView(SubirEventModel Item)
        {
            InitializeComponent();
            BindingContext = new EventosViewModel(Item);
        }
    }
}