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

            MainPage = new CustomNav(new AgregarEvento());
        }

        protected override void OnStart()
        {
 
            List<UserModel> Listusers = new List<UserModel>();

            Listusers = App.Db.GetTableModel<UserModel>().Result;



        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
