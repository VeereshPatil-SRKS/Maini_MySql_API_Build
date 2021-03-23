using System;
using System.Collections.Generic;
using System.Text;

namespace IFacilityMaini.EntityModels
{
    public class AllMainMastersEntity
    {
        #region 1) Plant Master
        public class addPlantDet
        {

            public int plantId { get; set; }
            public string plantName { get; set; }
            public string plantCode { get; set; }
            public string plantLocation { get; set; }

        }

        #endregion

        #region 2) Cell Master
        public class addCellDet
        {

            public int cellId { get; set; }
            public int plantId { get; set; }
            public string cellName { get; set; }
        }

        #endregion

        #region 3) SubCell Master
        public class addSubCellDet
        {

            public int subCellId { get; set; }
            public int plantId { get; set; }
            public int cellId { get; set; }
            public string subCellName { get; set; }
        }

        #endregion


        #region 4) Defect code Master
        public class addDefectCodeDet
        {
            public int defectCodeId { get; set; }
            public string defectCodeName { get; set; }
            public string defectCodeDesc { get; set; }

        }

        #endregion

        #region  5) Defect code Master
        public class addCategoryMasterDet
        {

            public int categoryId { get; set; }
            public string categoryName { get; set; }

        }

        #endregion


        #region  6) Roles Master
        public class addRolesDet
        {

            public int roleId { get; set; }
            public string roleName { get; set; }

        }

        #endregion


        #region  7) Business Master
        public class addBusinessDet
        {

            public int businessId { get; set; }
            public string businessName { get; set; }
        }

        #endregion

        #region 8) Department Master
        public class addDepartmentDet
        {

            public int departmentId { get; set; }
            public string departmentName { get; set; }
        }

        #endregion

        #region  9) Employee Category Master
        public class addEmpCategoryDet
        {

            public int categoryId { get; set; }
            public string categoryName { get; set; }
        }

        #endregion





        #region 10) Machine Category Master
        public class addMacCatDet
        {
            public int machineCategoryId { get; set; }
            public string machineCategoryName { get; set; }
        }

        #endregion


        #region 11) Machine Make Master
        public class addMacMakeDet
        {

            public int makeId { get; set; }
            public string makeName { get; set; }
            public int machineCategoryId { get; set; }


        }

        #endregion


        #region 12)  No Of Axis Master
        public class addAxisDet
        {

            public int noOfAxisId { get; set; }
            public int noOfAxis { get; set; }


        }

        #endregion



        #region 13) Fall Stock Availability Master
        public class addFallStockDet
        {
            public int tallStockAvailId { get; set; }
            public string tallStockAvailName { get; set; }
        }

        #endregion

        #region 14) Pallet Master
        public class addPalletDet
        {
            public int palletId { get; set; }
            public string palletName { get; set; }
        }

        #endregion
    }
}
