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
                    DataBase = new DataBaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Dbfanaticos.db"));
                }
                return DataBase;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new CustomNav(new MainPage());
        }

        protected override void OnStart()
        {

            List<UserModel> Listusers = App.Db.GetTableModel<UserModel>().Result;

            List<OrganizadorModel> ListusersOrganizadores = App.Db.GetTableModel<OrganizadorModel>().Result;

            List<SubirEventModel> Eventos = App.Db.GetTableModel<SubirEventModel>().Result;


        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
