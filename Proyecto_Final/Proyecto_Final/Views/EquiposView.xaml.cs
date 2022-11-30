using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EquiposView : ContentPage
    {
        public EquiposView(SubirEventModel Item)
        {
            InitializeComponent();
            BindingContext = new EquiposViewModel(Item);
        }
    }
}