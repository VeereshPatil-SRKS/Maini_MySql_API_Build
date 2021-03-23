using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblmachinedetailsnew
    {
        public int MachineId { get; set; }
        public string MachineInvNo { get; set; }
        public string Ipaddress { get; set; }
        public string MachineType { get; set; }
        public string ControllerType { get; set; }
        public string InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
        public string MachineModel { get; set; }
        public string MachineMake { get; set; }
        public string ModelType { get; set; }
        public string MachineDispName { get; set; }
        public int IsParameters { get; set; }
        public string ShopNo { get; set; }
        public int? IsPcb { get; set; }
        public int? IsLevel { get; set; }
        public int? PlantId { get; set; }
        public int? ShopId { get; set; }
        public int? CellId { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual Tblshop Shop { get; set; }
    }
}
