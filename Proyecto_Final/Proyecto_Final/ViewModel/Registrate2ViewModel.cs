using Proyecto_Final.Model;
using Proyecto_Final.Views;
using Application = Xamarin.Forms.Application;

namespace Proyecto_Final.ViewModel
{
    internal class Registrate2ViewModel : BaseViewModel
    {

        #region Atributos
        public int Edad;
        public string Telefono;
        public string Cedula;
        public string Dirección;
        public bool TpUsuario;
        #endregion

        #region Propiedades

        public bool TpUsuarioTxt
        {
            get { return TpUsuario; }
            set { SetValue(ref this.TpUsuario, value); }
        }
        public int EdadTxt
        {
            get { return Edad; }
            set { SetValue(ref this.Edad, value); }
        }

        public string TelefonoTxt
        {
            get { return Telefono; }
            set { SetValue(ref this.Telefono, value); }
        }

        public string CedulaTxt
        {
            get { return Cedula; }
            set { SetValue(ref this.Cedula, value); }
        }

        public string DirecciónTxt
        {
            get { return Dirección; }
            set { SetValue(ref this.Dirección, value); }
        }
        #endregion

        #region Command

        #endregion

        #region Methods

        public async void RegisterMethot(UserModel jdl)
        {
            if (EdadTxt == 0 || TelefonoTxt is null || TelefonoTxt == "")
            {
                await Application.Current.MainPage.DisplayAlert("Por favor llenar los campos vacios", "Error no se pudo guadar la información", "ok");
            }
            else
            {
                if (TpUsuario == false)
                {
                    UserModel user = new UserModel();
                    user.phone = TelefonoTxt;
                    user.Edadades = EdadTxt;
                    user.Name = jdl.Name;
                    user.Email = jdl.Email;
                    user.Password = jdl.Password;
                    user.LastName = jdl.LastName;

                    await App.Db.SaveModelAsync<UserModel>(user, true);
                    await App.Db.SaveModelAsync<UserModel>(user, false);
                    await Application.Current.MainPage.DisplayAlert("Tus datos an sido guardado correctamente", "Bienvendo " + jdl.Name + " ya eres parte de fanaticos al deporte, que esperas para iniciar sesión", "Ok");
                    await Application.Current.MainPage.Navigation.PushAsync(new IngresarView());
                }
                else
                {
                    if (DirecciónTxt is null || DirecciónTxt == "" || CedulaTxt is null || CedulaTxt == "")
                    {
                        await Application.Current.MainPage.DisplayAlert("Por favor llenar los campos vacios", "Error no se pudo guardar la información", "ok");
                    }
                    else
                    {
                        OrganizadorModel user2 = new OrganizadorModel();

                        user2.phone = TelefonoTxt;
                        user2.Edadades = EdadTxt;
                        user2.Name = jdl.Name;
                        user2.Email = jdl.Email;
                        user2.Password = jdl.Password;
                        user2.LastName = jdl.LastName;
                        user2.Dirección = DirecciónTxt;
                        user2.Cedula = CedulaTxt;

                        await App.Db.SaveModelAsync<OrganizadorModel>(user2, true);
                        await App.Db.SaveModelAsync<OrganizadorModel>(user2, false);
                        await Application.Current.MainPage.DisplayAlert("Tus datos an sido guardado correctamente", "Bienvendo " + jdl.Name + " ya eres parte de fanaticos al deporte, que esperas para iniciar sesión", "Ok");
                        await Application.Current.MainPage.Navigation.PushAsync(new IngresarView());
                    }
                }
            }
        }




        #endregion
    }
}
