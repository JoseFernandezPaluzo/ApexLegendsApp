using ApexLegendsApp.Model;
using ApexLegendsApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ApexLegendsApp.ViewModels
{
    public class ServerStatusViewModel : BaseViewModel
    {
        private readonly IGameServerStatusService _gameServerStatusService;

        public ServerStatusViewModel()
        {
            _gameServerStatusService = DependencyService.Get<IGameServerStatusService>();
        }

        private List<Server> _servers;
        
        public List<Server> Servers
        {
            get => _servers;
            set
            {
                _servers = value;
                OnPropertyChanged();
            }
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            Servers = await _gameServerStatusService.GetServerStatus();
        }
    }
}
