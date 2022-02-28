using Dapper;
using HPCL.DataModel.Merchant;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Merchant
{
    public class MerchantRepository : IMerchantRepository
    {
        private readonly DapperContext _context;
        public MerchantRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetMerchantTypeModelOutput>> GetMerchantType([FromBody] GetMerchantTypeModelInput ObjClass)
        {
            var procedureName = "UspGetMerchantType";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetMerchantTypeModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetMerchantOutletCategoryModelOutput>> GetOutletCategory([FromBody] GetMerchantOutletCategoryModelInput ObjClass)
        {
            var procedureName = "UspGetOutletCategory";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetMerchantOutletCategoryModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetSBUModelOutput>> GetSBU([FromBody] MerchantGetSBUModelInput ObjClass)
        {
            var procedureName = "UspGetSBU";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetSBUModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantInsertModelOutput>> InsertMerchant([FromBody] MerchantInsertModelInput ObjClass)
        {
            var procedureName = "UspInsertMerchant";
            var parameters = new DynamicParameters();
            parameters.Add("ErpCode", ObjClass.ErpCode, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletName", ObjClass.RetailOutletName, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantTypeId", ObjClass.MerchantTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("DealerName", ObjClass.DealerName, DbType.String, ParameterDirection.Input);
            parameters.Add("MappedMerchantId", ObjClass.MappedMerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("DealerMobileNo", ObjClass.DealerMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("OutletCategoryId", ObjClass.OutletCategoryId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("HighwayNo1", ObjClass.HighwayNo1, DbType.String, ParameterDirection.Input);
            parameters.Add("HighwayNo2", ObjClass.HighwayNo2, DbType.String, ParameterDirection.Input);
            parameters.Add("HighwayName", ObjClass.HighwayName, DbType.String, ParameterDirection.Input);
            parameters.Add("SBUTypeId", ObjClass.SBUTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("LPGCNGSale", ObjClass.LPGCNGSale, DbType.Double, ParameterDirection.Input);
            parameters.Add("PancardNumber", ObjClass.PancardNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("GSTNumber", ObjClass.GSTNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletAddress1", ObjClass.RetailOutletAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletAddress2", ObjClass.RetailOutletAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletAddress3", ObjClass.RetailOutletAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletLocation", ObjClass.RetailOutletLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletCity", ObjClass.RetailOutletCity, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletStateId", ObjClass.RetailOutletStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RetailOutletDistrictId", ObjClass.RetailOutletDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RetailOutletPinNumber", ObjClass.RetailOutletPinNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletPhoneNumber", ObjClass.RetailOutletPhoneNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletFax", ObjClass.RetailOutletFax, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("SalesAreaId", ObjClass.SalesAreaId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ContactPersonNameFirstName", ObjClass.ContactPersonNameFirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("ContactPersonNameMiddleName", ObjClass.ContactPersonNameMiddleName, DbType.String, ParameterDirection.Input);
            parameters.Add("ContactPersonNameLastName", ObjClass.ContactPersonNameLastName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("Mics", ObjClass.Mics, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress1", ObjClass.CommunicationAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress2", ObjClass.CommunicationAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress3", ObjClass.CommunicationAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationLocation", ObjClass.CommunicationLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationCity", ObjClass.CommunicationCity, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationStateId", ObjClass.CommunicationStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationDistrictId", ObjClass.CommunicationDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationPinNumber", ObjClass.CommunicationPinNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationPhoneNumber", ObjClass.CommunicationPhoneNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationFax", ObjClass.CommunicationFax, DbType.String, ParameterDirection.Input);
            parameters.Add("NoofLiveTerminals", ObjClass.NoofLiveTerminals, DbType.Int32, ParameterDirection.Input);
            parameters.Add("TerminalTypeRequested", ObjClass.TerminalTypeRequested, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantInsertModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<MerchantUpdateModelOutput>> UpdateMerchant([FromBody] MerchantUpdateModelInput ObjClass)
        {
            var procedureName = "UspUpdateMerchant";
            var parameters = new DynamicParameters();
            parameters.Add("ErpCode", ObjClass.ErpCode, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletName", ObjClass.RetailOutletName, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantTypeId", ObjClass.MerchantTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("DealerName", ObjClass.DealerName, DbType.String, ParameterDirection.Input);
            parameters.Add("DealerMobileNo", ObjClass.DealerMobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("OutletCategoryId", ObjClass.OutletCategoryId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("HighwayNo1", ObjClass.HighwayNo1, DbType.String, ParameterDirection.Input);
            parameters.Add("HighwayNo2", ObjClass.HighwayNo2, DbType.String, ParameterDirection.Input);
            parameters.Add("HighwayName", ObjClass.HighwayName, DbType.String, ParameterDirection.Input);
            parameters.Add("SBUTypeId", ObjClass.SBUTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("LPGCNGSale", ObjClass.LPGCNGSale, DbType.Double, ParameterDirection.Input);
            parameters.Add("PancardNumber", ObjClass.PancardNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("GSTNumber", ObjClass.GSTNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletAddress1", ObjClass.RetailOutletAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletAddress2", ObjClass.RetailOutletAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletAddress3", ObjClass.RetailOutletAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletLocation", ObjClass.RetailOutletLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletCity", ObjClass.RetailOutletCity, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletStateId", ObjClass.RetailOutletStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RetailOutletDistrictId", ObjClass.RetailOutletDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RetailOutletPinNumber", ObjClass.RetailOutletPinNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletPhoneNumber", ObjClass.RetailOutletPhoneNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("RetailOutletFax", ObjClass.RetailOutletFax, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("SalesAreaId", ObjClass.SalesAreaId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ContactPersonNameFirstName", ObjClass.ContactPersonNameFirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("ContactPersonNameMiddleName", ObjClass.ContactPersonNameMiddleName, DbType.String, ParameterDirection.Input);
            parameters.Add("ContactPersonNameLastName", ObjClass.ContactPersonNameLastName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("Mics", ObjClass.Mics, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress1", ObjClass.CommunicationAddress1, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress2", ObjClass.CommunicationAddress2, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationAddress3", ObjClass.CommunicationAddress3, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationLocation", ObjClass.CommunicationLocation, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationCity", ObjClass.CommunicationCity, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationStateId", ObjClass.CommunicationStateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationDistrictId", ObjClass.CommunicationDistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CommunicationPinNumber", ObjClass.CommunicationPinNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationPhoneNumber", ObjClass.CommunicationPhoneNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("CommunicationFax", ObjClass.CommunicationFax, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantUpdateModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<MerchantApprovalRejectModelOutput>> ApproveRejectMerchant([FromBody] MerchantApprovalRejectModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeUpdateMerchant");
            dtDBR.Columns.Add("ErpCode", typeof(string));
            dtDBR.Columns.Add("Comments", typeof(string));

            var procedureName = "UspApproveRejectMerchant";
            var parameters = new DynamicParameters();
            //parameters.Add("ErpCode", ObjClass.ErpCode, DbType.String, ParameterDirection.Input);
            //parameters.Add("Comments", ObjClass.Comments, DbType.String, ParameterDirection.Input);

            if (ObjClass.ObjApprovalRejectDetail != null)
            {
                foreach (ApprovalRejectModelInput ObjCardDetails in ObjClass.ObjApprovalRejectDetail)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["ErpCode"] = ObjCardDetails.ErpCode;
                    dr["Comments"] = ObjCardDetails.Comments;

                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            parameters.Add("UpdateMerchant", dtDBR, DbType.Object, ParameterDirection.Input);
            parameters.Add("StatusId", ObjClass.StatusId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ApprovedBy", ObjClass.ApprovedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantApprovalRejectModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetByMerchantIdModelOutput>> GetMerchantbyMerchantId([FromBody] MerchantGetByMerchantIdModelInput ObjClass)
        {
            var procedureName = "UspGetMerchant";
            var parameters = new DynamicParameters();
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetByMerchantIdModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetByMerchantIdModelOutput>> GetMerchantbyERPCode([FromBody] MerchantGetByErpCodeModelInput ObjClass)
        {
            var procedureName = "UspGetMerchantbyErpCode";
            var parameters = new DynamicParameters();
            parameters.Add("ErpCode", ObjClass.ErpCode, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetByMerchantIdModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetMerchantApprovalModelOutput>> GetMerchantApproval([FromBody] MerchantGetMerchantApprovalModelInput ObjClass)
        {
            var procedureName = "UspGetMerchantApproval";
            var parameters = new DynamicParameters();
            parameters.Add("Category", ObjClass.Category, DbType.String, ParameterDirection.Input);
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetMerchantApprovalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<RejectedMerchantModelOutput>> GetRejectedMerchant([FromBody] RejectedMerchantModelInput ObjClass)
        {
            var procedureName = "UspGetRejectedMerchant";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<RejectedMerchantModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantSearchMerchantForCardCreationModelOutput>> SearchMerchantForCardCreation([FromBody] MerchantSearchMerchantForCardCreationModelInput ObjClass)
        {
            var procedureName = "UspSearchMerchantForCardCreation";
            var parameters = new DynamicParameters();
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantSearchMerchantForCardCreationModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantInsertOTCCustomerModelOutput>> InsertOTCCustomer([FromBody] MerchantInsertOTCCustomerModelInput ObjClass)
        {
            var dtDBR = new DataTable("UserInsertOTCCard");
            dtDBR.Columns.Add("CardNo", typeof(string));
            dtDBR.Columns.Add("CardIdentifier", typeof(string));
            dtDBR.Columns.Add("MobileNo", typeof(string));

            if (ObjClass.ObjOTCCardEntryDetail != null)
            {
                foreach (OTCCardEntryDetail ObjCardDetails in ObjClass.ObjOTCCardEntryDetail)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["CardNo"] = ObjCardDetails.CardNo;
                    dr["CardIdentifier"] = ObjCardDetails.VechileNo;
                    dr["MobileNo"] = ObjCardDetails.MobileNo;

                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspInsertOTCCustomer";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerType", 918, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CustomerSubtype", 920, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgNameTitle", ObjClass.IndividualOrgNameTitle, DbType.String, ParameterDirection.Input);
            parameters.Add("IndividualOrgName", ObjClass.IndividualOrgName, DbType.String, ParameterDirection.Input);
            parameters.Add("NameOnCard", ObjClass.NameOnCard, DbType.String, ParameterDirection.Input);
            parameters.Add("IncomeTaxPan", ObjClass.IncomeTaxPan, DbType.String, ParameterDirection.Input);
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
            parameters.Add("FormNumber", ObjClass.FormNumber, DbType.Int64, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("CopyofDriverLicense", ObjClass.CopyofDriverLicense, DbType.String, ParameterDirection.Input);
            parameters.Add("CopyofVehicleRegistrationCertificate", ObjClass.CopyofVehicleRegistrationCertificate, DbType.String, ParameterDirection.Input);
            parameters.Add("InsertOTCCard", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantInsertOTCCustomerModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantCheckAvailityCardOutput>> CheckAvailityOTCCard([FromBody] MerchantCheckAvailityCardInput ObjClass)
        {
            var procedureName = "UspCheckAvailityDummyCard";
            var parameters = new DynamicParameters();
            parameters.Add("CardNo", ObjClass.CardNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CardType", "OTCCard", DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantCheckAvailityCardOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantCheckAvailityCardOutput>> CheckAvailityTatkalCard([FromBody] MerchantCheckAvailityCardInput ObjClass)
        {
            var procedureName = "UspCheckAvailityDummyCard";
            var parameters = new DynamicParameters();
            parameters.Add("CardNo", ObjClass.CardNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CardType", "TatkalCard", DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantCheckAvailityCardOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantCheckAvailityCardOutput>> CheckAvailityDriverCard([FromBody] MerchantCheckAvailityCardInput ObjClass)
        {
            var procedureName = "UspCheckAvailityDummyCard";
            var parameters = new DynamicParameters();
            parameters.Add("CardNo", ObjClass.CardNo, DbType.String, ParameterDirection.Input);
            parameters.Add("CardType", "DriverCard", DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantCheckAvailityCardOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetAvailityCardOutput>> GetAvailityOTCCard([FromBody] MerchantGetAvailityCardInput ObjClass)
        {
            var procedureName = "UspGetAvailityDummyCard";
            var parameters = new DynamicParameters();
            parameters.Add("RegionalId", ObjClass.RegionalId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CardType", "OTCCard", DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetAvailityCardOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<MerchantGetAvailityCardOutput>> GetAvailityTatkalCard([FromBody] MerchantGetAvailityCardInput ObjClass)
        {
            var procedureName = "UspGetAvailityDummyCard";
            var parameters = new DynamicParameters();
            parameters.Add("RegionalId", ObjClass.RegionalId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CardType", "TatkalCard", DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetAvailityCardOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantGetAvailityCardOutput>> GetAvailityDriverCard([FromBody] MerchantGetAvailityCardInput ObjClass)
        {
            var procedureName = "UspGetAvailityDummyCard";
            var parameters = new DynamicParameters();
            parameters.Add("RegionalId", ObjClass.RegionalId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CardType", "DriverCard", DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantGetAvailityCardOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<MerchantSearchForTerminalInstallationRequestModelOutput> SearchForTerminalInstallationRequest([FromBody] MerchantSearchForTerminalInstallationRequestModelInput ObjClass)
        {
            var procedureName = "UspSearchForTerminalInstallationRequest";
            var parameters = new DynamicParameters();
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);

            var storedProcedureResult = new MerchantSearchForTerminalInstallationRequestModelOutput();
            storedProcedureResult.ObjMerchantDetail = (List<MerchantDetailOutput>)await result.ReadAsync<MerchantDetailOutput>();
            storedProcedureResult.ObjTerminalDetail = (List<TerminalDetailOutput>)await result.ReadAsync<TerminalDetailOutput>();
            return storedProcedureResult;

        }

        public async Task<IEnumerable<MerchantInsertAddonTerminalModelOutput>> InsertTerminalInstallationRequest([FromBody] MerchantInsertAddonTerminalModelInput ObjClass)
        {
            var procedureName = "UspInsertAddonTerminal";
            var parameters = new DynamicParameters();
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalTypeRequested ", ObjClass.TerminalTypeRequested, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalIssuanceType", ObjClass.TerminalIssuanceType, DbType.String, ParameterDirection.Input);
            parameters.Add("Justification", ObjClass.Justification, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantInsertAddonTerminalModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<MerchantSearchForTerminalInstallationRequestCloseModelOutput>> SearchForTerminalInstallationRequestClose([FromBody] MerchantSearchForTerminalInstallationRequestCloseModelInput ObjClass)
        {
            var procedureName = "UspSearchForTerminalInstallationRequestClose";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantSearchForTerminalInstallationRequestCloseModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<GetMerchantTypeModelOutput>> GetReasonList([FromBody] MerchantGetReasonListModelInput ObjClass)
        {
            var procedureName = "UspGetReasonList";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetMerchantTypeModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MerchantUpdateTerminalInstallationRequestCloseModelOutput>> UpdateTerminalInstallationRequestClose([FromBody] MerchantUpdateTerminalInstallationRequestCloseModelInput ObjClass)
        {
            var dtDBR = new DataTable("TypeMerchantTerminalMap");
            dtDBR.Columns.Add("MerchantId", typeof(string));
            dtDBR.Columns.Add("TerminalId", typeof(string));
          

            if (ObjClass.ObjMerchantTerminalInstallationRequestCloseDetail != null)
            {
                foreach (MerchantTerminalInstallationRequestCloseModelInput ObjDetail in ObjClass.ObjMerchantTerminalInstallationRequestCloseDetail)
                {
                    DataRow dr = dtDBR.NewRow();
                    dr["MerchantId"] = ObjDetail.MerchantId;
                    dr["TerminalId"] = ObjDetail.TerminalId;
                    dtDBR.Rows.Add(dr);
                    dtDBR.AcceptChanges();
                }
            }

            var procedureName = "UspUpdateTerminalInstallationRequestClose";
            var parameters = new DynamicParameters();
            parameters.Add("StatusId", ObjClass.StatusId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ReasonId", ObjClass.ReasonId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("UpdateTerminalInstReq", dtDBR, DbType.Object, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantUpdateTerminalInstallationRequestCloseModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<MerchantViewTerminalInstallationRequestStatusCloseModelOutput>> ViewTerminalInstallationRequestStatus([FromBody] MerchantViewTerminalInstallationRequestStatusCloseInput ObjClass)
        {
            var procedureName = "UspViewTerminalInstallationRequestStatus";
            var parameters = new DynamicParameters();
            parameters.Add("FromDate", ObjClass.FromDate, DbType.String, ParameterDirection.Input);
            parameters.Add("ToDate", ObjClass.ToDate, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.String, ParameterDirection.Input);
            parameters.Add("TerminalId", ObjClass.TerminalId, DbType.String, ParameterDirection.Input);
            parameters.Add("ZonalOfficeId", ObjClass.ZonalOfficeId, DbType.String, ParameterDirection.Input);
            parameters.Add("RegionalOfficeId", ObjClass.RegionalOfficeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<MerchantViewTerminalInstallationRequestStatusCloseModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

    }
}
