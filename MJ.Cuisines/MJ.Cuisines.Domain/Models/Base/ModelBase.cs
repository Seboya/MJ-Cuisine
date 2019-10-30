using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MJ.Cuisines.Domain.Models.Base
{
    public class ModelBase
    {
        #region Variables
        private DateTime? createdDate;
        #endregion

        #region Construction
        public ModelBase()
        {

        }
        #endregion

        #region Properties
        public virtual long Id { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate
        {
            get { return createdDate ?? DateTime.UtcNow; }
            set { createdDate = value; }
        }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }
        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion
    }
}
