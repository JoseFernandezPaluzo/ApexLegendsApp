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
    public partial class ConsumablesView : ContentPage
    {
        public ConsumablesView()
        {
            InitializeComponent();
            BindingContext = new ConsumablesViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            (BindingContext as ConsumablesViewModel).OnAppearing();
        }
    }
}