using Dapper;
using HPCL.DataModel.District;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.District
{
    public class DistrictRepository: IDistrictRepository
    {
        private readonly DapperContext _context;
        public DistrictRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetDistrictModelOutput>> GetDistrict([FromBody] GetDistrictModelInput ObjClass)
        {
            var procedureName = "UspGetDistrict";
            var parameters = new DynamicParameters();
            parameters.Add("StateID", ObjClass.StateID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetDistrictModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
