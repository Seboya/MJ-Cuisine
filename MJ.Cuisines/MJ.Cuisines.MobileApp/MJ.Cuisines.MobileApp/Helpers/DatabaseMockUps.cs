using MJ.Cuisines.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MJ.Cuisines.MobileApp.Helpers
{
    public class DatabaseMockUps
    {
        #region Constructors
        public DatabaseMockUps()
        {
            this.LoadCategotyMockUpData();
            this.LoadProductMockUpData();
        }
        #endregion

        #region Properties
        public ObservableCollection<Category> Categories { get; set; }

        public ObservableCollection<Product> Products { get; set; }
        #endregion

        #region Public Methods

        #endregion

        #region Private Methods
        private void LoadCategotyMockUpData()
        {
            this.Categories = new ObservableCollection<Category>
            {
                new Category{ Id = 1, Name = "Food", CreatedBy = "Marumo Seboya" },
                new Category{ Id = 1, Name = "Coffee", CreatedBy = "Marumo Seboya" },
            };
        }

        private void LoadProductMockUpData()
        {
            this.Products = new ObservableCollection<Product>
            {
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
                new Product{ Id = 1, Name = "Food 1", Price = 15.0, Description = "Food 1 Description", CreatedBy = "Marumo Seboya",
                    Category = (this.Categories != null && this.Categories.Count > 0) ? this.Categories[0] : null},
            };
        }
        #endregion
    }
}
