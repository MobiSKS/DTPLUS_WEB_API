using Dapper;
using HPCL.DataRepository.DBDapper;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Settings;
using HPCL.DataModel;

namespace HPCL.DataRepository.Settings
{
    public class SettingsRepository : ISettingsRepository
    {
        private readonly DapperContext _context;
        public SettingsRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<SettingGetCustomerTypeModelOutput> GetCustomerType([FromBody] SettingGetCustomerTypeModelInput ObjClass)
        {
            var procedureName = "UspGetCustomerType";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetCustomerTypeModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetCustomerSubTypeModelOutput> GetCustomerSubType([FromBody] SettingGetCustomerSubTypeModelInput ObjClass)
        {
            var procedureName = "UspGetCustomerSubType";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerTypeId", ObjClass.CustomerTypeId, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetCustomerSubTypeModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetHQModelOutput> GetHQ([FromBody] SettingGetHQModelInput ObjClass)
        {
            var procedureName = "UspGetHQ";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetHQModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetZoneModelOutput> GetZone([FromBody] SettingGetZoneModelInput ObjClass)
        {
            var procedureName = "UspGetZone";
            var parameters = new DynamicParameters();
            parameters.Add("HQID", ObjClass.HQID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetZoneModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetRegionModelOutput> GetRegion([FromBody] SettingGetRegionModelInput ObjClass)
        {
            var procedureName = "UspGetRegion";
            var parameters = new DynamicParameters();
            parameters.Add("ZoneID", ObjClass.ZoneID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetRegionModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetSalesareaModelOutput> GetSalesarea([FromBody] SettingGetSalesareaModelInput ObjClass)
        {
            var procedureName = "UspGetSalesarea";
            var parameters = new DynamicParameters();
            parameters.Add("RegionID", ObjClass.RegionID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetSalesareaModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetTransactionTypeModelOutput> GetTransactionType([FromBody] SettingGetTransactionTypeModelInput ObjClass)
        {
            var procedureName = "UspGetTransactionType";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetTransactionTypeModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetStoreCategoriesModelOutput> GetStoreCategories([FromBody] SettingGetStoreCategoriesModelInput ObjClass)
        {
            var procedureName = "UspGetStoreCategories";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetStoreCategoriesModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetCountryModelOutput> GetCountry([FromBody] SettingGetCountryModelInput ObjClass)
        {
            var procedureName = "UspGetCountry";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetCountryModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetStateModelOutput> GetState([FromBody] SettingGetStateModelInput ObjClass)
        {
            var procedureName = "UspGetState";
            var parameters = new DynamicParameters();
            parameters.Add("CountryID", ObjClass.CountryID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetStateModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetSBUModelOutput> GetSBU([FromBody] SettingGetSBUModelInput ObjClass)
        {
            var procedureName = "UspGetSBU";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetSBUModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetRoleModelOutput> GetRole([FromBody] SettingGetRoleModelInput ObjClass)
        {
            var procedureName = "UspGetRole";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetRoleModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetProductModelOutput> GetProduct([FromBody] SettingGetProductModelInput ObjClass)
        {
            var procedureName = "UspGetProduct";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetProductModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }


        public async Task<SettingGetEntityTypesModelOutput> GetEntityTypes([FromBody] SettingGetEntityTypesModelInput ObjClass)
        {
            var procedureName = "UspGetEntityTypes";
            var parameters = new DynamicParameters();
            parameters.Add("EntityTypeId", ObjClass.EntityTypeId, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetEntityTypesModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }


    }
}
