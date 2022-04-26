using Dapper;
using HPCL.DataModel.RBE;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.RBE
{
    public class RBERepository : IRBERepository
    {
        private readonly DapperContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        public RBERepository(DapperContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IEnumerable<ChangeRBEMappingModelOutput>> ChangeRBEMapping([FromBody] ChangeRBEMappingModelInput ObjClass)
        {
            var procedureName = "UspChangeRBEMapping";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ChangeRBEMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ManageRBEUserModelOutput>> ManageRBEUser([FromBody] ManageRBEUserModelInput ObjClass)
        {
            var procedureName = "UspManageRBEUser";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ManageRBEUserModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetPendingRbeConsentModelOutput>> GetPendingRbeConsent([FromBody] GetPendingRbeConsentModelInput ObjClass)
        {
            var procedureName = "UspGetPendingRbeConsent";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetPendingRbeConsentModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RbeSentOtpForgotPasswordModelOutput>> RbeSentOtpForgotPassword([FromBody] RbeSentOtpForgotPasswordModelInput ObjClass)
        {
            var procedureName = "UspRbeSentOtpForgotPassword";
            var parameters = new DynamicParameters();
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RbeSentOtpForgotPasswordModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RbeValidateForgotPasswordModelOutput>> RbeValidateForgotPassword([FromBody] RbeValidateForgotPasswordModelInput ObjClass)
        {
            var procedureName = "UspRbeValidateForgotPassword";
            var parameters = new DynamicParameters();
            parameters.Add("Mobileno", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("NewPassword", ObjClass.NewPassword, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            parameters.Add("DeviceId", ObjClass.DeviceId, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RbeValidateForgotPasswordModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetRbeDashboardModelOutput>> GetRbeDashboard([FromBody] GetRbeDashboardModelInput ObjClass)
        {
            var procedureName = "UspGetRbeDashboard";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetRbeDashboardModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetNewRbeAddCardsModelOutput>> GetNewRbeAddCards([FromBody] GetNewRbeAddCardsModelInput ObjClass)
        {
            var procedureName = "UspGetNewRbeAddCards";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetNewRbeAddCardsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<GetNewRbeEnrollCustomersModelOutput>> GetNewRbeEnrollCustomers([FromBody] GetNewRbeEnrollCustomersModelInput ObjClass)
        {
            var procedureName = "UspGetNewRbeEnrollCustomers";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetNewRbeEnrollCustomersModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RBEGetModelOutput>> GetRBEId([FromBody] RBEGetModelInput ObjClass)
        {
            var procedureName = "UspGetValidRBE";
            var parameters = new DynamicParameters();
            parameters.Add("RBEId", ObjClass.RBEId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RBEGetModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RbeSentOtpNewEnrollCustomerModelOutput>> RbeSentOtpNewEnrollCustomer([FromBody] RbeSentOtpNewEnrollCustomerModelInput ObjClass)
        {
            var procedureName = "UspRbeSentOtpNewEnrollCustomer";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("RBEMobileNo", ObjClass.RBEMobileNo, DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RbeSentOtpNewEnrollCustomerModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RbeValidateOtpNewEnrollCustomerModelOutput>> RbeValidateOtpNewEnrollCustomer([FromBody] RbeValidateOtpNewEnrollCustomerModelInput ObjClass)
        {
            var procedureName = "UspRbeValidateOtpNewEnrollCustomer";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.Mobileno, DbType.String, ParameterDirection.Input);
            parameters.Add("RBEMobileNo", ObjClass.RBEMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            parameters.Add("DeviceId", ObjClass.DeviceId, DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RbeValidateOtpNewEnrollCustomerModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<BindRBEModelOutput>> BindRBEbyRBEId([FromBody] BindRBEModelInput ObjClass)
        {
            var procedureName = "UspBindRBEOfficerDetail";
            var parameters = new DynamicParameters();
            parameters.Add("RBEId", ObjClass.RBEId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<BindRBEModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<InsertRBEModelOutput>> InsertRBE([FromBody] InsertRBEModelInput ObjClass)
        {
            var procedureName = "UspInsertOfficer";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("LastName", ObjClass.LastName, DbType.String, ParameterDirection.Input);
            parameters.Add("UserName", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            parameters.Add("LocationId", ObjClass.LocationId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Address1", ObjClass.Address1, DbType.String, ParameterDirection.Input);
            parameters.Add("Address2", ObjClass.Address2, DbType.String, ParameterDirection.Input);
            parameters.Add("Address3", ObjClass.Address3, DbType.String, ParameterDirection.Input);
            parameters.Add("StateId", ObjClass.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CityName", ObjClass.CityName, DbType.String, ParameterDirection.Input);
            parameters.Add("DistrictId", ObjClass.DistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("PhoneNo", ObjClass.PhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("Fax", ObjClass.Fax, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("OfficerType", ObjClass.OfficerType, DbType.Int32, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("Password", ObjClass.Password, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<InsertRBEModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RBEUpdateModelOutput>> UpdateRBE([FromBody] RBEUpdateModelInput ObjClass)
        {
            var procedureName = "UspUpdateRBEOfficer";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("LastName", ObjClass.LastName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("Password", ObjClass.Password, DbType.String, ParameterDirection.Input);
            parameters.Add("RBEId", ObjClass.RBEId, DbType.String, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("DeviceId", ObjClass.DeviceId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RBEUpdateModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RBEKYCModelOutput>> UploadRBEKYC([Microsoft.AspNetCore.Mvc.FromForm] RBEKYCModelInput ObjClass)
        {

            string FileNamePathIdProofFront = string.Empty;
            var ImageFileNameIdProofFront = ObjClass.IdProofFront;
            if (ImageFileNameIdProofFront.Length > 0)
            {
                IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".png", ".pdf", ".gif", ".jpeg" };
                var ext = ImageFileNameIdProofFront.FileName.Substring(ImageFileNameIdProofFront.FileName.LastIndexOf('.'));
                var extension = ext.ToLower();
                if (AllowedFileExtensions.Contains(extension))
                {

                    string contentRootPath = _hostingEnvironment.ContentRootPath;
                    FileNamePathIdProofFront = "/OfficerKYCImage/" + ObjClass.RBEId + "_" + DateTime.Now.ToString("yyyyMMddHHmmss")
                        + "_" + ObjClass.IdProofType + "_" + ImageFileNameIdProofFront.FileName;
                    string filePathIdProofFront = contentRootPath + FileNamePathIdProofFront;
                    var fileStream = new FileStream(filePathIdProofFront, FileMode.Create);
                    ImageFileNameIdProofFront.CopyTo(fileStream);
                }
            }


            string FileNamePathIdProofBack = string.Empty;
            var ImageFileNameIdProofBack = ObjClass.IdProofBack;
            if (ImageFileNameIdProofBack.Length > 0)
            {
                IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".png", ".pdf", ".gif", ".jpeg" };
                var ext = ImageFileNameIdProofBack.FileName.Substring(ImageFileNameIdProofBack.FileName.LastIndexOf('.'));
                var extension = ext.ToLower();
                if (AllowedFileExtensions.Contains(extension))
                {

                    string contentRootPath = _hostingEnvironment.ContentRootPath;
                    FileNamePathIdProofBack = "/OfficerKYCImage/" + ObjClass.RBEId + "_" + DateTime.Now.ToString("yyyyMMddHHmmss")
                        + "_" + ObjClass.IdProofType + "_" + ImageFileNameIdProofBack.FileName;
                    string filePathIdProofBack = contentRootPath + FileNamePathIdProofBack;
                    var fileStream = new FileStream(filePathIdProofBack, FileMode.Create);
                    ImageFileNameIdProofBack.CopyTo(fileStream);
                }
            }

            string FileNamePathAddressProofFront = string.Empty;
            var ImageFileNameAddressProofFront = ObjClass.AddressProofFront;
            if (ImageFileNameAddressProofFront.Length > 0)
            {
                IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".png", ".pdf", ".gif", ".jpeg" };
                var ext = ImageFileNameAddressProofFront.FileName.Substring(ImageFileNameAddressProofFront.FileName.LastIndexOf('.'));
                var extension = ext.ToLower();
                if (AllowedFileExtensions.Contains(extension))
                {

                    string contentRootPath = _hostingEnvironment.ContentRootPath;
                    FileNamePathAddressProofFront = "/OfficerKYCImage/" + ObjClass.RBEId + "_" + DateTime.Now.ToString("yyyyMMddHHmmss")
                        + "_" + ObjClass.IdProofType + "_" + ImageFileNameAddressProofFront.FileName;
                    string filePathAddressProofFront = contentRootPath + FileNamePathAddressProofFront;
                    var fileStream = new FileStream(filePathAddressProofFront, FileMode.Create);
                    ImageFileNameAddressProofFront.CopyTo(fileStream);
                }
            }


            string FileNamePathAddressProofBack = string.Empty;
            var ImageFileNameAddressProofBack = ObjClass.AddressProofBack;
            if (ImageFileNameAddressProofBack.Length > 0)
            {
                IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".png", ".pdf", ".gif", ".jpeg" };
                var ext = ImageFileNameAddressProofBack.FileName.Substring(ImageFileNameAddressProofBack.FileName.LastIndexOf('.'));
                var extension = ext.ToLower();
                if (AllowedFileExtensions.Contains(extension))
                {

                    string contentRootPath = _hostingEnvironment.ContentRootPath;
                    FileNamePathAddressProofBack = "/OfficerKYCImage/" + ObjClass.RBEId + "_" + DateTime.Now.ToString("yyyyMMddHHmmss")
                        + "_" + ObjClass.IdProofType + "_" + ImageFileNameAddressProofBack.FileName;
                    string filePathAddressProofBack = contentRootPath + FileNamePathAddressProofBack;
                    var fileStream = new FileStream(filePathAddressProofBack, FileMode.Create);
                    ImageFileNameAddressProofBack.CopyTo(fileStream);
                }
            }

            string FileNamePathRBESelfie = string.Empty;
            var ImageFileNamePathRBESelfie = ObjClass.RBESelfie;
            if (ImageFileNamePathRBESelfie.Length > 0)
            {
                IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".png", ".pdf", ".gif", ".jpeg" };
                var ext = ImageFileNamePathRBESelfie.FileName.Substring(ImageFileNamePathRBESelfie.FileName.LastIndexOf('.'));
                var extension = ext.ToLower();
                if (AllowedFileExtensions.Contains(extension))
                {

                    string contentRootPath = _hostingEnvironment.ContentRootPath;
                    FileNamePathRBESelfie = "/OfficerKYCImage/" + ObjClass.RBEId + "_" + DateTime.Now.ToString("yyyyMMddHHmmss")
                        + "_" + ObjClass.IdProofType + "_" + ImageFileNamePathRBESelfie.FileName;
                    string filePathAddressProofBack = contentRootPath + FileNamePathRBESelfie;
                    var fileStream = new FileStream(filePathAddressProofBack, FileMode.Create);
                    ImageFileNamePathRBESelfie.CopyTo(fileStream);
                }
            }


            var parameters = new DynamicParameters();
            parameters.Add("RBEId", ObjClass.RBEId, DbType.String, ParameterDirection.Input);
            parameters.Add("IdProofType", ObjClass.IdProofType, DbType.Int32, ParameterDirection.Input);
            parameters.Add("IdProofDocumentNo", ObjClass.IdProofDocumentNo, DbType.String, ParameterDirection.Input);
            parameters.Add("IdProofFront", FileNamePathIdProofFront, DbType.String, ParameterDirection.Input);
            parameters.Add("IdProofBack", FileNamePathIdProofBack, DbType.String, ParameterDirection.Input);
            parameters.Add("AddressProofType", ObjClass.AddressProofType, DbType.Int32, ParameterDirection.Input);
            parameters.Add("AddressProofDocumentNo", ObjClass.AddressProofDocumentNo, DbType.String, ParameterDirection.Input);
            parameters.Add("AddressProofFront", FileNamePathAddressProofFront, DbType.String, ParameterDirection.Input);
            parameters.Add("AddressProofBack", FileNamePathAddressProofBack, DbType.String, ParameterDirection.Input);
            parameters.Add("RBESelfie", FileNamePathRBESelfie, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceNo", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();

            var procedureName = "UspInsertOfficerKYC";
            return await connection.QueryAsync<RBEKYCModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetRBEMobilenoModelOutput>> CheckRBEMobileNo([FromBody] GetRBEMobilenoModelInput ObjClass)
        {
            var procedureName = "UspCheckRBEMobileNo";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetRBEMobilenoModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetRBECreationApprovalModelOutput>> BindRBEDetail([FromBody] GetRBECreationApprovalModelInput ObjClass)
        {
            var procedureName = "UspBindRBE";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("UserName", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetRBECreationApprovalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetRBEDetailbyUserNameModelOutput>> GetRBEDetailbyUserName([FromBody] GetRBEDetailbyUserNameModelInput ObjClass)
        {
            var procedureName = "UspGetRBEDetais";
            var parameters = new DynamicParameters();
            parameters.Add("UserName", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetRBEDetailbyUserNameModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RBEApprovalRejectApprovalModelOutput>> ApproveRejectRBE([FromBody] RBEApprovalRejectModelInput ObjClass)
        {
            var procedureName = "UspApproveRejectRBE";
            var parameters = new DynamicParameters();
            parameters.Add("UserName", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            parameters.Add("Comments", ObjClass.Comments, DbType.String, ParameterDirection.Input);
            parameters.Add("Approvalstatus", ObjClass.Approvalstatus, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ApprovedBy", ObjClass.ApprovedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RBEApprovalRejectApprovalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RBEDeviceIdResetRequestModelOutput>> RBEDeviceIdResetRequest([FromBody] RBEDeviceIdResetRequestModelInput ObjClass)
        {
            var procedureName = "UspRBEDeviceIdResetRequest";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RBEDeviceIdResetRequestModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetRBEMobileChangeRequestModelOutput>> GetRBEMobileChangeRequest([FromBody] GetRBEMobileChangeRequestModelInput ObjClass)
        {
            var procedureName = "UspGetRBEMobileChangeRequest";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetRBEMobileChangeRequestModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RequestToChangeRBEMappingModelOutput>> RequestToChangeRBEMapping([FromBody] RequestToChangeRBEMappingModelInput ObjClass)
        {
            var procedureName = "UspRequestToChangeRBEMapping";
            var parameters = new DynamicParameters();
            parameters.Add("PreRBEUserName", ObjClass.PreRBEUserName, DbType.String, ParameterDirection.Input);
            parameters.Add("NewRBEUserName", ObjClass.NewRBEUserName, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RequestToChangeRBEMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
       
        public async Task<IEnumerable<ValidateOtpRBEMappingModelOutput>> ValidateOtpRBEMapping([FromBody] ValidateOtpRBEMappingModelInput ObjClass)
        {
            var procedureName = "UspValidateOtpRBEMapping";
            var parameters = new DynamicParameters();
            parameters.Add("PreRBEUserName", ObjClass.PreRBEUserName, DbType.String, ParameterDirection.Input);
            parameters.Add("NewRBEUserName", ObjClass.NewRBEUserName, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ValidateOtpRBEMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
       
        public async Task<IEnumerable<GetApproveChangeRBEMappingModelOutput>> GetApproveChangeRBEMapping([FromBody] GetApproveChangeRBEMappingModelInput ObjClass)
        {
            var procedureName = "UspGetApproveChangeRBEMapping";
            var parameters = new DynamicParameters();
            parameters.Add("MappingStatus", ObjClass.MappingStatus, DbType.String, ParameterDirection.Input);
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetApproveChangeRBEMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
       
        public async Task<IEnumerable<GetRbeMappingStatusModelOutput>> GetRbeMappingStatus([FromBody] GetRbeMappingStatusModelInput ObjClass)
        {
            var procedureName = "UspGetRbeMappingStatus";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetRbeMappingStatusModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }
        
        public async Task<IEnumerable<ApproveRejectChangedRbeMappingModelOutput>> ApproveRejectChangedRbeMapping([FromBody] ApproveRejectChangedRbeMappingModelInput ObjClass)
        {
            var procedureName = "UspApproveRejectChangedRbeMapping";
            var parameters = new DynamicParameters();
            parameters.Add("PreRBEUserName", ObjClass.PreRBEUserName, DbType.String, ParameterDirection.Input);
            parameters.Add("MappingStatus", ObjClass.MappingStatus, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ApproveRejectChangedRbeMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<SendOtpChangeRBEMobileModelOutput>> SendOtpChangeRBEMobile([FromBody] SendOtpChangeRBEMobileModelInput ObjClass)
        {
            var procedureName = "UspSendOtpChangeRBEMobile";
            var parameters = new DynamicParameters();
            parameters.Add("NewMobileNo", ObjClass.NewMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SendOtpChangeRBEMobileModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ValidateOtpChangeRbeMobileModelOutput>> ValidateOtpChangeRbeMobile([FromBody] ValidateOtpChangeRbeMobileModelInput ObjClass)
        {
            var procedureName = "UspValidateOtpChangeRbeMobile";
            var parameters = new DynamicParameters();
            parameters.Add("ExistingMobileNo", ObjClass.ExistingMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("NewMobileNo", ObjClass.NewMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ValidateOtpChangeRbeMobileModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetApproveChangedRBEMobileModelOutput>> GetApproveChangedRBEMobile([FromBody] GetApproveChangedRBEMobileModelInput ObjClass)
        {
            var procedureName = "UspGetApproveChangedRBEMobile";
            var parameters = new DynamicParameters();
            parameters.Add("MappingStatus", ObjClass.MappingStatus, DbType.String, ParameterDirection.Input);
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetApproveChangedRBEMobileModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ApproveRejectChangedRbeMobileModelOutput>> ApproveRejectChangedRbeMobile([FromBody] ApproveRejectChangedRbeMobileModelInput ObjClass)
        {
            var procedureName = "UspApproveRejectChangedRbeMobile";
            var parameters = new DynamicParameters();
            parameters.Add("ExistingMobile", ObjClass.ExistingMobile, DbType.String, ParameterDirection.Input);
            parameters.Add("MappingStatus", ObjClass.MappingStatus, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ApproveRejectChangedRbeMobileModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<SendOtpResetRBEDeviceModelOutput>> SendOtpResetRBEDevice([FromBody] SendOtpResetRBEDeviceModelInput ObjClass)
        {
            var procedureName = "UspSendOtpResetRBEDevice";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SendOtpResetRBEDeviceModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ValidateOtpResetRBEDeviceModelOutput>> ValidateOtpResetRBEDevice([FromBody] ValidateOtpResetRBEDeviceModelInput ObjClass)
        {
            var procedureName = "UspValidateOtpResetRBEDevice";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("OTP", ObjClass.OTP, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ValidateOtpResetRBEDeviceModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

    }
}
