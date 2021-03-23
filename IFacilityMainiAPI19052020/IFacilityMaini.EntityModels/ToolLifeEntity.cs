using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class ToolLifeEntity
    {
        public class TblToolAndSocketDetailsCustom
        {
            public int socketId { get; set; }
            public string toolNumber { get; set; }
            public string socketNo { get; set; }
            public int? machineId { get; set; }
        }

        public partial class TblToolAndSocket
        {
            public int socketId { get; set; }
            public string toolNumber { get; set; }
            public string socketNo { get; set; }
            public int? machineId { get; set; }
            public int? standardToolLife { get; set; }
            public int? actaulToolLife { get; set; }
            public int? balance { get; set; }
            public string qrcode { get; set; }
        }
    }
}
