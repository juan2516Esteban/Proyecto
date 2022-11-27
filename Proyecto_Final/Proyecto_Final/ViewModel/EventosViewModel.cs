using GalaSoft.MvvmLight.Command;
using Proyecto_Final.Model;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
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
            NombreEventTxt = Item.NombreEvent;
            MunicipioEventTxt = Item.MunicipioEvent;
            LugarEventTxt = Item.UbicaciónEvent;
            DeporteEventTxt = Item.DeporteEvent;
            ParticipantesValue = Item.NumeroParticiEvent;
            ValorTotalTxt = Item.ValorYTotalEvent;
            DescripciónTxt = Item.DeporteEvent;
            CodigoTxt = Item.CodigoPersonal;
            GastosAdicTxt = Item.ValorAdicionales;
            PolizaValueTxt = Item.ValorPolizaEvent;
            GananciaValueTxt = Item.ValorGananciaEvent;
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
        #endregion

        #region Propiedades

        public int ParticipantesValue
        {
            get { return Participantes; }
            set { SetValue(ref this.Participantes, value); }

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

          
                int Incripción = ParticipantesValue-1;

                SubirEventModel evento = new SubirEventModel();

                evento.NombreEvent = NombreEvent;
                evento.MunicipioEvent = Municipio;
                evento.UbicaciónEvent = LugarEvent;
                evento.DeporteEvent = Deporte;
                evento.NumeroParticiEvent = Participantes;
                evento.ValorPolizaEvent = PolizaTxt;
                evento.ValorGananciaEvent = GanaciaTxt;
                evento.ValorAdicionales = GastosAdicionales;
                evento.ValorYTotalEvent = ValorTotal;
                evento.Descripción = Descripción;
                evento.CodigoPersonal = Codigo;
                evento.Imagen = "logopatinaje.jpg"; 

                await App.Db.DeleteModelAsync<SubirEventModel>(evento);
                await Application.Current.MainPage.DisplayAlert("guadado", "solitario", "ok");
                await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
                Volver();
            
        }
        public async void Volver()
        {
            await PopupNavigation.Instance.PopAsync(true);
        }

        #endregion

        #region Comads
        public ICommand VolverComads
        {
            get { return new RelayCommand(Volver); }
        }

        public ICommand InscribirseComads
        {
            get { return new RelayCommand(Inscribirse); }
        }

        #endregion
    }
}
