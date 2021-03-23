using IFacilityMaini.DAL.Helpers;
using IFacilityMaini.DAL.Resource;
using IFacilityMaini.DBModels;
using IFacilityMaini.Interface;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static IFacilityMaini.EntityModels.DocumentUploaderEntity;

namespace IFacilityMaini.DAL
{
    public class DocumentUploaderDAL : IDocumentUploader
    {

        unitworksccsContext db = new unitworksccsContext();
        private readonly AppSettings appSettings;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(DocumentUploaderDAL));
        public DocumentUploaderDAL(unitworksccsContext _db, IOptions<AppSettings> _appSettings)
        {
            db = _db;
            appSettings = _appSettings.Value;
        }

        /// <summary>
        /// Add And Edit Document Uploader
        /// </summary>
        /// <param name="documentDetails"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public CommonResponseWithIdsDoc AddAndEditDocumentUploader(DocumentUplodedMasterCustom documentDetails)
        {
            CommonResponseWithIdsDoc response = new CommonResponseWithIdsDoc();

            string fileName = "";


            if (documentDetails.Image != null)
            {
                try
                {
                    string extensionFile = documentDetails.Image.FileName;
                    string[] fileArray = extensionFile.Split('.');
                    try
                    {
                        extensionFile = fileArray[1];
                    }
                    catch
                    {
                        extensionFile = "jpeg";
                    }
                    fileName = Guid.NewGuid().ToString() + "." + extensionFile;


                    #region save file

                    var path = Path.Combine(appSettings.ImageUrlSave, fileName);
                    bool exists = System.IO.File.Exists(path);
                    // Getting Image
                    var image = documentDetails.Image;

                    try
                    {

                        if (!exists)
                        {
                            if (image.Length > 0)
                            {
                                using (var fileStream = new FileStream(path, FileMode.Create))
                                {
                                    image.CopyTo(fileStream);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }
                    }


                    #endregion

                    #region save file details in DB

                    var dbItem = db.UnitworkccsDocumentuploadermaster.Where(m => m.DocumnetUploaderId == documentDetails.documentUploaderId && m.Isdeleted == 0 && m.Isactive == 1).FirstOrDefault();
                    if (dbItem == null)
                    {
                        #region insert item into DB
                        UnitworkccsDocumentuploadermaster documentUplodedMaster = new UnitworkccsDocumentuploadermaster();
                        documentUplodedMaster.DocumentName = documentDetails.Image.FileName;
                        documentUplodedMaster.FileName = fileName;
                        documentUplodedMaster.FilePath = path;
                        documentUplodedMaster.CreatedOn = DateTime.Now;
                        documentUplodedMaster.CreatedBy = 0;
                        documentUplodedMaster.Isdeleted = 0;
                        documentUplodedMaster.Isactive = 1;
                        // documentUplodedMaster.DocumnetUploaderFor = documentDetails.DocumentUploadedFor;
                        db.UnitworkccsDocumentuploadermaster.Add(documentUplodedMaster);
                        db.SaveChanges();

                        response.id = documentUplodedMaster.DocumnetUploaderId;
                        var doc = appSettings.ImageUrl +
                                  (from wfd in db.UnitworkccsDocumentuploadermaster
                                   where wfd.Isdeleted == 0 && wfd.DocumnetUploaderId == documentUplodedMaster.DocumnetUploaderId
                                   select wfd.FileName).FirstOrDefault();
                        response.url = doc;

                        #endregion
                    }
                    else
                    {
                        #region delete old files
                        try
                        {
                            var deleteFileName = Path.Combine(appSettings.ImageUrlSave, dbItem.FileName);
                            if (deleteFileName != null || deleteFileName != string.Empty)
                            {
                                if ((System.IO.File.Exists(deleteFileName)))
                                {
                                    System.IO.File.Delete(deleteFileName);
                                }

                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        #endregion

                        #region update into DB
                        dbItem.FileName = fileName;
                        dbItem.DocumentName = documentDetails.Image.FileName;
                        //  dbItem.DocumnetUploaderFor = documentDetails.DocumentUploadedFor;
                        dbItem.FilePath = path;
                        dbItem.ModifiedOn = DateTime.Now;
                        dbItem.ModifiedBy = 0;
                        db.SaveChanges();
                        response.id = documentDetails.documentUploaderId;
                        var doc = appSettings.ImageUrl +
                                (from wfd in db.UnitworkccsDocumentuploadermaster
                                 where wfd.Isdeleted == 0 && wfd.DocumnetUploaderId == dbItem.DocumnetUploaderId
                                 select wfd.FileName).FirstOrDefault();
                        response.url = doc;
                        #endregion
                    }

                    #endregion
                }
                catch (Exception ex)
                {
                    log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }
                    response.isStatus = false;
                    response.response = ResourceResponse.ExceptionMessage;
                }
                response.isStatus = true;
                response.response = ResourceResponse.FileUploaderSuccess;
            }
            else
            {
                response.isStatus = false;
                response.response = ResourceResponse.FileUploaderFailure;
            }
            return response;
        }

        /// <summary>
        /// Add And Edit Document Uploader Base64
        /// </summary>
        /// <param name="documentDetails"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// 

        public CommonResponseWithIdsDoc AddAndEditDocumentUploaderBase64(DocumentUplodedMasterCustomBase64 documentDetails)
        {
            CommonResponseWithIdsDoc response = new CommonResponseWithIdsDoc();

            string fileName = "";
            if (documentDetails.base64Image != null)
            {
                try
                {
                    string extensionFile = documentDetails.uploadedFileName;
                    string[] fileArray = extensionFile.Split('.');
                    try
                    {
                        extensionFile = fileArray[1];
                    }
                    catch
                    {
                        extensionFile = "jpeg";
                    }
                    fileName = Guid.NewGuid().ToString() + "." + extensionFile;


                    #region save file

                    var path = Path.Combine(appSettings.ImageUrlSave, fileName);
                    bool exists = System.IO.File.Exists(path);
                    // Getting Image
                    var image = documentDetails.base64Image.Split(',');

                    try
                    {

                        if (!exists)
                        {
                            if (image[1].Length > 0)
                            {
                                byte[] imgByteArray = Convert.FromBase64String(image[1]);
                                File.WriteAllBytes(path, imgByteArray);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }

                        response.isStatus = false;
                        response.response = ResourceResponse.ExceptionMessage;

                    }

                    #endregion

                    #region save file details in DB

                    var dbItem = db.UnitworkccsDocumentuploadermaster.Where(m => m.DocumnetUploaderId == documentDetails.documentUploaderId && m.Isdeleted == 0 && m.Isactive == 1).FirstOrDefault();
                    if (dbItem == null)
                    {
                        #region insert item into DB
                        UnitworkccsDocumentuploadermaster documentUplodedMaster = new UnitworkccsDocumentuploadermaster();
                        documentUplodedMaster.DocumentName = documentDetails.uploadedFileName;
                        documentUplodedMaster.FileName = fileName;
                        documentUplodedMaster.FilePath = path;

                        documentUplodedMaster.CreatedOn = DateTime.Now;
                        documentUplodedMaster.CreatedBy = 0;
                        documentUplodedMaster.Isdeleted = 0;
                        documentUplodedMaster.Isactive = 1;
                        documentUplodedMaster.DocumnetUploaderFor = documentDetails.DocumentUploadedFor;
                        db.UnitworkccsDocumentuploadermaster.Add(documentUplodedMaster);
                        db.SaveChanges();
                        response.id = documentUplodedMaster.DocumnetUploaderId;
                        var doc = appSettings.ImageUrl +
                                 (from wfd in db.UnitworkccsDocumentuploadermaster
                                  where wfd.Isdeleted == 0 && wfd.DocumnetUploaderId == documentUplodedMaster.DocumnetUploaderId
                                  select wfd.FileName).FirstOrDefault();
                        response.url = doc;
                        #endregion
                    }
                    else
                    {
                        #region delete old files
                        try
                        {
                            var deleteFileName = Path.Combine(appSettings.ImageUrlSave, dbItem.FileName);
                            if (deleteFileName != null || deleteFileName != string.Empty)
                            {
                                if ((System.IO.File.Exists(deleteFileName)))
                                {
                                    System.IO.File.Delete(deleteFileName);
                                }

                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        #endregion

                        #region update into DB
                        dbItem.FileName = fileName;
                        dbItem.DocumentName = documentDetails.uploadedFileName;
                        dbItem.DocumnetUploaderFor = documentDetails.DocumentUploadedFor;
                        dbItem.FilePath = path;
                        dbItem.ModifiedOn = DateTime.Now;
                        dbItem.ModifiedBy = 0;
                        db.SaveChanges();
                        response.id = documentDetails.documentUploaderId;
                        var doc = appSettings.ImageUrl +
                                 (from wfd in db.UnitworkccsDocumentuploadermaster
                                  where wfd.Isdeleted == 0 && wfd.DocumnetUploaderId == documentDetails.documentUploaderId
                                  select wfd.FileName).FirstOrDefault();
                        response.url = doc;
                        #endregion
                    }

                    #endregion
                }
                catch (Exception ex)
                {
                    log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }
                    response.isStatus = false;
                    response.response = ResourceResponse.ExceptionMessage;
                }
                response.isStatus = true;
                response.response = ResourceResponse.FileUploaderSuccess;
            }
            else
            {
                response.isStatus = false;
                response.response = ResourceResponse.FileUploaderFailure;
            }
            return response;
        }






        //public CommonResponseWithIdsDoc AddAndEditDocumentUploaderBase64(DocumentUplodedMasterCustomBase64 documentDetails, long userId)
        //{
        //    CommonResponseWithIdsDoc response = new CommonResponseWithIdsDoc();

        //    string fileName = "";


        //    if (documentDetails.base64Image != null)
        //    {
        //        try
        //        {
        //            string extensionFile = documentDetails.uploadedFileName;
        //            string[] fileArray = extensionFile.Split('.');
        //            try
        //            {
        //                extensionFile = fileArray[1];
        //            }
        //            catch
        //            {
        //                extensionFile = "jpeg";
        //            }
        //            fileName = Guid.NewGuid().ToString() + "." + extensionFile;


        //            #region save file

        //            var path = Path.Combine(appSettings.ImageUrlSave, fileName);
        //            bool exists = System.IO.File.Exists(path);
        //            // Getting Image
        //            var image = documentDetails.base64Image.Split(',');

        //            try
        //            {

        //                if (!exists)
        //                {
        //                    if (image[1].Length > 0)
        //                    {
        //                        byte[] imgByteArray = Convert.FromBase64String(image[1]);
        //                        File.WriteAllBytes(path, imgByteArray);
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }
        //            }

        //            #endregion

        //            #region save file details in DB

        //            var dbItem = db.UnitworkccsDocumentuploadermaster.Where(m => m.DocumnetUploaderId == documentDetails.documentUploaderId && m.Isdeleted == 0 && m.Isactive == 1).FirstOrDefault();
        //            if (dbItem == null)
        //            {
        //                #region insert item into DB
        //                UnitworkccsDocumentuploadermaster documentUplodedMaster = new UnitworkccsDocumentuploadermaster();
        //                documentUplodedMaster.DocumentName = documentDetails.uploadedFileName;
        //                documentUplodedMaster.FileName = fileName;
        //                documentUplodedMaster.FilePath = path;

        //                documentUplodedMaster.CreatedOn = DateTime.Now;
        //                documentUplodedMaster.CreatedBy = 0;
        //                documentUplodedMaster.Isdeleted = 0;
        //                documentUplodedMaster.Isactive = 1;
        //                documentUplodedMaster.DocumnetUploaderFor = documentDetails.DocumentUploadedFor;
        //                db.UnitworkccsDocumentuploadermaster.Add(documentUplodedMaster);
        //                db.SaveChanges();
        //                response.id = documentUplodedMaster.DocumnetUploaderId;
        //                var doc = appSettings.ImageUrl +
        //                         (from wfd in db.UnitworkccsDocumentuploadermaster
        //                          where wfd.Isdeleted == 0 && wfd.DocumnetUploaderId == documentUplodedMaster.DocumnetUploaderId
        //                          select wfd.FileName).FirstOrDefault();
        //                response.url = doc;
        //                #endregion
        //            }
        //            else
        //            {
        //                #region delete old files
        //                try
        //                {
        //                    var deleteFileName = Path.Combine(appSettings.ImageUrlSave, dbItem.FileName);
        //                    if (deleteFileName != null || deleteFileName != string.Empty)
        //                    {
        //                        if ((System.IO.File.Exists(deleteFileName)))
        //                        {
        //                            System.IO.File.Delete(deleteFileName);
        //                        }

        //                    }
        //                }
        //                catch (Exception ex)
        //                {

        //                }
        //                #endregion

        //                #region update into DB
        //                dbItem.FileName = fileName;
        //                dbItem.DocumentName = documentDetails.uploadedFileName;
        //                dbItem.DocumnetUploaderFor = documentDetails.DocumentUploadedFor;
        //                dbItem.FilePath = path;
        //                dbItem.ModifiedOn = DateTime.Now;
        //                dbItem.ModifiedBy = 0;
        //                db.SaveChanges();
        //                response.id = documentDetails.documentUploaderId;
        //                var doc = appSettings.ImageUrl +
        //                         (from wfd in db.UnitworkccsDocumentuploadermaster
        //                          where wfd.Isdeleted == 0 && wfd.DocumnetUploaderId == documentDetails.documentUploaderId
        //                          select wfd.FileName).FirstOrDefault();
        //                response.url = doc;
        //                #endregion
        //            }

        //            #endregion
        //        }
        //        catch (Exception ex)
        //        {
        //            log.Error(ex); if (ex.InnerException != null) { log.Error(ex.InnerException.ToString()); }
        //            response.isStatus = false;
        //            response.response = ResourceResponse.ExceptionMessage;
        //        }
        //        response.isStatus = true;
        //        response.response = ResourceResponse.FileUploaderSuccess;
        //    }
        //    else
        //    {
        //        response.isStatus = false;
        //        response.response = ResourceResponse.FileUploaderFailure;
        //    }
        //    return response;
        //}
    }
}
