using Dapper;
using HPCL.DataModel.State;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.State
{
    public class StateRepository: IStateRepository
    {
        private readonly DapperContext _context;
        public StateRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetStateModelOutput>> GetState([FromBody] GetStateModelInput ObjClass)
        {
            var procedureName = "UspGetState";
            var parameters = new DynamicParameters();
            parameters.Add("CountryID", ObjClass.CountryID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetStateModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }
    }
}
