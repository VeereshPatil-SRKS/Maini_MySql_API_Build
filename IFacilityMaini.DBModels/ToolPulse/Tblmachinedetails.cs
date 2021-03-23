using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class Tblmachinedetails
    {
        public Tblmachinedetails()
        {
            TblAutoreportsetting = new HashSet<TblAutoreportsetting>();
            Tbldailyprodstatus = new HashSet<Tbldailyprodstatus>();
            Tblemailescalation = new HashSet<Tblemailescalation>();
            Tblhmiscreen = new HashSet<Tblhmiscreen>();
            Tbllivedailyprodstatus = new HashSet<Tbllivedailyprodstatus>();
            Tbllivehmiscreen = new HashSet<Tbllivehmiscreen>();
            Tbllivehmiscreenrep = new HashSet<Tbllivehmiscreenrep>();
            Tbllivemode = new HashSet<Tbllivemode>();
            Tbllivemodedb = new HashSet<Tbllivemodedb>();
            Tblmachineallocation = new HashSet<Tblmachineallocation>();
            Tblmimics = new HashSet<Tblmimics>();
            Tblmultipleworkorder = new HashSet<Tblmultipleworkorder>();
            Tblparts = new HashSet<Tblparts>();
            Tblpartwiseworkcenter = new HashSet<Tblpartwiseworkcenter>();
            TblshiftdetailsMachinewise = new HashSet<TblshiftdetailsMachinewise>();
            Tblshiftplanner = new HashSet<Tblshiftplanner>();
            Tblusers = new HashSet<Tblusers>();
        }

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
        public string DeletedDate { get; set; }
        public int IsNormalWc { get; set; }
        public int? ManualWcid { get; set; }
        public int? DepartmentId { get; set; }
        public string PlantCode { get; set; }
        public string Wccode { get; set; }
        public string CostCenter { get; set; }
        public string Wcdescription { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual Tblshop Shop { get; set; }
        public virtual ICollection<TblAutoreportsetting> TblAutoreportsetting { get; set; }
        public virtual ICollection<Tbldailyprodstatus> Tbldailyprodstatus { get; set; }
        public virtual ICollection<Tblemailescalation> Tblemailescalation { get; set; }
        public virtual ICollection<Tblhmiscreen> Tblhmiscreen { get; set; }
        public virtual ICollection<Tbllivedailyprodstatus> Tbllivedailyprodstatus { get; set; }
        public virtual ICollection<Tbllivehmiscreen> Tbllivehmiscreen { get; set; }
        public virtual ICollection<Tbllivehmiscreenrep> Tbllivehmiscreenrep { get; set; }
        public virtual ICollection<Tbllivemode> Tbllivemode { get; set; }
        public virtual ICollection<Tbllivemodedb> Tbllivemodedb { get; set; }
        public virtual ICollection<Tblmachineallocation> Tblmachineallocation { get; set; }
        public virtual ICollection<Tblmimics> Tblmimics { get; set; }
        public virtual ICollection<Tblmultipleworkorder> Tblmultipleworkorder { get; set; }
        public virtual ICollection<Tblparts> Tblparts { get; set; }
        public virtual ICollection<Tblpartwiseworkcenter> Tblpartwiseworkcenter { get; set; }
        public virtual ICollection<TblshiftdetailsMachinewise> TblshiftdetailsMachinewise { get; set; }
        public virtual ICollection<Tblshiftplanner> Tblshiftplanner { get; set; }
        public virtual ICollection<Tblusers> Tblusers { get; set; }
    }
}
