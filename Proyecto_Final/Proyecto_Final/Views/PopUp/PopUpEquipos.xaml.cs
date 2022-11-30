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
    public partial class PopUpEquipos 
    {
        public PopUpEquipos(PartEquiposModel Item)
        {
            InitializeComponent();
            BindingContext = new ParticipantesEvent2ViewModel(Item);
        }
    }
}