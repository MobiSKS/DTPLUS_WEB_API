using Dapper;
using HPCL.DataModel.Hotlist;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Hotlist
{
    public class HotlistRepository: IHotlistRepository
    {
        private readonly DapperContext _context;
        public HotlistRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetActionListOutput>> GetActionList([FromBody] GetActionListInput ObjClass)
        {
            var procedureName = "UspGetActionList";
            var parameters = new DynamicParameters();
            parameters.Add("EntityTypeId", ObjClass.EntityTypeId, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetActionListOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetEntityTypeListOutput>> GetEntityTypeList([FromBody] GetEntityTypeListInput ObjClass)
        {
            var procedureName = "UspGetEntityTypeList";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetEntityTypeListOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetReasonListForEntitiesOutput>> GetReasonListForEntities([FromBody] GetReasonListForEntitiesInput ObjClass)
        {
            var procedureName = "UspGetReasonListForEntities";
            var parameters = new DynamicParameters();
            parameters.Add("EntityTypeId", ObjClass.EntityTypeId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Actionid", ObjClass.Actionid, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetReasonListForEntitiesOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<GetHotlistedOrReactivatedDetailsOutput>> GetHotlistedOrReactivatedDetails([FromBody] GetHotlistedOrReactivatedDetailsInput ObjClass)
        {
            var procedureName = "UspGetHotlistedOrReactivatedDetails";
            var parameters = new DynamicParameters();
            parameters.Add("EntityTypeId", ObjClass.EntityTypeId, DbType.String, ParameterDirection.Input);
            parameters.Add("EntityIdVal", ObjClass.EntityIdVal, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetHotlistedOrReactivatedDetailsOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
