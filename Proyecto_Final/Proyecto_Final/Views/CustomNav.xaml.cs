using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomNav : NavigationPage
    {
        public CustomNav()
        {
            InitializeComponent();
        }

        public CustomNav(Page page) : base(page)
        {
            InitializeComponent();
        }
    }
}