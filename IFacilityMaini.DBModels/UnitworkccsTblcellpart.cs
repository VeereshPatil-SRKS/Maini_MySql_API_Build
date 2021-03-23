﻿using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblcellpart
    {
        public UnitworkccsTblcellpart()
        {
            UnitworkccsTblbottelneck = new HashSet<UnitworkccsTblbottelneck>();
        }

        public int CpId { get; set; }
        public int CellId { get; set; }
        public string PartNo { get; set; }
        public string PartDescription { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int IsDefault { get; set; }

        public virtual ICollection<UnitworkccsTblbottelneck> UnitworkccsTblbottelneck { get; set; }
    }
}
