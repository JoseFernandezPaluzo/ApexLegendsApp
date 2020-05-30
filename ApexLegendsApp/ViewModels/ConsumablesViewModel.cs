using ApexLegendsApp.Model;
using ApexLegendsApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ApexLegendsApp.ViewModels
{
    public class ConsumablesViewModel : BaseViewModel
    {
        private readonly IGameDataAPIService _gameDataApiService;

        public ConsumablesViewModel()
        {
            _gameDataApiService = DependencyService.Get<IGameDataAPIService>();
        }

        private List<Consumables> _consumables;

        public List<Consumables> Consumables
        {
            get => _consumables;
            set
            {
                _consumables = value;
                OnPropertyChanged();
            }
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            Consumables = await _gameDataApiService.GetConsumables();
        }
    }
}
