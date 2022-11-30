using GalaSoft.MvvmLight.Command;
using Plugin.LocalNotification;
using Proyecto_Final.Model;
using Proyecto_Final.Views.MaestroDetalle;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Proyecto_Final.ViewModel
{
    public class CambiosEventViewModel : BaseViewModel
    {
        public CambiosEventViewModel() { }
        public CambiosEventViewModel(SubirEventModel Item, Picker picker, Picker municipio)
        {
            int valorpoliza = Int32.Parse(Item.ValorPolizaEvent) / 1000;
            int Valorgastosadic = Int32.Parse(Item.ValorAdicionales) / 1000;
            int valorganacia = Int32.Parse(Item.ValorGananciaEvent) / 1000;


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
            PolizaValue = valorpoliza;
            GatosAdicValue = Valorgastosadic;
            GanaciaValue = valorganacia;
            GananciaValueTxt = Item.ValorGananciaEvent;
            imagenValue = Item.Imagen;


            List<DeportesModel> deportesModels = new List<DeportesModel>();
            deportesModels.Add(new DeportesModel { Nombre = "Baloncesto" });
            deportesModels.Add(new DeportesModel { Nombre = "Patinaje" });
            deportesModels.Add(new DeportesModel { Nombre = "Futbol" });
            deportesModels.Add(new DeportesModel { Nombre = "Natación" });
            deportesModels.Add(new DeportesModel { Nombre = "Ultimate" });
            deportesModels.Add(new DeportesModel { Nombre = "Voleyball" });
            deportesModels.Add(new DeportesModel { Nombre = "Ciclismo de montaña" });
            deportesModels.Add(new DeportesModel { Nombre = "Golf" });

            foreach (var nombre in deportesModels)
            {
                picker.Items.Add(nombre.Nombre);
            }

            List<MunicipiosModel> municipiosmodels = new List<MunicipiosModel>();
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Mistrato" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Pueblo Rico" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Quinchia" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Guática" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Belén de umbria" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Apia" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Santuario" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "La Celia" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Balboa" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "La virginia" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Marsella" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Pereira" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Dosquebradas" });
            municipiosmodels.Add(new MunicipiosModel { Nombre = "Santa Rosa de Cabal" });

            foreach (var nombre in municipiosmodels)
            {
                municipio.Items.Add(nombre.Nombre);
            }

        }

        #region Atributos
        public string NombreEvent;
        public string LugarEvent;
        public string Municipio;
        public string Deporte;
        public int Participantes;
        public int Poliza;
        public int Ganancia;
        public int GastosAd;
        public string PolizaTxt;
        public string GanaciaTxt;
        public string GastosAdicionales;
        public int ValorTotal;
        public string Descripción;
        public int Codigo;
        public int id;
        public string imagen;
        #endregion

        #region Propiedades
        public string DescripciónTxt
        {
            get { return Descripción; }
            set { SetValue(ref this.Descripción, value); }
        }

        public string imagenValue
        {
            get { return imagen; }
            set { SetValue(ref this.imagen, value); }
        }

        public int IdValue
        {
            get { return id; }
            set { SetValue(ref this.id, value); }
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

        public int GatosAdicValue
        {
            get { return GastosAd; }
            set
            {
                SetValue(ref this.GastosAd, value);
                int GananciaAd2 = GastosAd * 1000;
                SumaTotal();
                GastosAdicTxt = GananciaAd2.ToString();
            }

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

        public int ParticipantesValue
        {
            get { return Participantes; }
            set { SetValue(ref this.Participantes, value); }

        }

        public int PolizaValue
        {
            get { return Poliza; }
            set
            {
                SetValue(ref this.Poliza, value);
                int poliza2 = Poliza * 1000;
                SumaTotal();
                PolizaValueTxt = poliza2.ToString();
            }

        }

        public int GanaciaValue
        {
            get { return Ganancia; }
            set
            {
                SetValue(ref this.Ganancia, value);
                int ganancia2 = Ganancia * 1000;
                SumaTotal();
                GananciaValueTxt = ganancia2.ToString();
            }

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

        public void SumaTotal()
        {
            int Valor2 = (GatosAdicValue * 1000) + (PolizaValue * 1000) + (GanaciaValue * 1000);
            ValorTotalTxt = Valor2;
        }

        public async void CambiosEventMethods()
        {

            var notif = new NotificationRequest();
            notif.Title = "Fanaticos Al Deporte";
            notif.Description = "Tu evento " + NombreEventTxt + " a sido modificado exitosamente, Recuerda tu codigo personal es: " + CodigoTxt;
            notif.BadgeNumber = 5;
            notif.NotificationId = 1;

            SubirEventModel evento = new SubirEventModel();

            evento.Id = id;
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

            #region ValiadciónDeImagen

            if (DeporteEventTxt == "Baloncesto")
            {
                evento.Imagen = "iconBas.png";

            }
            else if (DeporteEventTxt == "Patinaje")
            {
                evento.Imagen = "logopatinaje.jpg";
            }
            else if (DeporteEventTxt == "Futbol")
            {
                evento.Imagen = "futbol.png";
            }
            else if (DeporteEventTxt == "Natación")
            {
                evento.Imagen = "natacion.png";
            }
            else if (DeporteEventTxt == "Ultimate")
            {
                evento.Imagen = "frisbee.jpg";
            }
            else if (DeporteEventTxt == "Voleyball")
            {
                evento.Imagen = "Voleyball.png";
            }
            else if (DeporteEventTxt == "Ciclismo de montaña")
            {
                evento.Imagen = "Ciclismo.jpg";
            }
            else if (DeporteEventTxt == "Golf")
            {
                evento.Imagen = "golf.png";
            }
            #endregion

            if (NombreEventTxt is null || NombreEventTxt == "" || MunicipioEventTxt is null || LugarEventTxt is null || LugarEventTxt == "" || DeporteEventTxt is null || ParticipantesValue == 0 || ValorTotalTxt == 0 || DescripciónTxt is null || DescripciónTxt == "")
            {
                await Application.Current.MainPage.DisplayAlert("Por favor llenar los campos vacios", "Error no se pudo modificar la información", "ok");
            }
            else
            {
                await App.Db.SaveModelAsync<SubirEventModel>(evento, false);
                await Application.Current.MainPage.DisplayAlert("Datos guardados correctamente", "el evento " + NombreEventTxt + " ha sido Modificado correctamente en este momento puedes ver como se visualiza, " +
                    "te recordamos que tu codigo para volver hacer cualquier cambio es: " + CodigoTxt + ".", "Ok");
                await Application.Current.MainPage.Navigation.PushAsync(new MaestroDetailOrganizador());
                await LocalNotificationCenter.Current.Show(notif);
            }

        }
        #endregion

        #region Comands 

        public ICommand CambiosEventComads
        {
            get { return new RelayCommand(CambiosEventMethods); }
        }

        #endregion

    }
}
