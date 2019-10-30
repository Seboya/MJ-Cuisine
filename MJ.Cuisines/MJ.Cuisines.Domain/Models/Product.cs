using MJ.Cuisines.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MJ.Cuisines.Domain.Models
{
    public class Product : ModelBase
    {
        #region Constructors
        public Product()
        {

        }
        #endregion

        #region Properties
        public string Name { get; set; }

        public double Price { get; set; }

        [Timestamp]
        public byte[] Image { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion
    }
}
