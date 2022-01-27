using Dapper;
using HPCL.DataModel.ZonalOffice;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.ZonalOffice
{
    public class ZonalOfficeRepository : IZonalOfficeRepository
    {
        private readonly DapperContext _context;
        public ZonalOfficeRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetZonalOfficeModelOutput>> GetZonalOffice([FromBody] GetZonalOfficeModelInput ObjClass)
        {
            var procedureName = "UspGetZonalOffice";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetZonalOfficeModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }
    }
}
