using Proyecto_Final.Model;
using Proyecto_Final.Views;
using Proyecto_Final.Views.MaestroDetalle;
using System.Collections.Generic;

namespace Proyecto_Final.ViewModel
{
    internal class MaestroDetailOrganizadorViewModel : BaseViewModel
    {
        #region Atributos 

        public string IconMaster;
        public string TitleMaster;
        public object ListMaster;

        #endregion

        #region Propiedades

        public string IconTxt
        {
            get { return IconMaster; }
            set { SetValue(ref this.IconMaster, value); }
        }

        public string TitleTxt
        {
            get { return TitleMaster; }
            set { SetValue(ref this.TitleMaster, value); }
        }

        public object ListTxt
        {
            get { return ListMaster; }
            set { SetValue(ref this.ListMaster, value); }
        }

        #endregion

        public MaestroDetailOrganizadorViewModel()
        {

            this.ListTxt = new List<MenuLateralModel>(new[]
            {
                new MenuLateralModel { Id = 0 , Title = "Crear Eventos", Icono="Lista.jpg",TargetType= typeof(AgregarEvento) },
                new MenuLateralModel { Id = 0 , Title = "Modificar Eventos", Icono="Lista.jpg",TargetType= typeof(ModificarEventoView) },
                new MenuLateralModel { Id = 0 , Title = "Visualizar Eventos", Icono="Lista.jpg",TargetType= typeof(MainPage) },
                new MenuLateralModel { Id = 0 , Title = "Visualizar Participantes", Icono="Lista.jpg",TargetType= typeof(ParticipantesEventView) },
                new MenuLateralModel { Id = 0 , Title = "Pagina Principal", Icono="Lista.jpg",TargetType= typeof(MaestroDetailOrganizador) },
                new MenuLateralModel { Id = 0 , Title = "Cerrar Sesión", Icono="Lista.jpg",TargetType= typeof(IngresarView) }
            });
        }
    }
}
