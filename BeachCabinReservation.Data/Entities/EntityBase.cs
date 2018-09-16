using System;
using System.Collections.Generic;
using System.Text;

namespace BeachCabinReservation.Data.Entities
{
    public class EntityBase
    {
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
