
using GalaSoft.MvvmLight.Command;
using Proyecto_Final.Model;
using System.Windows.Input;
using Xamarin.Forms;
using Proyecto_Final.Views.MaestroDetalle;

namespace Proyecto_Final.ViewModel
{
    public class InscribirseViewModel : BaseViewModel
    {
        public InscribirseViewModel(SubirEventModel Item)
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
        public string NombreUser;
        public string EmailUser;
        public int EdadUser;
        public string TelefonoUser;
        #endregion

        #region Propiedades

        public string NombreUserTxt
        {
            get { return NombreUser; }
            set { SetValue(ref this.NombreUser, value); }

        }

        public string EmailUserTxt
        {
            get { return EmailUser; }
            set { SetValue(ref this.EmailUser, value); }

        }

        public string TelefonoUserTxt
        {
            get { return TelefonoUser; }
            set { SetValue(ref this.TelefonoUser, value); }

        }

        public int EdadUserTxt
        {
            get { return EdadUser; }
            set { SetValue(ref this.EdadUser, value); }

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

        public async void Inscribirse()
        {
            if (NombreUserTxt == "" || NombreUserTxt is null || EmailUserTxt == "" || EmailUserTxt is null || TelefonoUserTxt == "" || TelefonoUserTxt is null || EdadUserTxt == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Por favor llenar los campos vacios", "Error no se pudo guardar la información", "ok");
            }
            else
            {

                PartDeporIndiviModel Deportista = new PartDeporIndiviModel();

                Deportista.NombrePartic = NombreUserTxt;
                Deportista.EmailPartic = EmailUserTxt;
                Deportista.phonePartic = TelefonoUserTxt;
                Deportista.EdadPartic = EdadUserTxt;
                Deportista.CodigoEvent = CodigoTxt;

                ParticipantesValue -= 1;

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

                await App.Db.SaveModelAsync<SubirEventModel>(userUpdate, false);
                await App.Db.SaveModelAsync<PartDeporIndiviModel>(Deportista, true);
                await Application.Current.MainPage.DisplayAlert("Tu inscripción a sido exitosa", "Ya estas participando en el evento " + NombreEventTxt + " te esperamos", "ok");
                await Application.Current.MainPage.Navigation.PushAsync(new MaestroUsuario());

            }
        }

        #endregion

        #region Comands

        public ICommand InscribirseCommand
        {
            get { return new RelayCommand(Inscribirse); }
        }

        #endregion
    }
}
