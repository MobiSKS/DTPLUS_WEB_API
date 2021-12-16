using Dapper;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Terminal;
using HPCL.DataRepository.Terminal;

namespace HPCL.DataRepository.UploadDocument
{
    public class TerminalRepository : ITerminalRepository
    {
        private readonly DapperContext _context;
        public TerminalRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<object> User_Login([FromBody] TerminalModel ObjUser)
        {
            var procedureName = "sp_Test";
            var parameters = new DynamicParameters();
            parameters.Add("Mobileno", ObjUser.Mobileno, DbType.String, ParameterDirection.Input);

            using (var connection = _context.CreateConnection())
            {
                var login_input = await connection.QueryFirstOrDefaultAsync<TerminalModel>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return login_input;
            }

        }
    }
}
