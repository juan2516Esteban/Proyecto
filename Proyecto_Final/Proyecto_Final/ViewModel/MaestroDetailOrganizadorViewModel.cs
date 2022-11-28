using Proyecto_Final.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Proyecto_Final.Views;
using Proyecto_Final.Views.MaestroDetalle;

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
                new MenuLateralModel { Id = 0 , Title = "Service", Icono="logo.jpg",TargetType= typeof(MainPage) },
                new MenuLateralModel { Id = 0 , Title = "Paguina Pricipal", Icono="logo.jpg",TargetType= typeof(MaestroDetailOrganizador) }
            });
        }
    }
}
