using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Zadanie1.ApplicationLayer;
using Zadanie1.Infrastructure;


namespace Zadanie1.UI.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();    
            SimpleIoc.Default.Register<DatabaseHandler>();    
            SimpleIoc.Default.Register<IPackageRepository, PackageRepository>();    
            SimpleIoc.Default.Register<IPackageQueries, PackageQueries>();    
            SimpleIoc.Default.Register<IPackageCommands, PackageCommands>();    

        }

        public MainViewModel MainViewModel { get=>ServiceLocator.Current.GetInstance<MainViewModel>();  }

    }
}
