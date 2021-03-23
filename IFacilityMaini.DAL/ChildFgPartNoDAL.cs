using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.ChildFgPartNoEntity;
using static IFacilityMaini.EntityModels.CommonEntity;

namespace IFacilityMaini.DAL
{
    public class ChildFgPartNoDAL : IChildFgPartNo
    {
        unitworksccsContext db = new unitworksccsContext();
        private readonly AppSettings appSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ChildFgPartNoDAL));
        public static IConfiguration configuration;

        public ChildFgPartNoDAL(unitworksccsContext _db, IConfiguration _configuration, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            configuration = _configuration;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// Upload Child Fg Part No
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse UploadChildFgPartNo(List<UploadChildPartNo> data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblchildfgpartno.Where(m => m.IsDeleted == 0).ToList();
                db.RemoveRange(check);
                db.SaveChanges();

                foreach (var item in data)
                {
                    UnitworkccsTblchildfgpartno UnitworkccsTblchildfgpartno = new UnitworkccsTblchildfgpartno();
                    UnitworkccsTblchildfgpartno.ChildFgPartNo = item.childFgPartNo;
                    UnitworkccsTblchildfgpartno.ChildPartNoDesc = item.childPartNoDesc;
                    UnitworkccsTblchildfgpartno.FgPartNo = item.fgPartNo;
                    UnitworkccsTblchildfgpartno.FgPartDesc = item.fgPartDesc;
                    UnitworkccsTblchildfgpartno.IsDeleted = 0;
                    UnitworkccsTblchildfgpartno.CreatedOn = DateTime.Now;
                    db.UnitworkccsTblchildfgpartno.Add(UnitworkccsTblchildfgpartno);
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
        /// Add Child Fg Part No
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public CommonResponse AddChildFgPartNo(CustomChildPartNo data)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblchildfgpartno.Where(m => m.ChildFgpartId == data.childFgPartId && m.IsDeleted == 0).FirstOrDefault();
                if(check == null)
                {
                    UnitworkccsTblchildfgpartno UnitworkccsTblchildfgpartno = new UnitworkccsTblchildfgpartno();
                    UnitworkccsTblchildfgpartno.ChildFgPartNo = data.childFgPartNo;
                    UnitworkccsTblchildfgpartno.ChildPartNoDesc = data.childPartNoDesc;
                    UnitworkccsTblchildfgpartno.FgPartNo = data.fgPartNo;
                    UnitworkccsTblchildfgpartno.FgPartDesc = data.fgPartDesc;
                    UnitworkccsTblchildfgpartno.IsDeleted = 0;
                    UnitworkccsTblchildfgpartno.CreatedOn = DateTime.Now;
                    db.UnitworkccsTblchildfgpartno.Add(UnitworkccsTblchildfgpartno);
                    db.SaveChanges();
                    obj.isStatus = true;
                    obj.response = ResourceResponse.AddedSuccessMessage;
                }
                else
                {
                    check.ChildFgPartNo = data.childFgPartNo;
                    check.ChildPartNoDesc = data.childPartNoDesc;
                    check.FgPartNo = data.fgPartNo;
                    check.FgPartDesc = data.fgPartDesc;
                    check.IsDeleted = 0;
                    check.CreatedOn = DateTime.Now;
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
        /// View Multiple Child Fg Part No
        /// </summary>
        /// <returns></returns>
        public CommonResponse ViewMultipleChildFgPartNo()
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = (from wf in db.UnitworkccsTblchildfgpartno
                             where wf.IsDeleted == 0
                             select new
                             {
                                 childFgpartId = wf.ChildFgpartId,
                                 childFgPartNo = wf.ChildFgPartNo,
                                 childPartNoDesc = wf.ChildPartNoDesc,
                                 fgPartNo = wf.FgPartNo,
                                 fgPartDesc = wf.FgPartDesc
                             }).ToList();

                if(check.Count > 0)
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

        /// <summary>
        /// Delete Child Fg Part No
        /// </summary>
        /// <param name="childFgPartId"></param>
        /// <returns></returns>
        public CommonResponse DeleteChildFgPartNo(int childFgPartId)
        {
            CommonResponse obj = new CommonResponse();
            try
            {
                var check = db.UnitworkccsTblchildfgpartno.Where(m => m.ChildFgpartId == childFgPartId && m.IsDeleted == 0).FirstOrDefault();
                if (check != null)
                {
                    check.IsDeleted = 1;
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
    }
}
