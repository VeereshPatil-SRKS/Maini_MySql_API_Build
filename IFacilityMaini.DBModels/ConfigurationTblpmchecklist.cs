﻿using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class ConfigurationTblpmchecklist
    {
        public int Pmcid { get; set; }
        public int PmcpId { get; set; }
        public string CheckList { get; set; }
        public string Frequency { get; set; }
        public int CellId { get; set; }
        public string Value { get; set; }
        public int? Isdeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int ShopId { get; set; }
        public int PlantId { get; set; }
        public string How { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual ConfigurationTblpmcheckpoint Pmcp { get; set; }
        public virtual Tblshop Shop { get; set; }
    }
}
