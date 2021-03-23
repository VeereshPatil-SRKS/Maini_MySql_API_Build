using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblcell
    {
        public UnitworkccsTblcell()
        {
            UnitworkccsConfigurationTblprimitivemaintainancescheduling = new HashSet<UnitworkccsConfigurationTblprimitivemaintainancescheduling>();
            UnitworkccsTblmachinedetails = new HashSet<UnitworkccsTblmachinedetails>();
        }

        public int CellId { get; set; }
        public string CellName { get; set; }
        public string CellDesc { get; set; }
        public int? PlantId { get; set; }
        public int ShopId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string CelldisplayName { get; set; }
        public byte? DefaultFlag { get; set; }

        public virtual UnitworkccsTblplant Plant { get; set; }
        public virtual UnitworkccsTblshop Shop { get; set; }
        public virtual ICollection<UnitworkccsConfigurationTblprimitivemaintainancescheduling> UnitworkccsConfigurationTblprimitivemaintainancescheduling { get; set; }
        public virtual ICollection<UnitworkccsTblmachinedetails> UnitworkccsTblmachinedetails { get; set; }
    }
}
