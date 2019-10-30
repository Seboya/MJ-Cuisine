using MJ.Cuisines.Domain.Models;
using MJ.Cuisines.MobileApp.Helpers;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MJ.Cuisines.MobileApp.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        #region Variables
        private DatabaseMockUps databaseMockUps;
        #endregion

        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.databaseMockUps = new DatabaseMockUps();
            this.Products = new ObservableCollection<Product>(this.databaseMockUps.Products);
        }

        #region Properties
        public ObservableCollection<Product> Products { get; set; }
        #endregion

        #region Public Methods

        #endregion

        #region Private Methods
        #endregion
    }
}
