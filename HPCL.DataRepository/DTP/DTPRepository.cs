using Dapper;
using HPCL.DataModel.DTP;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.DTP
{
    public class DTPRepository : IDTPRepository
    {
        private readonly DapperContext _context;

        public DTPRepository(DapperContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelOutput>> GetBlockUnBlockCustomerCCMSAccountByCustomerId([FromBody] GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelInput ObjClass)
        {
            var procedureName = "UspGetBlockUnBlockCustomerCCMSAccountByCustomerId";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
