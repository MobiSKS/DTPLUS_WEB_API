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
        public async Task<SettingGetCustomerTypeOutput> GetCustomerType([FromBody] SettingGetCustomerTypeInput ObjClass)
        {
            var procedureName = "UspGetCustomerType";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetCustomerTypeOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<SettingGetCustomerSubTypeOutput> GetCustomerSubType([FromBody] SettingGetCustomerSubTypeInput ObjClass)
        {
            var procedureName = "UspGetCustomerSubType";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerTypeId", ObjClass.CustomerTypeId, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetCustomerSubTypeOutput>
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

        public async Task<SettingGetZoneOutput> GetGetZone([FromBody] SettingGetZoneInput ObjClass)
        {
            var procedureName = "UspGetZone";
            var parameters = new DynamicParameters();
            parameters.Add("HQID", ObjClass.HQID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetZoneOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }
    }
}
