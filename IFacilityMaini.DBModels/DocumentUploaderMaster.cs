using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class DocumentUploaderMaster
    {
        public int DocumnetUploaderId { get; set; }
        public string DocumentName { get; set; }
        public int? Did { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int Isdeleted { get; set; }
        public int Isactive { get; set; }
        public string DocumnetUploaderFor { get; set; }
        public string PictureName { get; set; }
        public string PicturePath { get; set; }
    }
}
