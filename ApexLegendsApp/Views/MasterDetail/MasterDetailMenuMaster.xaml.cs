using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApexLegendsApp.Views.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMenuMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailMenuMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailMenuMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailMenuMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailMenuMasterMenuItem> MenuItems { get; set; }

            public MasterDetailMenuMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailMenuMasterMenuItem>(new[]
                {
                    new MasterDetailMenuMasterMenuItem { Id = 0, Title = "Weapons View", TargetType = typeof(WeaponsView) },
                    new MasterDetailMenuMasterMenuItem { Id = 1, Title = "Server Status", TargetType = typeof(ServerStatusView) },                   
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}