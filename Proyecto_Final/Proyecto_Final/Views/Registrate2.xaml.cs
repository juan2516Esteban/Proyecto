using Proyecto_Final.Model;
using Proyecto_Final.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrate2 : ContentPage
    {
        UserModel user2 = new UserModel();
        public Registrate2(UserModel item)
        {

            InitializeComponent();

            BindingContext = new Registrate2ViewModel();

            user2.Name = item.Name;
            user2.LastName = item.LastName;
            user2.Email = item.Email;
            user2.Password = item.Password;

        }

        private void switchTransform_Toggled(object sender, ToggledEventArgs e)
        {
            Registrate2ViewModel viewModel = (Registrate2ViewModel)BindingContext;

            if (e.Value == true)
            {
                if (viewModel.EdadTxt < 18)
                {
                    switchTransform.IsToggled = false;
                    StacTransf.IsVisible = false;
                    TercerLabel.Text = "No puedes acceder al modo desarrollador si no eres mayor de edad ";
                }
                else
                {
                    PrimerLabel.Padding = new Thickness(50, 30, 0, 0);
                    StacTransf.Padding = new Thickness(50, 3, 30, 0);
                    StacTransf.IsVisible = true;
                    TercerLabel.Text = "";
                    SliderOptions.IsEnabled = false;
                }
            }
            else
            {
                SliderOptions.IsEnabled = true;
                StacTransf.IsVisible = false;
                PrimerLabel.Padding = new Thickness(50, 150, 0, 0);
            }

        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Registrate2ViewModel rb = (Registrate2ViewModel)BindingContext;
            rb.RegisterMethot(user2);
        }
    }
}