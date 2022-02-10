using Dapper;
using HPCL.DataModel.Login;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Login
{
    public class LoginRepository: ILoginRepository
    {
        private readonly DapperContext _context;
        public LoginRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetLoginModelOutput>> GetLogin([FromBody] GetLoginModelInput ObjClass)
        {
            var procedureName = "UspGetUserLogin";
            var parameters = new DynamicParameters();
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Useragent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Password", ObjClass.Password, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetLoginModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);

        }
    }
}
