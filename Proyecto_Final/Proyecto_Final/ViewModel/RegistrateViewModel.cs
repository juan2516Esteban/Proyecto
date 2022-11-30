using GalaSoft.MvvmLight.Command;
using Proyecto_Final.Model;
using Proyecto_Final.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace Proyecto_Final.ViewModel
{
    internal class RegistrateViewModel : BaseViewModel
    {
        #region Atributos
        public string Nombre;
        public string Apellido;
        public string Contraseña;
        public string Comfirmar_Passw;
        public string Email;


        #endregion

        #region Propiedades

        public string NombreTxt
        {
            get { return Nombre; }
            set { SetValue(ref this.Nombre, value); }
        }

        public string ApellidoTxt
        {
            get { return Apellido; }
            set { SetValue(ref this.Apellido, value); }
        }

        public string ContraseñaTxt
        {
            get { return Contraseña; }
            set { SetValue(ref this.Contraseña, value); }
        }
        public string ComfirmarTxt
        {
            get { return Comfirmar_Passw; }
            set { SetValue(ref this.Comfirmar_Passw, value); }
        }

        public string EmailTxt
        {
            get { return Email; }
            set { SetValue(ref this.Email, value); }
        }

        #endregion

        #region Commands
        public ICommand ComfirmaciónCommand
        {
            get { return new RelayCommand(ContraseñaMethods); }
        }

        #endregion

        #region Methods

        public async void ContraseñaMethods()
        {
            if (NombreTxt is null || ApellidoTxt is null || EmailTxt is null || ComfirmarTxt is null || ContraseñaTxt is null || NombreTxt == "" || ApellidoTxt == "" || EmailTxt == "" || ComfirmarTxt == "" || ContraseñaTxt == "")
            {
                await Application.Current.MainPage.DisplayAlert("Por favor llenar los campos vacios", "Error no se pudo guardar la información", "ok");
            }
            else if (ContraseñaTxt.ToString() != Comfirmar_Passw.ToString())
            {
                await Application.Current.MainPage.DisplayAlert("Contrseña Diferentes", "Las contraseñas digitadas no son las correctas por favor vuelve a intentarlo", "ok");
            }
            else
            {
                UserModel item = new UserModel();
                item.Name = NombreTxt;
                item.LastName = ApellidoTxt;
                item.Email = EmailTxt;
                item.Password = ContraseñaTxt;

                await Application.Current.MainPage.Navigation.PushAsync(new Registrate2(item));
            }
        }
        #endregion
    }
}
