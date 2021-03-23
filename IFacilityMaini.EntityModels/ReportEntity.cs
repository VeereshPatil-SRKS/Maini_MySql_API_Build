using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class ReportEntity
    {

        public class OEEdetails
        {
            public string fromDate { get; set; }
            public string toDate { get; set; }
            public int plantId { get; set; }
            public string category { get; set; }
            public string machineIds { get; set; }
        }

        public class OEEdetailsShiftwise
        {
            public string fromDate { get; set; }
            public string toDate { get; set; }
            public int plantId { get; set; }
            public string category { get; set; }
            public string machineIds { get; set; }
            public string shift { get; set; }

        }



        public class OEEdetailsOperator
        {
            public string fromDate { get; set; }
            public string toDate { get; set; }
            public int plantId { get; set; }
            public string operatorId { get; set; }
            public string machineIds { get; set; } 

        }

        public class machinelist
        {
            
            public int machineId { get; set; }
            public string machineName { get; set; }

        }

        public class OEECalModel
        {
            public decimal OperatingTime { get; set; }
            public decimal LossTime { get; set; }
            public decimal MinorLossTime { get; set; }
            public decimal MntTime { get; set; }
            public decimal SetupTime { get; set; }
            public decimal SetupMinorTime { get; set; }
            public decimal PowerOffTime { get; set; }
            public decimal PowerONTime { get; set; }
        }


        public class machinedet
        {
            public int machineId { get; set; }
            public string machineName { get; set; }
           
        }

        public class breakdownReportDet
        {
            public string fromDate { get; set; }
            public string toDate { get; set; }
            public int plantId { get; set; }
            public string category { get; set; }
            public string machineIds { get; set; }
        }

    }
}
