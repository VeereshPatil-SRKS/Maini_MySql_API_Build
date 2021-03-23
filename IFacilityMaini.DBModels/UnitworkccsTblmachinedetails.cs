using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class UnitworkccsTblmachinedetails
    {
        public UnitworkccsTblmachinedetails()
        {
            UnitworkccsConfigurationTblprimitivemaintainancescheduling = new HashSet<UnitworkccsConfigurationTblprimitivemaintainancescheduling>();
            UnitworkccsTbllivemode = new HashSet<UnitworkccsTbllivemode>();
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
        public byte? EnableToolLife { get; set; }
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
        public byte? IsWimerasys { get; set; }
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

        public virtual UnitworkccsTblcell Cell { get; set; }
        public virtual UnitworkccsTblplant Plant { get; set; }
        public virtual UnitworkccsTblshop Shop { get; set; }
        public virtual ICollection<UnitworkccsConfigurationTblprimitivemaintainancescheduling> UnitworkccsConfigurationTblprimitivemaintainancescheduling { get; set; }
        public virtual ICollection<UnitworkccsTbllivemode> UnitworkccsTbllivemode { get; set; }
    }
}
