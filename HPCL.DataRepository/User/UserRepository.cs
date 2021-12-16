using Dapper;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.User;

namespace HPCL.DataRepository.User
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;
        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<object> User_Login([FromBody] UserModel ObjUser)
        {
            var procedureName = "sp_Test";
            //var parameters = new DynamicParameters();
            //parameters.Add("username", ObjUser.Username, DbType.String, ParameterDirection.Input);
            //parameters.Add("Mobileno", ObjUser.Mobileno, DbType.String, ParameterDirection.Input);
            //parameters.Add("password", ObjUser.Password, DbType.String, ParameterDirection.Input);
            
            var parameters = new DynamicParameters();
            parameters.Add("Mobileno", ObjUser.Mobileno, DbType.String, ParameterDirection.Input);

            using (var connection = _context.CreateConnection())
            {
                var login_input = await connection.QueryFirstOrDefaultAsync<UserModel>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return login_input;
            }

        }
    }
}
