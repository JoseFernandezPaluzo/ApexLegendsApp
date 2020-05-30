using System.Windows.Input;
using ApexLegendsApp.Views;
using Xamarin.Forms;

namespace ApexLegendsApp.ViewModels
{
    public class WeaponsViewModel : BaseViewModel
    {
        public WeaponsViewModel()
        {
            _goToAssaultRifles = new Command(PeformGoToWeapons);
            _goToConsumablesCommand = new Command(PerformGoToConsumablesView);
        }

        private void PeformGoToWeapons(object obj)
            => App.Current.MainPage.Navigation.PushAsync(new AssaultRiflesView());

        private void PerformGoToConsumablesView()
            => App.Current.MainPage.Navigation.PushAsync(new ConsumablesView());

        private Command _goToAssaultRifles;
        private Command _goToConsumablesCommand;

        public ICommand GoToConsumablesCommand => _goToConsumablesCommand;
        public ICommand GoToAssaultRiflesCommand => _goToAssaultRifles;
    }
}