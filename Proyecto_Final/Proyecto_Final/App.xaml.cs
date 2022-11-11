using Proyecto_Final.DataBase;
using Proyecto_Final.Model;
using Proyecto_Final.Views;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace Proyecto_Final
{
    public partial class App : Application
    {
        static DataBaseQuery DataBase;

        public static DataBaseQuery Db
        {
            get
            {
                if (DataBase == null)
                {
                    DataBase = new DataBaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBRegister.db"));
                }
                return DataBase;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new registrate());
        }

        protected override void OnStart()
        {
            OrganizadorModel user = new OrganizadorModel
            {
                Name = "pepito",
                LastName = "Alcachofa",
                Email = "251628",
                Password = "1234",
                Edadades = 19,
                phone = "313438",
                Cedula = "1088825376",
                Dirección = "Calle 14"
            };

            var resul = App.Db.SaveModelAsync<OrganizadorModel>(user, true);



            List<UserModel> Listusers = new List<UserModel>();

            Listusers = App.Db.GetTableModel<UserModel>().Result;



            List<OrganizadorModel> ListOrganizadores = Db.GetTableModel<OrganizadorModel>().Result;
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
