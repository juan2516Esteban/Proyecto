using GalaSoft.MvvmLight.Command;
using Plugin.LocalNotification;
using Proyecto_Final.Model;
using Proyecto_Final.Views;
using Proyecto_Final.Views.MaestroDetalle;
using Rg.Plugins.Popup.Services;
using System.Windows.Input;
using Application = Xamarin.Forms.Application;


namespace Proyecto_Final.ViewModel
{
    public class ModificarEventoViewModel : BaseViewModel
    {
        public ModificarEventoViewModel()
        {
            loadEvento();
        }
        public ModificarEventoViewModel(SubirEventModel Item)
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
        public int CodigoEntry;
        #endregion

        #region Propiedades

        public int CodigoEntryValue
        {
            get { return CodigoEntry; }
            set { SetValue(ref this.CodigoEntry, value); }

        }
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

        public async void CodigoMethods()
        {
            if (CodigoEntryValue == CodigoTxt)
            {

                SubirEventModel Item2 = new SubirEventModel();

                Item2.Id = IdValue;
                Item2.NombreEvent = NombreEventTxt;
                Item2.MunicipioEvent = MunicipioEventTxt;
                Item2.UbicaciónEvent = LugarEventTxt;
                Item2.DeporteEvent = DeporteEventTxt;
                Item2.NumeroParticiEvent = ParticipantesValue;
                Item2.ValorYTotalEvent = ValorTotalTxt;
                Item2.Descripción = DescripciónTxt;
                Item2.CodigoPersonal = CodigoTxt;
                Item2.ValorAdicionales = GastosAdicTxt;
                Item2.ValorPolizaEvent = PolizaValueTxt;
                Item2.ValorGananciaEvent = GananciaValueTxt;
                Item2.Imagen = imagenValue;

                await Application.Current.MainPage.DisplayAlert("Correcto", "Ya le puedes hacer cambio al evento", "Ok");
                await Application.Current.MainPage.Navigation.PushAsync(new CambiosEventView(Item2));
                await PopupNavigation.Instance.PopAsync(true);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Datos incorrectos", "No puedes hacer cambios al evento, codigo incorrecto", "Ok");
            }
        }

        public async void Volver()
        {
            await PopupNavigation.Instance.PopAsync(true);
        }


        public async void EliminarMethods()
        {
            if (CodigoEntryValue == CodigoTxt)
            {
                var notif = new NotificationRequest();
                notif.Title = "Fanaticos Al Deporte";
                notif.Description = "El evento " + NombreEventTxt + " ha sido eliminado correctamente";
                notif.BadgeNumber = 5;
                notif.NotificationId = 1;

                SubirEventModel evento = new SubirEventModel();

                evento.Id = IdValue;
                evento.NombreEvent = NombreEventTxt;
                evento.MunicipioEvent = MunicipioEventTxt;
                evento.UbicaciónEvent = LugarEventTxt;
                evento.DeporteEvent = DeporteEventTxt;
                evento.NumeroParticiEvent = ParticipantesValue;
                evento.ValorPolizaEvent = PolizaValueTxt;
                evento.ValorGananciaEvent = GananciaValueTxt;
                evento.ValorAdicionales = GastosAdicTxt;
                evento.ValorYTotalEvent = ValorTotalTxt;
                evento.Descripción = DescripciónTxt;
                evento.CodigoPersonal = CodigoTxt;
                evento.Imagen = imagenValue;

                await App.Db.DeleteModelAsync<SubirEventModel>(evento);
                await Application.Current.MainPage.DisplayAlert("Eliminación exitosa", "Tu evento " + NombreEventTxt + " a sido eliminado", "Ok");
                await Application.Current.MainPage.Navigation.PushAsync(new MaestroDetailOrganizador());
                Volver();
                await LocalNotificationCenter.Current.Show(notif);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Datos incorrectos", "No puedes eliminar el evento, codigo incorrecto", "Ok");
            }
        }
        #endregion

        #region Comads
        public ICommand CodigoPersonalCommand
        {
            get { return new RelayCommand(CodigoMethods); }
        }

        public ICommand VolverCommand
        {
            get { return new RelayCommand(Volver); }
        }

        public ICommand EliminarCommand
        {
            get { return new RelayCommand(EliminarMethods); }
        }

        #endregion
    }
}
