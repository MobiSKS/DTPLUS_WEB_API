using Dapper;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Login;

namespace HPCL.DataRepository.RBE
{
    public class RBERepository : IRBERepository
    {
        private readonly DapperContext _context;
        public RBERepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<object> SearchMerchant([FromBody] LoginModel ObjUser)
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
                var login_input = await connection.QueryFirstOrDefaultAsync<LoginModel>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return login_input;
            }

        }
    }
}
