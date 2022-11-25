using Proyecto_Final.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Final.ViewModel
{
    public class EventosViewModel : BaseViewModel
    {

        public EventosViewModel()
        {
            loadEvento();
        }

        #region Atributos
        public object Eventos;
        #endregion

        #region Propiedades
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
        #endregion
    }
}
