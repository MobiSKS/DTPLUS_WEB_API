using Dapper;
using HPCL.DataRepository.DBDapper;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;
using HPCL.DataModel.Customer;
using HPCL.Infrastructure.CommonClass;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;

//using Microsoft.Extensions.Configuration;

namespace HPCL.DataRepository.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DapperContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        //private readonly Variables ObjVariable;
        public CustomerRepository(DapperContext context, IHostingEnvironment hostingEnvironment) // , IConfiguration configuration
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            //ObjVariable = new Variables(configuration);
        }

        public async Task<IEnumerable<GetCustomerTypeModelOutput>> GetCustomerType([FromBody] GetCustomerTypeModelInput ObjClass)
        {
            var procedureName = "UspGetCustomerType";
            var parameters = new DynamicParameters();
            parameters.Add("CTFlag", ObjClass.CTFlag, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCustomerTypeModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetCustomerSubTypeModelOutput>> GetCustomerSubType([FromBody] GetCustomerSubTypeModelInput ObjClass)
        {
            var procedureName = "UspGetCustomerSubType";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerTypeId", ObjClass.CustomerTypeId, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCustomerSubTypeModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetCustomerTBEntityNameModelOutput>> GetTBEntityName([FromBody] GetCustomerTBEntityNameModelInput ObjClass)
        {
            var procedureName = "UspGetTBEntityName";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCustomerTBEntityNameModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetCustomerSecretQuestionModelOutput>> GetSecretQuestion([FromBody] GetCustomerSecretQuestionModelInput ObjClass)
        {
            var procedureName = "UspGetSecretQuestion";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCustomerSecretQuestionModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetCustomerTypeOfFleetModelOutput>> GetTypeOfFleet([FromBody] GetCustomerTypeOfFleetModelInput ObjClass)
        {
            var procedureName = "UspGetTypeOfFleet";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCustomerTypeOfFleetModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<CustomerInsertModelOutput>> InsertCustomer([FromBody] CustomerInsertModelInput ObjClass)
        {
            var dtDBR = new DataTable("UserDTNoofCards");
            dtDBR.Columns.Add("CardIdentifier", typeof(string));
            dtDBR.Columns.Add("VechileNo", typeof(string));
            dtDBR.Columns.Add("VehicleMake", typeof(string));
            dtDBR.Columns.Add("VehicleType", typeof(int));
            dtDBR.Columns.Add("YearOfRegistration", typeof(int));

            var procedureName = "UspInsertCustomer";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerType", ObjClass.CustomerType, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CustomerSubtype", ObjClass.CustomerSubtype, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ZonalOffice", ObjClass.ZonalOffice, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RegionalOffice", ObjClass.RegionalOffice, DbType.Int32, ParameterDirection.Input);
            parameters.Add("DateOfApplication", ObjClass.DateOfApplication, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("SalesArea", ObjClass.SalesArea, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgNameTitle", ObjClass.IndividualOrgNameTitle, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgName", ObjClass.IndividualOrgName, DbType.String, ParameterDirection.Input);
            parameters.Add("NameOnCard", ObjClass.NameOnCard, DbType.String, ParameterDirection.Input);
            parameters.Add("TypeOfBusinessEntity", ObjClass.TypeOfBusinessEntity, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ResidenceStatus", ObjClass.ResidenceStatus, DbType.String, ParameterDirection.Input);
            parameters.Add("IncomeTaxPan", ObjClass.IncomeTaxPan, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress1", ObjClass.CommunicationAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress2", ObjClass.CommunicationAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress3", ObjClass.CommunicationAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationLocation", ObjClass.CommunicationLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationCityName", ObjClass.CommunicationCityName, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationPincode", ObjClass.CommunicationPincode, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationStateId", ObjClass.CommunicationStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationDistrictId", ObjClass.CommunicationDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationPhoneNo", ObjClass.CommunicationPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationFax", ObjClass.CommunicationFax, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationMobileNo", ObjClass.CommunicationMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationEmailid", ObjClass.CommunicationEmailid, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentAddress1", ObjClass.PermanentAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentAddress2", ObjClass.PermanentAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentAddress3", ObjClass.PermanentAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentLocation", ObjClass.PermanentLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentCityName", ObjClass.PermanentCityName, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentPincode", ObjClass.PermanentPincode, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentStateId", ObjClass.PermanentStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("PermanentDistrictId", ObjClass.PermanentDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("PermanentPhoneNo", ObjClass.PermanentPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentFax", ObjClass.PermanentFax, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialTitle", ObjClass.KeyOfficialTitle, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialIndividualInitials", ObjClass.KeyOfficialIndividualInitials, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialFirstName", ObjClass.KeyOfficialFirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialMiddleName", ObjClass.KeyOfficialMiddleName, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialLastName", ObjClass.KeyOfficialLastName, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialFax", ObjClass.KeyOfficialFax, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialDesignation", ObjClass.KeyOfficialDesignation, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialEmail", ObjClass.KeyOfficialEmail, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialPhoneNo", ObjClass.KeyOfficialPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialDOA", ObjClass.KeyOfficialDOA, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("KeyOfficialMobile", ObjClass.KeyOfficialMobile, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialDOB", ObjClass.KeyOfficialDOB, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("KeyOfficialSecretQuestion", ObjClass.KeyOfficialSecretQuestion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("KeyOfficialSecretAnswer", ObjClass.KeyOfficialSecretAnswer, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialTypeOfFleet", ObjClass.KeyOfficialTypeOfFleet, DbType.Int32, ParameterDirection.Input);
            parameters.Add("KeyOfficialCardAppliedFor", ObjClass.KeyOfficialCardAppliedFor, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialApproxMonthlySpendsonVechile1", ObjClass.KeyOfficialApproxMonthlySpendsonVechile1, DbType.Double, ParameterDirection.Input);
            parameters.Add("KeyOfficialApproxMonthlySpendsonVechile2", ObjClass.KeyOfficialApproxMonthlySpendsonVechile2, DbType.Double, ParameterDirection.Input);
            parameters.Add("AreaOfOperation", ObjClass.AreaOfOperation, DbType.String, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedHCV", ObjClass.FleetSizeNoOfVechileOwnedHCV, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedLCV", ObjClass.FleetSizeNoOfVechileOwnedLCV, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedMUVSUV", ObjClass.FleetSizeNoOfVechileOwnedMUVSUV, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedCarJeep", ObjClass.FleetSizeNoOfVechileOwnedCarJeep, DbType.Int16, ParameterDirection.Input);
            parameters.Add("NoOfCards", ObjClass.NoOfCards, DbType.Int32, ParameterDirection.Input);
            parameters.Add("FeePaymentsCollectFeeWaiver", ObjClass.FeePaymentsCollectFeeWaiver, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FeePaymentsChequeNo", ObjClass.FeePaymentsChequeNo, DbType.String, ParameterDirection.Input);
            parameters.Add("FeePaymentsChequeDate", ObjClass.FeePaymentsChequeDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);

            if (ObjClass.NoOfCards > 0 && ObjClass.ObjCardDetail != null)
            {
                foreach (CardDetail ObjCardDetails in ObjClass.ObjCardDetail)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["CardIdentifier"] = ObjCardDetails.CardIdentifier;
                    dr["VechileNo"] = ObjCardDetails.VechileNo;
                    dr["VehicleMake"] = ObjCardDetails.VehicleMake;
                    dr["VehicleType"] = ObjCardDetails.VehicleType;
                    dr["YearOfRegistration"] = ObjCardDetails.YearOfRegistration;

                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            parameters.Add("CardDetails", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerInsertModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CustomerUpdateModelOutput>> UpdateCustomer([FromBody] CustomerUpdateModelInput ObjClass)
        {
            var dtDBR = new DataTable("UserDTNoofCards");
            dtDBR.Columns.Add("CardIdentifier", typeof(string));
            dtDBR.Columns.Add("VechileNo", typeof(string));
            dtDBR.Columns.Add("VehicleMake", typeof(string));
            dtDBR.Columns.Add("VehicleType", typeof(int));
            dtDBR.Columns.Add("YearOfRegistration", typeof(int));

            var procedureName = "UspUpdateCustomer";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOffice", ObjClass.ZonalOffice, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RegionalOffice", ObjClass.RegionalOffice, DbType.Int32, ParameterDirection.Input);
            parameters.Add("DateOfApplication", ObjClass.DateOfApplication, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("SalesArea", ObjClass.SalesArea, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgNameTitle", ObjClass.IndividualOrgNameTitle, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgName", ObjClass.IndividualOrgName, DbType.String, ParameterDirection.Input);
            parameters.Add("NameOnCard", ObjClass.NameOnCard, DbType.String, ParameterDirection.Input);
            parameters.Add("TypeOfBusinessEntity", ObjClass.TypeOfBusinessEntity, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ResidenceStatus", ObjClass.ResidenceStatus, DbType.String, ParameterDirection.Input);
            parameters.Add("IncomeTaxPan", ObjClass.IncomeTaxPan, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress1", ObjClass.CommunicationAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress2", ObjClass.CommunicationAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress3", ObjClass.CommunicationAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationLocation", ObjClass.CommunicationLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationCityName", ObjClass.CommunicationCityName, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationPincode", ObjClass.CommunicationPincode, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationStateId", ObjClass.CommunicationStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationDistrictId", ObjClass.CommunicationDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationPhoneNo", ObjClass.CommunicationPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationFax", ObjClass.CommunicationFax, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationMobileNo", ObjClass.CommunicationMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationEmailid", ObjClass.CommunicationEmailid, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentAddress1", ObjClass.PermanentAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentAddress2", ObjClass.PermanentAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentAddress3", ObjClass.PermanentAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentLocation", ObjClass.PermanentLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentCityName", ObjClass.PermanentCityName, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentPincode", ObjClass.PermanentPincode, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentStateId", ObjClass.PermanentStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("PermanentDistrictId", ObjClass.PermanentDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("PermanentPhoneNo", ObjClass.PermanentPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("PermanentFax", ObjClass.PermanentFax, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialTitle", ObjClass.KeyOfficialTitle, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialIndividualInitials", ObjClass.KeyOfficialIndividualInitials, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialFirstName", ObjClass.KeyOfficialFirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialMiddleName", ObjClass.KeyOfficialMiddleName, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialLastName", ObjClass.KeyOfficialLastName, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialFax", ObjClass.KeyOfficialFax, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialDesignation", ObjClass.KeyOfficialDesignation, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialEmail", ObjClass.KeyOfficialEmail, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialPhoneNo", ObjClass.KeyOfficialPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialDOA", ObjClass.KeyOfficialDOA, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("KeyOfficialMobile", ObjClass.KeyOfficialMobile, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialDOB", ObjClass.KeyOfficialDOB, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("KeyOfficialSecretQuestion", ObjClass.KeyOfficialSecretQuestion, DbType.Int32, ParameterDirection.Input);
            parameters.Add("KeyOfficialSecretAnswer", ObjClass.KeyOfficialSecretAnswer, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialTypeOfFleet", ObjClass.KeyOfficialTypeOfFleet, DbType.Int32, ParameterDirection.Input);
            parameters.Add("KeyOfficialCardAppliedFor", ObjClass.KeyOfficialCardAppliedFor, DbType.String, ParameterDirection.Input);
            parameters.Add("KeyOfficialApproxMonthlySpendsonVechile1", ObjClass.KeyOfficialApproxMonthlySpendsonVechile1, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("KeyOfficialApproxMonthlySpendsonVechile2", ObjClass.KeyOfficialApproxMonthlySpendsonVechile2, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("AreaOfOperation", ObjClass.AreaOfOperation, DbType.String, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedHCV", ObjClass.FleetSizeNoOfVechileOwnedHCV, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedLCV", ObjClass.FleetSizeNoOfVechileOwnedLCV, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedMUVSUV", ObjClass.FleetSizeNoOfVechileOwnedMUVSUV, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FleetSizeNoOfVechileOwnedCarJeep", ObjClass.FleetSizeNoOfVechileOwnedCarJeep, DbType.Int16, ParameterDirection.Input);
            parameters.Add("NoOfCards", ObjClass.NoOfCards, DbType.Int32, ParameterDirection.Input);
            parameters.Add("FeePaymentsCollectFeeWaiver", ObjClass.FeePaymentsCollectFeeWaiver, DbType.Int16, ParameterDirection.Input);
            parameters.Add("FeePaymentsChequeNo", ObjClass.FeePaymentsChequeNo, DbType.String, ParameterDirection.Input);
            parameters.Add("FeePaymentsChequeDate", ObjClass.FeePaymentsChequeDate, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            

            if (ObjClass.NoOfCards > 0 && ObjClass.ObjCardDetail != null)
            {
                foreach (UpdateCardDetail ObjCardDetails in ObjClass.ObjCardDetail)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["CardIdentifier"] = ObjCardDetails.CardIdentifier;
                    dr["VechileNo"] = ObjCardDetails.VechileNo;
                    dr["VehicleMake"] = ObjCardDetails.VehicleMake;
                    dr["VehicleType"] = ObjCardDetails.VehicleType;
                    dr["YearOfRegistration"] = ObjCardDetails.YearOfRegistration;

                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            parameters.Add("CardDetails", dtDBR, DbType.Object, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerUpdateModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CustomerViewOnlineFormStatusModelOutput>> ViewOnlineFormStatus([FromBody] CustomerViewOnlineFormStatusModelInput ObjClass)
        {
            var procedureName = "UspBindCustomer";
            var parameters = new DynamicParameters();
            parameters.Add("StatusId", ObjClass.StatusId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("FormNumber", ObjClass.FormNumber, DbType.Int64, ParameterDirection.Input);
            parameters.Add("CustomerReferenceNo", ObjClass.CustomerReferenceNo, DbType.Int64, ParameterDirection.Input);
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerViewOnlineFormStatusModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CustomerKYCModelOutput>> UploadCustomerKYC([Microsoft.AspNetCore.Mvc.FromForm] CustomerKYCModelInput ObjClass)
        {
            string FileNamePath = string.Empty;
            string filePath = string.Empty;
            var procedureName = "UspInsertCustomerKYC";
            var parameters = new DynamicParameters();
            var ImageFileName = ObjClass.ImageFileName;
            if (ImageFileName.Length > 0)
            {
                IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".png", ".pdf", ".gif", ".jpg" };
                var ext = ImageFileName.FileName.Substring(ImageFileName.FileName.LastIndexOf('.'));
                var extension = ext.ToLower();
                if (AllowedFileExtensions.Contains(extension))
                {
                    //string webRootPath = _hostingEnvironment.WebRootPath;
                    string contentRootPath = _hostingEnvironment.ContentRootPath;
                    FileNamePath = "/CustomerKYCImage/" + ObjClass.FormNumber + "_" + ObjClass.FileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss")
                        + "_" + ObjClass.KYCType + "_" + ImageFileName.FileName;
                    filePath = contentRootPath + FileNamePath;


                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        ImageFileName.CopyTo(fileStream);
                    }
                }
            }

            parameters.Add("FormNumber", ObjClass.FormNumber, DbType.Int64, ParameterDirection.Input);
            parameters.Add("FileName", ObjClass.FileName, DbType.String, ParameterDirection.Input);
            parameters.Add("FileNamePath", FileNamePath, DbType.String, ParameterDirection.Input);
            parameters.Add("KYCType", ObjClass.KYCType, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerKYCModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CustomerApprovalModelOutput>> ApproveRejectCustomer([FromBody] CustomerApprovalModelInput ObjClass)
        {
            var procedureName = "UspUserApproveCustomer";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("Comments", ObjClass.Comments, DbType.String, ParameterDirection.Input);
            parameters.Add("Approvalstatus", ObjClass.Approvalstatus, DbType.String, ParameterDirection.Input);
            parameters.Add("ApprovedBy", ObjClass.ApprovedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerApprovalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<CustomerDetailsModelOutput>> GetCustomerByCustomerId([FromBody] CustomerGetByCustomerIdModelInput ObjClass)
        {
            var procedureName = "UspGetCustomerDetailByCustomerId";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerDetailsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CustomerGetVehicleTypeModelOutput>> GetVehicleType([FromBody] CustomerGetVehicleTypeModelInput ObjClass)
        {
            var procedureName = "UspVehicleType";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerGetVehicleTypeModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<CustomerFeewaiverApprovalModelOutput>> ApproveRejectFeewaiver([FromBody] CustomerFeewaiverApprovalModelInput ObjClass)
        {
            var procedureName = "UspApproveRejectFeewaiver";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("Comments", ObjClass.Comments, DbType.String, ParameterDirection.Input);
            parameters.Add("Approvalstatus", ObjClass.Approvalstatus, DbType.String, ParameterDirection.Input);
            parameters.Add("ApprovedBy", ObjClass.ApprovedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerFeewaiverApprovalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<CustomerDetailsModelOutput>> GetCustomerDetails([FromBody] CustomerDetailsModelInput ObjClass)
        {
            var procedureName = "UspGetCustomerDetail";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerDetailsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

    }
}
