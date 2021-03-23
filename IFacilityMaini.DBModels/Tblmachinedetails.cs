using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class Tblmachinedetails
    {
        public Tblmachinedetails()
        {
            ConfigurationTblprimitivemaintainancescheduling = new HashSet<ConfigurationTblprimitivemaintainancescheduling>();
            Configurationtblmachinesensor = new HashSet<Configurationtblmachinesensor>();
            TblAutoreportsetting = new HashSet<TblAutoreportsetting>();
            TblAxisdet = new HashSet<TblAxisdet>();
            TblBreakDownTickect = new HashSet<TblBreakDownTickect>();
            TblCycleTimeAnalysis = new HashSet<TblCycleTimeAnalysis>();
            TblNcProgramTransferMain = new HashSet<TblNcProgramTransferMain>();
            TblOeedetails = new HashSet<TblOeedetails>();
            TblOeeoperatorDetails = new HashSet<TblOeeoperatorDetails>();
            TblOeeshiftDetails = new HashSet<TblOeeshiftDetails>();
            TblOperatorDashboard = new HashSet<TblOperatorDashboard>();
            TblOperatorHeader = new HashSet<TblOperatorHeader>();
            TblOperatorMachineDetails = new HashSet<TblOperatorMachineDetails>();
            TblProdAndonDisp = new HashSet<TblProdAndonDisp>();
            TblProdManMachine = new HashSet<TblProdManMachine>();
            TblProdOrderLosses = new HashSet<TblProdOrderLosses>();
            TblSetupMaint = new HashSet<TblSetupMaint>();
            TblUtilReport = new HashSet<TblUtilReport>();
            Tblbottelneck = new HashSet<Tblbottelneck>();
            Tbldailyprodstatus = new HashSet<Tbldailyprodstatus>();
            Tblemailescalation = new HashSet<Tblemailescalation>();
            Tbllivedailyprodstatus = new HashSet<Tbllivedailyprodstatus>();
            Tbllivemode = new HashSet<Tbllivemode>();
            Tblmimics = new HashSet<Tblmimics>();
            Tblmode = new HashSet<Tblmode>();
            Tblmodetemp = new HashSet<Tblmodetemp>();
            Tblmultipleworkorder = new HashSet<Tblmultipleworkorder>();
            Tblpartscountandcutting = new HashSet<Tblpartscountandcutting>();
            Tblrejectreason = new HashSet<Tblrejectreason>();
            TblshiftdetailsMachinewise = new HashSet<TblshiftdetailsMachinewise>();
            Tblshiftplanner = new HashSet<Tblshiftplanner>();
            Tbltoollifeoperator = new HashSet<Tbltoollifeoperator>();
            Tblusers = new HashSet<Tblusers>();
        }

        public int MachineId { get; set; }
        public string InsertedOn { get; set; }
        public int InsertedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
        public int? PlantId { get; set; }
        public int? ShopId { get; set; }
        public int? CellId { get; set; }
        public string MachineName { get; set; }
        public string MachineDescription { get; set; }
        public string MachineDisplayName { get; set; }
        public int? CellOrderNo { get; set; }
        public string Ipaddress { get; set; }
        public int? MachineType { get; set; }
        public string ControllerType { get; set; }
        public string MachineModel { get; set; }
        public string MachineMake { get; set; }
        public string ModelType { get; set; }
        public int? IsParameters { get; set; }
        public string ShopNo { get; set; }
        public int? IsPcb { get; set; }
        public int? IsLevel { get; set; }
        public int? IsNormalWc { get; set; }
        public int? ManualWcid { get; set; }
        public int? NoOfAxis { get; set; }
        public string MacType { get; set; }
        public int? CurrentControlAxis { get; set; }
        public string ProgramNum { get; set; }
        public string ProgDbit { get; set; }
        public int MachineModelType { get; set; }
        public string MacConnName { get; set; }
        public string SpindleAxis { get; set; }
        public string TabIpaddress { get; set; }
        public int? MachineLockBit { get; set; }
        public int? MachineSetupBit { get; set; }
        public int? MachineMaintBit { get; set; }
        public int? MachineToolLifeBit { get; set; }
        public int? MachineUnlockBit { get; set; }
        public int? MachineIdleBit { get; set; }
        public int? MachineIdleMin { get; set; }
        public int EnableLockLogic { get; set; }
        public int ServerTabFlagSync { get; set; }
        public int ServerTabCheck { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? EnableToolLife { get; set; }
        public int? IsBottelNeck { get; set; }
        public int? IsFirstMachine { get; set; }
        public int? IsLastMachine { get; set; }
        public int? OperationNumber { get; set; }
        public int IsShiftWise { get; set; }
        public int? LossFlag { get; set; }
        public int? TransmissionFrequency { get; set; }
        public string LoggerType { get; set; }
        public int? MachinePort { get; set; }
        public int? NumOfAxis { get; set; }
        public int? ToolGroupNum { get; set; }
        public int? NumberOfCurrent { get; set; }
        public int? NumberOfTemperature { get; set; }
        public int? NumberOfPresure { get; set; }
        public int? NumberOfLevel { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsWimerasys { get; set; }
        public string IotgatewayIp { get; set; }
        public int? NodeId { get; set; }
        public int IsDlversion { get; set; }
        public int? MachinePockets { get; set; }
        public int? NoOfPartsPerCycle { get; set; }
        public string Category { get; set; }
        public int? MachineCategoryId { get; set; }
        public string Mmmgroup { get; set; }
        public string DedicatedOrShared { get; set; }
        public string PrimaryOrSecondary { get; set; }
        public string MachineSpec { get; set; }
        public int? ChuckOrRodSize { get; set; }
        public int? NoOfToolStation { get; set; }
        public int? TallStockAvailId { get; set; }
        public int? NoOfAxisId { get; set; }
        public string TableSize { get; set; }
        public int? PalletId { get; set; }

        public virtual Tblcell Cell { get; set; }
        public virtual Tblplant Plant { get; set; }
        public virtual Tblshop Shop { get; set; }
        public virtual ICollection<ConfigurationTblprimitivemaintainancescheduling> ConfigurationTblprimitivemaintainancescheduling { get; set; }
        public virtual ICollection<Configurationtblmachinesensor> Configurationtblmachinesensor { get; set; }
        public virtual ICollection<TblAutoreportsetting> TblAutoreportsetting { get; set; }
        public virtual ICollection<TblAxisdet> TblAxisdet { get; set; }
        public virtual ICollection<TblBreakDownTickect> TblBreakDownTickect { get; set; }
        public virtual ICollection<TblCycleTimeAnalysis> TblCycleTimeAnalysis { get; set; }
        public virtual ICollection<TblNcProgramTransferMain> TblNcProgramTransferMain { get; set; }
        public virtual ICollection<TblOeedetails> TblOeedetails { get; set; }
        public virtual ICollection<TblOeeoperatorDetails> TblOeeoperatorDetails { get; set; }
        public virtual ICollection<TblOeeshiftDetails> TblOeeshiftDetails { get; set; }
        public virtual ICollection<TblOperatorDashboard> TblOperatorDashboard { get; set; }
        public virtual ICollection<TblOperatorHeader> TblOperatorHeader { get; set; }
        public virtual ICollection<TblOperatorMachineDetails> TblOperatorMachineDetails { get; set; }
        public virtual ICollection<TblProdAndonDisp> TblProdAndonDisp { get; set; }
        public virtual ICollection<TblProdManMachine> TblProdManMachine { get; set; }
        public virtual ICollection<TblProdOrderLosses> TblProdOrderLosses { get; set; }
        public virtual ICollection<TblSetupMaint> TblSetupMaint { get; set; }
        public virtual ICollection<TblUtilReport> TblUtilReport { get; set; }
        public virtual ICollection<Tblbottelneck> Tblbottelneck { get; set; }
        public virtual ICollection<Tbldailyprodstatus> Tbldailyprodstatus { get; set; }
        public virtual ICollection<Tblemailescalation> Tblemailescalation { get; set; }
        public virtual ICollection<Tbllivedailyprodstatus> Tbllivedailyprodstatus { get; set; }
        public virtual ICollection<Tbllivemode> Tbllivemode { get; set; }
        public virtual ICollection<Tblmimics> Tblmimics { get; set; }
        public virtual ICollection<Tblmode> Tblmode { get; set; }
        public virtual ICollection<Tblmodetemp> Tblmodetemp { get; set; }
        public virtual ICollection<Tblmultipleworkorder> Tblmultipleworkorder { get; set; }
        public virtual ICollection<Tblpartscountandcutting> Tblpartscountandcutting { get; set; }
        public virtual ICollection<Tblrejectreason> Tblrejectreason { get; set; }
        public virtual ICollection<TblshiftdetailsMachinewise> TblshiftdetailsMachinewise { get; set; }
        public virtual ICollection<Tblshiftplanner> Tblshiftplanner { get; set; }
        public virtual ICollection<Tbltoollifeoperator> Tbltoollifeoperator { get; set; }
        public virtual ICollection<Tblusers> Tblusers { get; set; }
    }
}
