using GalaSoft.MvvmLight.Command;
using Proyecto_Final.Model;
using Proyecto_Final.Views.MaestroDetalle;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Proyecto_Final.ViewModel
{
    internal class EquiposViewModel : BaseViewModel
    {
        public EquiposViewModel(SubirEventModel Item)
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
        public string Integrante1;
        public string Integrante2;
        public string Integrante3;
        public string Integrante4;
        public string Integrante5;
        public string Integrante6;
        public string Integrante7;
        #endregion

        #region Propiedades

        public string Integrante1Txt
        {
            get { return Integrante1; }
            set { SetValue(ref this.Integrante1, value); }

        }
        public string Integrante2Txt
        {
            get { return Integrante2; }
            set { SetValue(ref this.Integrante2, value); }

        }
        public string Integrante3Txt
        {
            get { return Integrante3; }
            set { SetValue(ref this.Integrante3, value); }

        }

        public string Integrante4Txt
        {
            get { return Integrante4; }
            set { SetValue(ref this.Integrante4, value); }

        }

        public string Integrante5Txt
        {
            get { return Integrante5; }
            set { SetValue(ref this.Integrante5, value); }

        }

        public string Integrante6Txt
        {
            get { return Integrante6; }
            set { SetValue(ref this.Integrante6, value); }
        }

        public string Integrante7Txt
        {
            get { return Integrante7; }
            set { SetValue(ref this.Integrante7, value); }

        }
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
            if (NombreUserTxt == "" || NombreUserTxt is null || EmailUserTxt == "" || EmailUserTxt is null || TelefonoUserTxt == "" || TelefonoUserTxt is null || EdadUserTxt == 0 || 
                Integrante1Txt is null || Integrante1Txt == "" || Integrante2Txt is null || Integrante2Txt == "" || Integrante3Txt is null || Integrante3Txt == "" || Integrante4Txt is null
                || Integrante4Txt == "" || Integrante5Txt is null || Integrante5Txt == "")
            {
                await Application.Current.MainPage.DisplayAlert("Por favor llenar los campos vacios", "Error no se pudo guardar la información", "ok");
            }
            else
            {

                PartEquiposModel Deportista = new PartEquiposModel();

                Deportista.NombrePartic = NombreUserTxt;
                Deportista.EmailSudo = EmailUserTxt;
                Deportista.phoneSudo = TelefonoUserTxt;
                Deportista.EdadSudo = EdadUserTxt;
                Deportista.CodigoEvent = CodigoTxt;
                Deportista.Nombrepart1 = Integrante1Txt;
                Deportista.Nombrepart2 = Integrante2Txt;
                Deportista.Nombrepart3 = Integrante3Txt;
                Deportista.Nombrepart4 = Integrante4Txt;
                Deportista.Nombrepart5 = Integrante5Txt;

                if(Integrante6Txt is null || Integrante6Txt == "" || Integrante7Txt is null || Integrante7Txt == "")
                {
                    Deportista.Nombrepart6 = "Vacio";
                    Deportista.Nombrepart7 = "Vacio";
                }
                else
                {
                    Deportista.Nombrepart6 = Integrante6Txt;
                    Deportista.Nombrepart7 = Integrante7Txt;
                }


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
                await App.Db.SaveModelAsync<PartEquiposModel>(Deportista, true);
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
