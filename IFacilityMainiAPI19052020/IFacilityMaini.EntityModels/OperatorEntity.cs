using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class OperatorEntity
    {
        public class AddUpdateOperator
        {
            public int opId { get; set; }
            public string employeeName { get; set; }
            public int opNo { get; set; }
            public int cellFinalId { get; set; }
            public int subCellFinalId { get; set; }
            public string conatctNo { get; set; }
            public int machineId { get; set; }
            public int roleId { get; set; }
            public int categoryId { get; set; }
            public int shiftId { get; set; }
            public string subCell { get; set; }
            public string cell { get; set; }
            public string role { get; set; }
            public string category { get; set; }
            public string shift { get; set; }
            public string machineName { get; set; }
        }
    }
}
