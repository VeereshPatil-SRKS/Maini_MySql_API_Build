using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblbottelneck
    {
        public int Bid { get; set; }
        public string PlantName { get; set; }
        public string ShopName { get; set; }
        public string CellName { get; set; }
        public string MachineName { get; set; }
        public string PartNo { get; set; }
        public int PlantId { get; set; }
        public int ShopId { get; set; }
        public int CellId { get; set; }
        public int MachineId { get; set; }
        public int Cpid { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblcellpart Cp { get; set; }
        public virtual Tblmachinedetails Machine { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual Tblshop Shop { get; set; }
    }
}
