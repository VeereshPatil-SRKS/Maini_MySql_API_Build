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
            public string reasonForRejection { get; set; }
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
            public string reasonForRework { get; set; }
        }

        public class addedResopnse
        {
            public int cellId { get; set; }
            public string cellName { get; set; }
            public string date { get; set; }
            public string defectCode { get; set; }

            public int defectCodeId { get; set; }
            public string defectDescription { get; set; }
            public int employeeNo { get; set; }
            public int fgPartId { get; set; }
            public string isRejectionOrRework { get; set; }
            public int machineId { get; set; }
            public string machineName { get; set; }
            public int operatorId { get; set; }
            public string operatorName { get; set; }
            public string partDescription { get; set; }
            public int? partId { get; set; }
            public string partNumber { get; set; }
            public string partQrCode { get; set; }
            public int plantId { get; set; }
            public string plantName { get; set; }
            public int quantity { get; set; }
            public int rejectionId { get; set; }
            public int reworkId { get; set; }
            public string shift { get; set; }
            public int subCellId { get; set; }
            public string subCellName { get; set; }
            public string updatedRejectionOrRework { get; set; }
            public string workorderNumber { get; set; }
            public string reasonForRejection { get; set; }
            public string reasonForRework { get; set; }
        }
    }
}
