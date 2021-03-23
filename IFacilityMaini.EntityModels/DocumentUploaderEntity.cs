using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class DocumentUploaderEntity
    {
        public class CommonResponseWithIdsDoc
        {
            public bool isStatus { get; set; }
            public dynamic response { get; set; }
            public dynamic id { get; set; }
            public dynamic url { get; set; }
        }

        public class DocumentUplodedMasterCustom
        {
            public int documentUploaderId { get; set; }
            public IFormFile Image { get; set; }

        }

        public class DocumentUplodedMasterCustomBase64
        {
            public int documentUploaderId { get; set; }
            public string base64Image { get; set; }
            public string uploadedFileName { get; set; }
            public string DocumentUploadedFor { get; set; }
        }


    }
}
