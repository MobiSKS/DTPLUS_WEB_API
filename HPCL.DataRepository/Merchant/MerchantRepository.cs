using Dapper;
using HPCL.DataModel.Merchant;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
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
            parameters.Add("ErpCode", ObjClass.ErpCode, DbType.Int64, ParameterDirection.Input);
            parameters.Add("RetailOutletName", ObjClass.RetailOutletName, DbType.String, ParameterDirection.Input);
            parameters.Add("MerchantTypeId", ObjClass.MerchantTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("DealerName", ObjClass.DealerName, DbType.String, ParameterDirection.Input);
            parameters.Add("MappedMerchantId", ObjClass.MappedMerchantId, DbType.Int64, ParameterDirection.Input);
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
            parameters.Add("MerchantId", ObjClass.MerchantId, DbType.Int64, ParameterDirection.Input);
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
    }
}
