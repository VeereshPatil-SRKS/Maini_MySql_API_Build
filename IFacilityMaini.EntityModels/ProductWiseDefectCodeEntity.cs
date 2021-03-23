using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class ProductWiseDefectCodeEntity
    {
        public class AddEditProuctWiseDefectCodes
        {
            public int productWiseDefectCodeId { get; set; }
            public int trim { get; set; }
            public int plantId { get; set; }
            public string partNo { get; set; }
            public int defectCodeId { get; set; }
            public string partName { get; set; }
        }

        public class AddDefectCodes
        {
            public string defectCodeName { get; set; }
            public string defectCodeDesc { get; set; }
        }

        public class UploadProuctWiseDefectCodes
        {
            public int productWiseDefectCodeId { get; set; }
            public int trim { get; set; }
            public string plantCode { get; set; }
            public string partNo { get; set; }
            public string defectCode { get; set; }
            public string partName { get; set; }
            public string defectDescription { get; set; }
        }
    }
}
