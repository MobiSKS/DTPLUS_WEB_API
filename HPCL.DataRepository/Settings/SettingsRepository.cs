using Dapper;
using HPCL.DataRepository.DBDapper;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Settings;

namespace HPCL.DataRepository.Settings
{
    public class SettingsRepository : ISettingsRepository
    {
        private readonly DapperContext _context;
        public SettingsRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<SettingGetHQModelOutput> GetHQ([FromBody] SettingGetHQModelInput ObjClass)
        {
            var procedureName = "UspGetHQ";
            //var parameters = new DynamicParameters();
            //parameters.Add("Mobileno", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryFirstOrDefaultAsync<SettingGetHQModelOutput>
            //(procedureName, parameters, commandType: CommandType.StoredProcedure);
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;

        }
    }
}
