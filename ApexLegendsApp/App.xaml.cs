using ApexLegendsApp.Services;
using ApexLegendsApp.Views.MasterDetail;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ApexLegendsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MasterDetailMenu());
        }

        protected override void OnStart()
        {
            //Services Register with DependencyService
            DependencyService.Register<IGameDataAPIService, GameDataApiService>();
            DependencyService.Register<IGameServerStatusService, GameServerStatusService>();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}