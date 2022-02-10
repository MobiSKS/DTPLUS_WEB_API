using Dapper;
using HPCL.DataModel.Settings;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Settings
{
    public class SettingsRepository : ISettingsRepository
    {
        private readonly DapperContext _context;
        public SettingsRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SettingGetZoneModelOutput>> GetZone([FromBody] SettingGetZoneModelInput ObjClass)
        {
            var procedureName = "UspGetZone";
            var parameters = new DynamicParameters();
            parameters.Add("HQID", ObjClass.HQID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetZoneModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<SettingGetRegionModelOutput>> GetRegion([FromBody] SettingGetRegionModelInput ObjClass)
        {
            var procedureName = "UspGetRegion";
            var parameters = new DynamicParameters();
            parameters.Add("ZoneID", ObjClass.ZoneID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetRegionModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<SettingGetSalesareaModelOutput>> GetSalesarea([FromBody] SettingGetSalesareaModelInput ObjClass)
        {
            var procedureName = "UspGetSalesarea";
            var parameters = new DynamicParameters();
            parameters.Add("RegionID", ObjClass.RegionID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetSalesareaModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<SettingGetTransactionTypeModelOutput>> GetTransactionType([FromBody] SettingGetTransactionTypeModelInput ObjClass)
        {
            var procedureName = "UspGetTransactionType";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetTransactionTypeModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<SettingGetCountryModelOutput>> GetCountry([FromBody] SettingGetCountryModelInput ObjClass)
        {
            var procedureName = "UspGetCountry";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetCountryModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<SettingGetStateModelOutput>> GetState([FromBody] SettingGetStateModelInput ObjClass)
        {
            var procedureName = "UspGetState";
            var parameters = new DynamicParameters();
            parameters.Add("CountryID", ObjClass.CountryID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetStateModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }



        public async Task<IEnumerable<SettingGetRoleModelOutput>> GetRole([FromBody] SettingGetRoleModelInput ObjClass)
        {
            var procedureName = "UspGetRole";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetRoleModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<SettingGetProductModelOutput>> GetProduct([FromBody] SettingGetProductModelInput ObjClass)
        {
            var procedureName = "UspGetProduct";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetProductModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<SettingGetEntityModelOutput>> GetEntity([FromBody] SettingGetEntityModelInput ObjClass)
        {
            var procedureName = "UspGetEntity";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetEntityModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<SettingGetEntityTypesModelOutput>> GetEntityStatusType([FromBody] SettingGetEntityTypesModelInput ObjClass)
        {
            var procedureName = "UspGetEntityTypes";
            var parameters = new DynamicParameters();
            parameters.Add("EntityTypeId", ObjClass.EntityTypeId, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetEntityTypesModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }


        public async Task<IEnumerable<SettingGetCityModelOutput>> GetCity([FromBody] SettingGetCityModelInput ObjClass)
        {
            var procedureName = "UspGetCity";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetCityModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<SettingGetDistrictModelOutput>> GetDistrict([FromBody] SettingGetDistrictModelInput ObjClass)
        {
            var procedureName = "UspGetDistrict";
            var parameters = new DynamicParameters();
            parameters.Add("StateID", ObjClass.StateID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetDistrictModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<SettingGetProofTypeModelOutput>> GetProofType([FromBody] SettingGetProofTypeModelInput ObjClass)
        {
            var procedureName = "UspGetProofTypes";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SettingGetProofTypeModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }


    }
}
