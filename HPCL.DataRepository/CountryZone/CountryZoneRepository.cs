using Dapper;
using HPCL.DataModel.CountryZone;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.CountryZone
{
    public class CountryZoneRepository: ICountryZoneRepository
    {
        private readonly DapperContext _context;
        public CountryZoneRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetCountryZoneModelOutput>> GetCountryZone([FromBody] GetCountryZoneModelInput ObjClass)
        {
            var procedureName = "UspGetZone";
            var parameters = new DynamicParameters();
            parameters.Add("HQID", ObjClass.HQID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCountryZoneModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }

    }
}
