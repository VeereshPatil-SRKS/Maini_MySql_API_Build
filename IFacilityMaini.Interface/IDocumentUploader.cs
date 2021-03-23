using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.DocumentUploaderEntity;

namespace IFacilityMaini.Interface
{
    public interface IDocumentUploader
    {
        CommonResponseWithIdsDoc AddAndEditDocumentUploader(DocumentUplodedMasterCustom documentDetails);

        CommonResponseWithIdsDoc AddAndEditDocumentUploaderBase64(DocumentUplodedMasterCustomBase64 documentDetails);


    }
}
