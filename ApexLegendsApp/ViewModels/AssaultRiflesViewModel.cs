using System.Collections.Generic;
using ApexLegendsApp.Model;
using ApexLegendsApp.Services;
using Xamarin.Forms;

namespace ApexLegendsApp.ViewModels
{
    public class AssaultRiflesViewModel : BaseViewModel
    {
        private readonly IGameDataAPIService _gameDataApiService;

        public AssaultRiflesViewModel()
        {
            _gameDataApiService = DependencyService.Get<IGameDataAPIService>();
        }

        private List<Weapon> _weapons;

        public List<Weapon> Weapons
        {
            get => _weapons;
            set
            {
                _weapons = value;
                OnPropertyChanged();
            }
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            Weapons = await _gameDataApiService.GetAssaultRifles();
        }
    }
}