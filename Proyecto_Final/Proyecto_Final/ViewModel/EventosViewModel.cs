using GalaSoft.MvvmLight.Command;
using Proyecto_Final.Model;
using Proyecto_Final.Views;
using Rg.Plugins.Popup.Services;
using System.Windows.Input;
using Xamarin.Forms;


namespace Proyecto_Final.ViewModel
{
    public class EventosViewModel : BaseViewModel
    {

        public EventosViewModel()
        {
            loadEvento();
        }
        public EventosViewModel(SubirEventModel Item)
        {
            IdValue = Item.Id;
            NombreEventTxt = Item.NombreEvent;
            MunicipioEventTxt = Item.MunicipioEvent;
            LugarEventTxt = Item.UbicaciónEvent;
            DeporteEventTxt = Item.DeporteEvent;
            ParticipantesValue = Item.NumeroParticiEvent;
            ValorTotalTxt = Item.ValorYTotalEvent;
            DescripciónTxt = Item.Descripción;
            CodigoTxt = Item.CodigoPersonal;
            GastosAdicTxt = Item.ValorAdicionales;
            PolizaValueTxt = Item.ValorPolizaEvent;
            GananciaValueTxt = Item.ValorGananciaEvent;
            imagenValue = Item.Imagen;
        }

        #region Atributos
        public object Eventos;
        public int Participantes;
        public string Descripción;
        public int ValorTotal;
        public int Codigo;
        public string GastosAdicionales;
        public string NombreEvent;
        public string LugarEvent;
        public string Municipio;
        public string Deporte;
        public string PolizaTxt;
        public string GanaciaTxt;
        public string imagenEvent;
        public int Id;
        #endregion

        #region Propiedades

        public int ParticipantesValue
        {
            get { return Participantes; }
            set { SetValue(ref this.Participantes, value); }

        }

        public int IdValue
        {
            get { return Id; }
            set { SetValue(ref this.Id, value); }

        }
        public string DescripciónTxt
        {
            get { return Descripción; }
            set { SetValue(ref this.Descripción, value); }
        }
        public int ValorTotalTxt
        {
            get { return ValorTotal; }
            set { SetValue(ref this.ValorTotal, value); }
        }

        public int CodigoTxt
        {
            get { return Codigo; }
            set { SetValue(ref this.Codigo, value); }
        }

        public string GastosAdicTxt
        {
            get { return GastosAdicionales; }
            set { SetValue(ref this.GastosAdicionales, value); }
        }

        public string NombreEventTxt
        {
            get { return NombreEvent; }
            set { SetValue(ref this.NombreEvent, value); }
        }
        public string imagenValue
        {
            get { return imagenEvent; }
            set { SetValue(ref this.imagenEvent, value); }

        }
        public string LugarEventTxt
        {
            get { return LugarEvent; }
            set { SetValue(ref this.LugarEvent, value); }
        }

        public string MunicipioEventTxt
        {
            get { return Municipio; }
            set { SetValue(ref this.Municipio, value); }
        }

        public string DeporteEventTxt
        {
            get { return Deporte; }
            set { SetValue(ref this.Deporte, value); }
        }


        public object EventosListView
        {
            get { return Eventos; }
            set { SetValue(ref this.Eventos, value); }
        }

        public string PolizaValueTxt
        {
            get { return PolizaTxt; }
            set { SetValue(ref this.PolizaTxt, value); }

        }

        public string GananciaValueTxt
        {
            get { return GanaciaTxt; }
            set { SetValue(ref this.GanaciaTxt, value); }
        }

        #endregion

        #region Methods
        public async void loadEvento()
        {
            EventosListView = await App.Db.GetTableModel<SubirEventModel>();
        }


        public async void Inscribirse()
        {
            if (ParticipantesValue > 0)
            {

                if (DeporteEventTxt == "Baloncesto" || DeporteEventTxt == "Futbol" || DeporteEventTxt == "Ultimate" || DeporteEventTxt == "Voleyball")
                {


                    SubirEventModel userUpdate = new SubirEventModel();

                    userUpdate.Id = Id;
                    userUpdate.NombreEvent = NombreEvent;
                    userUpdate.MunicipioEvent = Municipio;
                    userUpdate.UbicaciónEvent = LugarEvent;
                    userUpdate.DeporteEvent = Deporte;
                    userUpdate.NumeroParticiEvent = Participantes;
                    userUpdate.ValorPolizaEvent = PolizaTxt;
                    userUpdate.ValorGananciaEvent = GanaciaTxt;
                    userUpdate.ValorAdicionales = GastosAdicionales;
                    userUpdate.ValorYTotalEvent = ValorTotal;
                    userUpdate.Descripción = Descripción;
                    userUpdate.CodigoPersonal = Codigo;
                    userUpdate.Imagen = imagenEvent;



                    await Application.Current.MainPage.DisplayAlert("Ya estas a un paso de inscribirte", "A continuación regalanos unos datos para finalizar la inscripción", "ok");
                    Volver2();
                    await Application.Current.MainPage.Navigation.PushAsync(new EquiposView(userUpdate));
                }
                else
                {

                    SubirEventModel userUpdate = new SubirEventModel();


                    userUpdate.Id = Id;
                    userUpdate.NombreEvent = NombreEvent;
                    userUpdate.MunicipioEvent = Municipio;
                    userUpdate.UbicaciónEvent = LugarEvent;
                    userUpdate.DeporteEvent = Deporte;
                    userUpdate.NumeroParticiEvent = Participantes;
                    userUpdate.ValorPolizaEvent = PolizaTxt;
                    userUpdate.ValorGananciaEvent = GanaciaTxt;
                    userUpdate.ValorAdicionales = GastosAdicionales;
                    userUpdate.ValorYTotalEvent = ValorTotal;
                    userUpdate.Descripción = Descripción;
                    userUpdate.CodigoPersonal = Codigo;
                    userUpdate.Imagen = imagenEvent;

                    await Application.Current.MainPage.DisplayAlert("Ya estas a un paso de inscribirte", "A continuación regalanos unos datos para finalizar la inscripción", "ok");
                    Volver2();
                    await Application.Current.MainPage.Navigation.PushAsync(new InscribirseView(userUpdate));
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Inscripciones cerradas", "la el limite de inscripciones fue superado, buena suerte para la proxima vez", "ok");
            }
        }

        public async void Volver2()
        {
            await PopupNavigation.Instance.PopAsync(true);
        }
        #endregion

        #region Comads
        public ICommand VolverComads
        {
            get { return new RelayCommand(Volver2); }
        }

        public ICommand InscribirseComads
        {
            get { return new RelayCommand(Inscribirse); }
        }

        #endregion

    }
}
