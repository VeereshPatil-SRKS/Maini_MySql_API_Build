using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class ReworkAndRejectionEntity
    {
        public class AddRejection
        {
            public int rejectionId { get; set; }
            public int fgPartId { get; set; }
            public int defectCodeId { get; set; }
            public int machineId { get; set; }
            public int operatorId { get; set; }
            public int actual { get; set; }
            public string qrCodeNo { get; set; }
            public string dmcCodeStatus { get; set; }
            public int defectQty { get; set; }
        }

        public class AddRework
        {
            public int reworkId { get; set; }
            public int fgPartId { get; set; }
            public int defectCodeId { get; set; }
            public int machineId { get; set; }
            public int operatorId { get; set; }
            public int actual { get; set; }
            public string qrCodeNo { get; set; }
            public string dmcCodeStatus { get; set; }
            public int defectQty { get; set; }
        }
    }
}
