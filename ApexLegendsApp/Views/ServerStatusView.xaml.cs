using ApexLegendsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApexLegendsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServerStatusView : ContentPage
    {
        public ServerStatusView()
        {
            InitializeComponent();
            BindingContext = new ServerStatusViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            (BindingContext as ServerStatusViewModel).OnAppearing();
        }
    }
}