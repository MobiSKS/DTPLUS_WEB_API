using HPCL.DataRepository.DBDapper;
using System;
using System.Data;
using System.Data.SqlClient;
using HPCL.DataModel.Account;
using Microsoft.Extensions.Logging;

namespace HPCL.DataRepository.Account
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DapperContext _context;
        private readonly ILogger<AccountRepository> _logger;
        public AccountRepository(DapperContext context, ILogger<AccountRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool GenerateToken(AccountModel accountObj)
        {
            bool IsResult = false;
            try
            {
                using var connection = _context.CreateSqlConnection();
                using SqlCommand cmd = new SqlCommand();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "insert into tbl_api_entry(api_flag,useragent,Userip,userid) values('" + accountObj.MethodName + "','" + accountObj.Useragent
                    + "','" + accountObj.Userip + "','" + accountObj.Userid + "')";
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                IsResult = true;
                _logger.LogInformation("GenerateToken");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                IsResult = false;
            }
            return IsResult;

        }
    }
    //using (var connectio1n = _context.CreateConnection())
    // {
    //  //   var companies = await connection.QueryAsync<Company>(query);
    //     //return companies.ToList();
    // }

    //  var procedureName = "sp_Test";
    //var parameters = new DynamicParameters();
    //parameters.Add("username", ObjUser.Username, DbType.String, ParameterDirection.Input);
    //parameters.Add("Mobileno", ObjUser.Mobileno, DbType.String, ParameterDirection.Input);
    //parameters.Add("password", ObjUser.Password, DbType.String, ParameterDirection.Input);

    //var parameters = new DynamicParameters();
    //parameters.Add("Mobileno", ObjUser.Mobileno, DbType.String, ParameterDirection.Input);

    //using (var connection = _context.CreateConnection())
    //{
    //    var login_input = await connection.QueryFirstOrDefaultAsync<LoginModel>
    //        (procedureName, parameters, commandType: CommandType.StoredProcedure);
    //    return login_input;
    //}

    // return true;
}
//}
