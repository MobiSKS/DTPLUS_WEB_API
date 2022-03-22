using Dapper;
using HPCL.DataModel.Country;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Country
{
    public class CountryRepository: ICountryRepository
    {
        private readonly DapperContext _context;
        public CountryRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetCountryModelOutput>> GetCountry([FromBody] GetCountryModelInput ObjClass)
        {
            var procedureName = "UspGetCountry";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetCountryModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }
    }
}
