using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class LoginEntity
    {
        public class LoginTrackerdetails
        {
            public string userName { get; set; }
            public string password { get; set; }
            public int machineId { get; set; }
            public string pageName { get; set; }
        }

        public class LoginOperatorDet
        {
            public string operatorName { get; set; }
            public int opId { get; set; }
            public int? roleId { get; set; }
            public string shift { get; set; }
            public string correctedDate { get; set; }
            public string loginTime { get; set; }
            public string machineName { get; set; }
        }
    }
}
