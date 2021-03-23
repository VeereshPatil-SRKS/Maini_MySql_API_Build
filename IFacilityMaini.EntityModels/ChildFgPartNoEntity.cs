using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class ChildFgPartNoEntity
    {
        public class UploadChildPartNo
        {
            public string childFgPartNo { get; set; }
            public string childPartNoDesc { get; set; }
            public string fgPartNo { get; set; }
            public string fgPartDesc { get; set; }
        }

        public class CustomChildPartNo
        {
            public int childFgPartId { get; set; }
            public string childFgPartNo { get; set; }
            public string childPartNoDesc { get; set; }
            public string fgPartNo { get; set; }
            public string fgPartDesc { get; set; }
        }
    }
}
