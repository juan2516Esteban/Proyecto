using GalaSoft.MvvmLight.Command;
using Proyecto_Final.Model;
using Proyecto_Final.Views;
using Proyecto_Final.Views.PopUp;
using Rg.Plugins.Popup.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace Proyecto_Final.ViewModel
{
    internal class ParticipantesEventViewModel : BaseViewModel
    {
        public ParticipantesEventViewModel()
        {
            loadEvento();
        }

        public ParticipantesEventViewModel(SubirEventModel Item)
        {
            IdValue = Item.Id;
            CodigoTxt = Item.CodigoPersonal;
        }

        #region Atributos
        public object Eventos;
        public int Id;
        public int Codigo;
        public int CodigoEntry;
        #endregion

        #region Propiedades

        public int CodigoEntryTxt
        {
            get { return CodigoEntry; }
            set { SetValue(ref this.CodigoEntry, value); }

        }

        public int IdValue
        {
            get { return Id; }
            set { SetValue(ref this.Id, value); }

        }
        public int CodigoTxt
        {
            get { return Codigo; }
            set { SetValue(ref this.Codigo, value); }
        }
        public object EventosListView
        {
            get { return Eventos; }
            set { SetValue(ref this.Eventos, value); }
        }

        #endregion

        #region Methods
        public async void loadEvento()
        {
            EventosListView = await App.Db.GetTableModel<SubirEventModel>();
        }

        public async void CodigoMethods()
        {
            if (CodigoEntryTxt == CodigoTxt)
            {

                SubirEventModel Item2 = new SubirEventModel();

                Item2.Id = IdValue;
                Item2.CodigoPersonal = CodigoTxt;
               
                await Application.Current.MainPage.DisplayAlert("Correcto", "Ya puedes visualizar los participantes del evento", "Ok");
                await Application.Current.MainPage.Navigation.PushAsync(new ParticipantesEvent2Viewxaml(Item2));
                Volver();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Datos incorrectos", "No puedes visualizar los participantes de este evento", "Ok");
            }
        }

        public async void Volver()
        {
            await PopupNavigation.Instance.PopAsync(true);
        }
     
        #endregion

        #region Comads

        public ICommand CodigoPersonalCommand
        {
            get { return new RelayCommand(CodigoMethods); }
        }

        public ICommand VolverComads
        {
            get { return new RelayCommand(Volver); }
        }

        #endregion
    }

}
