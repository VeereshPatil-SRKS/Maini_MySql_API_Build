using System;
using System.Collections.Generic;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;
using static IFacilityMaini.EntityModels.EscationMatrixEntity;

namespace IFacilityMaini.Interface
{
    public interface IEscationMatrix
    {
        CommonResponse UploadEscalationMatrixDetails(List<EscalationMatrixDetails> data);
        CommonResponse AddAndEditEscalationMatrix(EscalationMatrixCustom data);
        CommonResponse ViewMultipleEscalationMatrix();
        CommonResponse ViewEscalationMatrixById(long escalationId);
        CommonResponse DeleteEscalationMatrix(long escalationId);
        //  CommonResponse ViewMultipleRoles();

        CommonResponse ViewMultipleOperatorDetails();
        CommonResponse ViewMultipleCategory();
        //  CommonResponse ViewMultiplePlants();
        CommonResponse ViewMultipleCell();
        CommonResponse ViewMultipleSubcell(string cellId);

        CommonResponse ViewMultipleShift();
        CommonResponse DownloadEscalationMatrixDetails();
        //   CommonResponse ViewMultipleMachinename(int cellId, int subCellId);
    }
}
