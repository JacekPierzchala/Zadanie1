using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zadanie1.ApplicationLayer;
using Zadanie1.Core;
using Zadanie1.Infrastructure;

namespace Zadanie1.UI.ViewModel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private readonly IPackageQueries _packageQueries;
        private readonly IPackageCommands _packageCommands;
        private ObservableCollection<PackageDTO> _packages;     
        public ObservableCollection<PackageDTO> Packages
        {
            get => _packages;
            set { _packages = value; OnPropertyChanged(); }
        }
        public ICommand LoadPackagesCommand { get; private set; }
        public ICommand SavePackagesCommand { get; private set; }
        public MainViewModel(IPackageQueries packageQueries, IPackageCommands packageCommands)
        {
            _packageQueries = packageQueries;
            _packageCommands = packageCommands;
            LoadPackagesCommand = new RelayCommand(LoadPackages);
            LoadPackagesCommand.Execute(null);
            SavePackagesCommand = new RelayCommand(SavePackages);

        }



        private void SavePackages()
        {
            _packageCommands.UpdatePackages(Packages);
        }

        private void LoadPackages()
        {
            Packages = new ObservableCollection<PackageDTO>(_packageQueries.GetPackages());
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
