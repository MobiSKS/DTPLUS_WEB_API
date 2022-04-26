using Dapper;
using HPCL.DataModel.AshokLeyland;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.AshokLeyland
{
    public class AshokLeylandRepository : IAshokLeylandRepository
    {
        private readonly DapperContext _context;
        public AshokLeylandRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ALDealerEnrollmentModelOutput>> InsertALDealerEnrollment([FromBody] ALDealerEnrollmentModelInput ObjClass)
        {
            var procedureName = "UspInsertALDealerEnrollment";
            var parameters = new DynamicParameters();
            parameters.Add("DealerCode", ObjClass.DealerCode, DbType.String, ParameterDirection.Input);
            parameters.Add("DealerName", ObjClass.DealerName, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Address1", ObjClass.Address1, DbType.String, ParameterDirection.Input);
            parameters.Add("Address2", ObjClass.Address2, DbType.String, ParameterDirection.Input);
            parameters.Add("Address3", ObjClass.Address3, DbType.String, ParameterDirection.Input);
            parameters.Add("StateId", ObjClass.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CityName", ObjClass.CityName, DbType.String, ParameterDirection.Input);
            parameters.Add("DistrictId", ObjClass.DistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("Createdby", ObjClass.Createdby, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("OfficerType", 8, DbType.Int32, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ALDealerEnrollmentModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<UpdateALDealerEnrollmentModelOutput>> UpdateALDealerEnrollment([FromBody] UpdateALDealerEnrollmentModelInput ObjClass)
        {
            var procedureName = "UspUpdateALDealerEnrollment";
            var parameters = new DynamicParameters();
            parameters.Add("DealerCode", ObjClass.DealerCode, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Address1", ObjClass.Address1, DbType.String, ParameterDirection.Input);
            parameters.Add("Address2", ObjClass.Address2, DbType.String, ParameterDirection.Input);
            parameters.Add("Address3", ObjClass.Address3, DbType.String, ParameterDirection.Input);
            parameters.Add("StateId", ObjClass.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CityName", ObjClass.CityName, DbType.String, ParameterDirection.Input);
            parameters.Add("DistrictId", ObjClass.DistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateALDealerEnrollmentModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetDealerNameModelOutput>> GetALDealerDetail([FromBody] GetDealerNameModelInput ObjClass)
        {
            var procedureName = "UspGetALDealerDetail";
            var parameters = new DynamicParameters();
            parameters.Add("DealerCode", ObjClass.DealerCode, DbType.String, ParameterDirection.Input);
            parameters.Add("DTPDealerCode", ObjClass.DTPDealerCode, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetDealerNameModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CheckDealerCodeModelOutput>> CheckDealerCode([FromBody] CheckDealerCodeModelInput ObjClass)
        {
            var procedureName = "UspCheckDealerCode";
            var parameters = new DynamicParameters();
            parameters.Add("DealerCode", ObjClass.DealerCode, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CheckDealerCodeModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<InsertALCustomerModelOutput>> InsertALCustomer([FromBody] InsertALCustomerModelInput ObjClass)
        {
            var dtDBR = new DataTable("UserInsertALCard");
            dtDBR.Columns.Add("CardNo", typeof(string));
            dtDBR.Columns.Add("VechileNo", typeof(string));
            dtDBR.Columns.Add("VehicleType", typeof(string));
            dtDBR.Columns.Add("VINNumber", typeof(string));
            dtDBR.Columns.Add("MobileNo", typeof(string));

            if (ObjClass.ObjALCardEntryDetail != null)
            {
                foreach (ALCardEntryDetail ObjCardDetails in ObjClass.ObjALCardEntryDetail)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["CardNo"] = ObjCardDetails.CardNo;
                    dr["VechileNo"] = ObjCardDetails.VechileNo;
                    dr["VehicleType"] = ObjCardDetails.VehicleType;
                    dr["VINNumber"] = ObjCardDetails.VINNumber;
                    dr["MobileNo"] = ObjCardDetails.MobileNo;

                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspInsertALCCustomer";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerType", 942, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CustomerSubtype", 943, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgNameTitle", ObjClass.IndividualOrgNameTitle, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgName", ObjClass.IndividualOrgName, DbType.String, ParameterDirection.Input);
            parameters.Add("NameOnCard", ObjClass.NameOnCard, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress1", ObjClass.CommunicationAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress2", ObjClass.CommunicationAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationCityName", ObjClass.CommunicationCityName, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationPincode", ObjClass.CommunicationPincode, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationStateId", ObjClass.CommunicationStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationDistrictId", ObjClass.CommunicationDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationPhoneNo", ObjClass.CommunicationPhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationFax", ObjClass.CommunicationFax, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationMobileNo", ObjClass.CommunicationMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationEmailid", ObjClass.CommunicationEmailid, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("DealerCode", ObjClass.DealerCode, DbType.String, ParameterDirection.Input);
            parameters.Add("SalesExecutiveEmployeeID", ObjClass.SalesExecutiveEmployeeID, DbType.String, ParameterDirection.Input);
            parameters.Add("CopyofDriverLicense", ObjClass.CopyofDriverLicense, DbType.String, ParameterDirection.Input);
            parameters.Add("CopyofVehicleRegistrationCertificate", ObjClass.CopyofVehicleRegistrationCertificate, DbType.String, ParameterDirection.Input);
            parameters.Add("InsertALCard", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<InsertALCustomerModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<InsertDealerWiseALOTCCardRequestModelOutput>> InsertDealerWiseALOTCCardRequest([FromBody] InsertDealerWiseALOTCCardRequestModelInput ObjClass)
        {
            var procedureName = "UspInsertDealerWiseALOTCCard";
            var parameters = new DynamicParameters();
            parameters.Add("DealerCode", ObjClass.DealerCode, DbType.String, ParameterDirection.Input);
            parameters.Add("NoofCards", ObjClass.NoofCards, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("CardType", "ALOTCCard", DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<InsertDealerWiseALOTCCardRequestModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        //public async Task<IEnumerable<MerchantCheckAvailityCardOutput>> CheckAvailityALOTCCard([FromBody] MerchantCheckAvailityCardInput ObjClass)
        //{
        //    var procedureName = "UspCheckAvailityDummyCard";
        //    var parameters = new DynamicParameters();
        //    parameters.Add("CardNo", ObjClass.CardNo, DbType.String, ParameterDirection.Input);
        //    parameters.Add("CardType", "ALOTCCard", DbType.String, ParameterDirection.Input);
        //    using var connection = _context.CreateConnection();
        //    return await connection.QueryAsync<MerchantCheckAvailityCardOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        //}


        public async Task<IEnumerable<GetAvailityALOTCCardCardOutput>> GetAvailityALOTCCard([FromBody] GetAvailityALOTCCardCardInput ObjClass)
        {
            var procedureName = "UspGetAvailityALCard";
            var parameters = new DynamicParameters();
            parameters.Add("CardType", "ALOTCCard", DbType.String, ParameterDirection.Input);
            parameters.Add("DealerCode", ObjClass.DealerCode, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetAvailityALOTCCardCardOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<ALViewCardMerchantAllocationModelOutput> ViewALOTCCardDealerAllocation([FromBody] ALViewCardDealerAllocationModelInput ObjClass)
        {
            var procedureName = "UspViewCardDealerAllocation";
            var parameters = new DynamicParameters();
            parameters.Add("CardType", "ALOTCCard", DbType.String, ParameterDirection.Input);
            parameters.Add("DealerCode", ObjClass.DealerCode, DbType.String, ParameterDirection.Input);
            parameters.Add("CardNo", ObjClass.CardNo, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            var storedProcedureResult = new ALViewCardMerchantAllocationModelOutput();
            storedProcedureResult.ObjALTotalCardDetail = (List<ALTotalCardModelOutput>)await result.ReadAsync<ALTotalCardModelOutput>();
            storedProcedureResult.ObjALViewCardDetail = (List<ALViewCardMerchantDetailModelOutput>)await result.ReadAsync<ALViewCardMerchantDetailModelOutput>();
            return storedProcedureResult;
        }
        public async Task<GetAlAddonOTCCardMappingCustomerDetailsModelOutput> GetAlAddonOTCCardMappingCustomerDetails([FromBody] GetAlAddonOTCCardMappingCustomerDetailsModelInput ObjClass)
        {
            var procedureName = "UspGetAlAddonOTCCardMappingCustomerDetails";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", ObjClass.CustomerId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            var storedProcedureResult = new GetAlAddonOTCCardMappingCustomerDetailsModelOutput();
            storedProcedureResult.GetCustomerNameAndNameOnCardOutput = (List<GetCustomerNameAndNameOnCardModelOutput>)await result.ReadAsync<GetCustomerNameAndNameOnCardModelOutput>();
            storedProcedureResult.GetCustomerStatusOutput = (List<GetCustomerStatusOutput>)await result.ReadAsync<GetCustomerStatusOutput>();
            return storedProcedureResult;
        }

        public async Task<IEnumerable<GetAlSalesExeEmpIdAddOnOTCCardMappingModelOutput>> GetAlSalesExeEmpIdAddOnOTCCardMapping([FromBody] GetAlSalesExeEmpIdAddOnOTCCardMappingModelInput ObjClass)
        {
            var procedureName = "UspGetAlSalesExeEmpIdAddOnOTCCardMapping";
            var parameters = new DynamicParameters();
            parameters.Add("DealerCode", ObjClass.DealerCode, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetAlSalesExeEmpIdAddOnOTCCardMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<AlAddOnOTCCardModelOutput>> AlAddOnOTCCard([FromBody] AlAddOnOTCCardModelInput ObjClass)
        {
            var dtDBR = new DataTable("UserDTNoofCards");
            dtDBR.Columns.Add("CardNo", typeof(string));
            dtDBR.Columns.Add("VechileNo", typeof(string));
            dtDBR.Columns.Add("VehicleType", typeof(string));
            dtDBR.Columns.Add("VINNumber", typeof(string));
            dtDBR.Columns.Add("MobileNo", typeof(string));

            var procedureName = "UspInsertAlAddOnOTCCardMapping";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", ObjClass.CustomerId, DbType.String, ParameterDirection.Input);
            parameters.Add("NoOfCards", ObjClass.NoOfCards, DbType.Int32, ParameterDirection.Input);

            if (ObjClass.NoOfCards > 0 && ObjClass.ObjCardDetail != null)
            {
                foreach (AlAddOnOTCCardDetails ObjCardDetails in ObjClass.ObjCardDetail)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["CardNo"] = ObjCardDetails.CardNo;
                    dr["VechileNo"] = ObjCardDetails.VechileNo;
                    dr["VehicleType"] = ObjCardDetails.VehicleType;
                    dr["VINNumber"] = ObjCardDetails.VINNumber;
                    dr["MobileNo"] = ObjCardDetails.MobileNo;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }
            parameters.Add("CardDetails", dtDBR, DbType.Object, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<AlAddOnOTCCardModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
