using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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