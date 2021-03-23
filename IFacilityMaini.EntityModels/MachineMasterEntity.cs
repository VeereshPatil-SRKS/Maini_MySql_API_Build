using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class MachineMasterEntity
    {
        public class AddUpdateMachine
        {
            public int machineId { get; set; }
            public int plantId { get; set; }
            public int shopId { get; set; }
            public int cellId { get; set; }
            public string machineNo { get; set; }
            public string machineName { get; set; }
            public string mmmGroup { get; set; }
            public string dedicatedOrShared { get; set; }
            public int machineCategoryId { get; set; }
            public string makeId { get; set; }
            public string primaryOrSecondary { get; set; }
            public string machineSpec { get; set; }
            public string chuckOrRodSize { get; set; }
            public string noOfToolStation { get; set; }
            public string tallStockAvailibilityId { get; set; }
            public string noOfAxisId { get; set; }
            public string tableSize { get; set; }
            public string palletId { get; set; }
            public string criticalOrNonCritical { get; set; }
            public string ipAddress { get; set; }
            public string machineBelongTo { get; set; }
            public string controllerType { get; set; }
        }

        public class UploadMachine
        {
            public string plantNo { get; set; }
            public string cellName { get; set; }
            public string subCellName { get; set; }
            public string machineNo { get; set; }
            public string mmmGroup { get; set; }
            public string machineName { get; set; }
            public string machineMake { get; set; }
            public string dedicatedOrShared { get; set; }
            public string machineCategory { get; set; }
            public string primaryOrSecondary { get; set; }
            public string machineSpec { get; set; }
            public int chuckOrRodSize { get; set; }
            public int noOfToolStation { get; set; }
            public string tallStockAvailibility { get; set; }
            public int? noOfAxis { get; set; }
            public string tableSize { get; set; }
            public string pallet { get; set; }
            public string criticalOrNonCritical { get; set; }
            public string ipAddress { get; set; }
            public string machineBelongTo { get; set; }
            public string controllerType { get; set; }
        }

        public class ViewMachineMaster
        {
            public int machineId { get; set; }
            public string machineNo { get; set; }
            public string machineName { get; set; }
            public int? noOfToolStation { get; set; }
            public string machineDescription { get; set; }
            public string machineDisplayName { get; set; }
            public int? plantId { get; set; }
            public string plantCode { get; set; }
            public int? cellId { get; set; }
            public string cellName { get; set; }
            public int? subCellId { get; set; }
            public string subCellName { get; set; }
            public string ipaddress { get; set; }
            public bool? isWimerasys { get; set; }
            public string controllerType { get; set; }
            public int? isPcb { get; set; }
            public string criticalOrNonCritical { get; set; }
            public string mmmGroup { get; set; }
            public string dedicatedOrShared { get; set; }
            public string primaryOrSecondary { get; set; }
            public int? machineCategoryId { get; set; }
            public string machineCategoryName { get; set; }
            public string makeId { get; set; }
            public string makeName { get; set; }
            public string machineSpec { get; set; }
            public int? chuckOrRodSize { get; set; }
            public string tallStockAvailibilityId { get; set; }
            public string tallStockAvailibility { get; set; }
            public string noOfAxisId { get; set; }
            public int? noOfAxisName { get; set; }
            public string tableSize { get; set; }
            public string palletId { get; set; }
            public string palletName { get; set; }
        }
    }
}
