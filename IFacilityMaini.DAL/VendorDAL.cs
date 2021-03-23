using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.EntityModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.DAL
{
    public class VendorDAL : IVendor
    {
        unitworksccsContext db = new unitworksccsContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(VendorDAL));
        public static IConfiguration configuration;
        private readonly AppSettings appSettings;

        public VendorDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// AddUpdateVendorDetails
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddUpdateVendorDetails(VendorEntity data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblvendor.Where(m => m.VendorId == data.vendorId && m.IsDeleted == 0).FirstOrDefault();
                if (check == null)
                {
                    UnitworkccsTblvendor UnitworkccsTblvendordet = new UnitworkccsTblvendor();
                    UnitworkccsTblvendordet.Vendor = data.vendor;
                    UnitworkccsTblvendordet.VendorName = data.vendorName;
                    UnitworkccsTblvendordet.IsDeleted = 0;
                    UnitworkccsTblvendordet.CreatedOn = DateTime.Now;
                    UnitworkccsTblvendordet.CreatedBy = 1;
                    db.UnitworkccsTblvendor.Add(UnitworkccsTblvendordet);
                    db.SaveChanges();

                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                }
                else
                {
                    check.Vendor = data.vendor;
                    check.VendorName = data.vendorName;
                    check.ModifiedBy = 2;
                    check.ModifiedOn = DateTime.Now;
                    db.SaveChanges();

                    obj.isStatus = true;
                    obj.response = ResourceResponse.UpdatedSuccessMessage;

                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// ViewMultipleVendorDetails
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleVendorDetails()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblvendor
                             where wf.IsDeleted == 0
                             select new
                             {
                                 vendorId = wf.VendorId,
                                 vendor = wf.Vendor,
                                 vendorName = wf.VendorName
                             }).ToList();


                if (check.Count > 0)
                {

                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "No Items Found";
                }

            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// ViewMultipleVendorDetailsById
        /// </summary>
        /// <param name="vendorId"></param>
        /// <returns></returns>

        public CommonResponse ViewMultipleVendorDetailsById(int vendorId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblvendor
                             where wf.IsDeleted == 0 && wf.VendorId == vendorId
                             select new
                             {
                                 vendorId = wf.VendorId,
                                 vendor = wf.Vendor,
                                 vendorName = wf.VendorName
                             }).ToList();


                if (check.Count > 0)
                {

                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = "No Items Found";
                }

            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// DeleteVendorDetails
        /// </summary>
        /// <param name="vendorId"></param>
        /// <returns></returns>

        public CommonResponse DeleteVendorDetails(int vendorId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblvendor.Where(m => m.VendorId == vendorId && m.IsDeleted == 0).FirstOrDefault();
                if (check != null)
                {
                    check.IsDeleted = 1;
                    check.ModifiedBy = 3;
                    check.ModifiedOn = DateTime.Now;
                    db.SaveChanges();

                    obj.isStatus = true;
                    obj.response = ResourceResponse.DeletedSuccessMessage;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }





        /// <summary>
        /// Upload Vendor Details
        /// </summary>
        /// <param name = "data" ></ param >
        /// < returns ></ returns >
        public CommonResponse UploadVendorDetails(List<VendorEntity> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblvendor.Where(m => m.IsDeleted == 0).ToList();
                db.UnitworkccsTblvendor.RemoveRange(check);
                db.SaveChanges();

                foreach (var item in data)
                {
                    UnitworkccsTblvendor UnitworkccsTblvendor = new UnitworkccsTblvendor();
                    UnitworkccsTblvendor.Vendor = item.vendor;
                    UnitworkccsTblvendor.VendorName = item.vendorName;
                    UnitworkccsTblvendor.IsDeleted = 0;
                    UnitworkccsTblvendor.CreatedOn = DateTime.Now;
                    db.UnitworkccsTblvendor.Add(UnitworkccsTblvendor);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }

        /// <summary>
        /// View Vendor Details
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewVendorDetails()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblvendor
                             where wf.IsDeleted == 0
                             select new
                             {
                                 vendor = wf.Vendor,
                                 vendorId = wf.VendorId,
                                 vendorName = wf.VendorName
                             }).ToList();
                if (check.Count > 0)
                {
                    obj.isStatus = true;
                    obj.response = check;
                }
                else
                {
                    obj.isStatus = false;
                    obj.response = ResourceResponse.NoItemsFound;
                }
            }
            catch (Exception e)
            {
                log.Error(e); if (e.InnerException != null) { log.Error(e.InnerException.ToString()); }
                obj.isStatus = false;
                obj.response = ResourceResponse.FailureMessage;
            }
            return obj;
        }
    }
}
