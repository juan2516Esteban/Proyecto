using Android.App;
using GalaSoft.MvvmLight.Command;
using Proyecto_Final.Model;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Application = Xamarin.Forms.Application;

namespace Proyecto_Final.ViewModel
{
    internal class ParticipantesEvent2ViewModel : BaseViewModel
    {
        public ParticipantesEvent2ViewModel(SubirEventModel Item) {
            loadEvento(Item);
        }

        public ParticipantesEvent2ViewModel (PartDeporIndiviModel Item)
        {
            NombreUserTxt = Item.NombrePartic;
            EmailUserTxt = Item.EmailPartic;
            EdadUserTxt = Item.EdadPartic;
            CodigoTxt = Item.CodigoEvent;
            TelefonoUserTxt = Item.phonePartic;
            IdValueEvent = Item.Id; 
        }

        public ParticipantesEvent2ViewModel(PartEquiposModel Item)
        {
            NombreUserTxt = Item.NombrePartic;
            EmailUserTxt = Item.EmailSudo;
            EdadUserTxt = Item.EdadSudo;
            CodigoTxt = Item.CodigoEvent;
            TelefonoUserTxt = Item.phoneSudo;
            IdValueEvent = Item.Id;
            Integrante1Txt = Item.Nombrepart1;
            Integrante2Txt = Item.Nombrepart2;
            Integrante3Txt = Item.Nombrepart3;
            Integrante4Txt = Item.Nombrepart4;
            Integrante5Txt = Item.Nombrepart5;
            Integrante6Txt = Item.Nombrepart6;
            Integrante7Txt = Item.Nombrepart7;

        }


        #region Atributos
        public object Eventos;
        public int Id;
        public int Codigo;
        public string NombreUser;
        public string EmailUser;
        public int EdadUser;
        public int CodigoEvent;
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

        public int IdValueEvent
        {
            get { return Id; }
            set { SetValue(ref this.Id, value); }

        }

        public int EdadUserTxt
        {
            get { return EdadUser; }
            set { SetValue(ref this.EdadUser, value); }

        }

        public string TelefonoUserTxt
        {
            get { return TelefonoUser; }
            set { SetValue(ref this.TelefonoUser, value); }
        }
        public int CodigoTxt
        {
            get { return Codigo; }
            set { SetValue(ref this.Codigo, value); }
        }

        public int CodigoEventTxt
        {
            get { return CodigoEvent; }
            set { SetValue(ref this.CodigoEvent, value); }
        }
        public object EventosListView2
        {
            get { return Eventos; }
            set { SetValue(ref this.Eventos, value); }
        }

        #endregion

        #region Methods
        public void loadEvento(SubirEventModel Item)
        {
         
            CodigoEventTxt = Item.CodigoPersonal;

            
            string _queryEvento = "SELECT * FROM PartDeporIndiviModel WHERE CodigoEvent = '" + CodigoEventTxt + "' ";
            string _queryEquipos = "SELECT * FROM PartEquiposModel WHERE CodigoEvent = '" + CodigoEventTxt + "' ";

            List<PartDeporIndiviModel> ListUser = App.Db.QueryModel<PartDeporIndiviModel>(_queryEvento).Result;
            List<PartEquiposModel> ListEquipos = App.Db.QueryModel<PartEquiposModel>(_queryEquipos).Result;

            if (ListUser.Count > 0)
            {
                EventosListView2 = ListUser;

            }else if (ListEquipos.Count>0)
            {
                EventosListView2 = ListEquipos;
            }
        }

        public async void Volver()
        {
            await PopupNavigation.Instance.PopAsync(true);
        }

        #endregion

        #region Comands
        public ICommand VolverComads
        {
            get { return new RelayCommand(Volver); }
        }
        #endregion


    }
}
