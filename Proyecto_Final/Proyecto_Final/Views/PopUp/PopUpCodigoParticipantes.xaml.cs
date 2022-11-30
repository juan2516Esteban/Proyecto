using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
namespace Proyecto_Final.Views.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpCodigoParticipantes 
    {
        public PopUpCodigoParticipantes()
        {
            InitializeComponent();
        }

        public PopUpCodigoParticipantes(SubirEventModel Item)
        {
            InitializeComponent();
            BindingContext = new ParticipantesEventViewModel(Item);
        }
    }
}