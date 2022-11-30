using GalaSoft.MvvmLight.Command;
using Proyecto_Final.Model;
using Proyecto_Final.Views.MaestroDetalle;
using System.Collections.Generic;
using System.Windows.Input;
using Application = Xamarin.Forms.Application;

namespace Proyecto_Final.ViewModel
{
    internal class LoginViewModel : BaseViewModel
    {
        #region Atrubutos 
        public string Correo;
        public string Contraseña;
        #endregion

        #region Propiedades
        public string CorreoTxt
        {
            get { return Correo; }
            set { SetValue(ref this.Correo, value); }
        }

        public string ContraseñaTxt
        {
            get { return Contraseña; }
            set { SetValue(ref this.Contraseña, value); }
        }
        #endregion

        #region Commands 
        public ICommand IngresarCommand
        {
            get { return new RelayCommand(IngreasarMethods); }
        }
        #endregion

        #region Methods
        public async void IngreasarMethods()
        {
            if (CorreoTxt is null || CorreoTxt == "" || ContraseñaTxt is null || ContraseñaTxt == "")
            {
                await Application.Current.MainPage.DisplayAlert("Por favor llenar los campos vacios", "Error no se pudo guardar la información", "ok");
            }
            else
            {

                string _query = "SELECT * FROM UserModel WHERE Email = '" + CorreoTxt.ToString() + "' AND Password = '" + ContraseñaTxt.ToString() + "' ";
                string _queryOrganizador = "SELECT * FROM OrganizadorModel WHERE Email = '" + CorreoTxt.ToString() + "' AND Password = '" + ContraseñaTxt.ToString() + "' ";

                List<UserModel> ListUser = App.Db.QueryModel<UserModel>(_query).Result;
                List<OrganizadorModel> ListUserOrganizador = App.Db.QueryModel<OrganizadorModel>(_queryOrganizador).Result;

                if (ListUser.Count > 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Bienvenido", "Acabas de ingresar a fanaticos al deporte", "Ok");
                    await Application.Current.MainPage.Navigation.PushAsync(new MaestroUsuario());
                }
                else if (ListUserOrganizador.Count > 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Bienvenido", "Acabas de ingresar a fanaticos al deporte, como Organizador de eventos", "Ok");
                    await Application.Current.MainPage.Navigation.PushAsync(new MaestroDetailOrganizador());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("El usuario no Existe", "El usuario no se encuentra en la base de datos , por favor verifica tus datos y vuelve a intentarlo", "Ok");
                }
            }
        }

        #endregion
    }
}

