using Proyecto_Final.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Proyecto_Final.ViewModel
{
    internal class AgregarElementoViewModel : BaseViewModel
    {
        public AgregarElementoViewModel(Picker piker, Picker municipio )
        {
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
                piker.Items.Add(nombre.Nombre);
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
        public string PolizaTxt;
        #endregion

        #region Propiedades

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
            set { SetValue(ref this.Poliza, value);
                int poliza2 = Poliza * 1000;
                PolizaValueTxt = poliza2.ToString();
            }

        }
        public string PolizaValueTxt
        {
            get { return PolizaTxt; }
            set { SetValue(ref this.PolizaTxt, value); }

        }

        #endregion

        #region Methods



        #endregion
    }
}
