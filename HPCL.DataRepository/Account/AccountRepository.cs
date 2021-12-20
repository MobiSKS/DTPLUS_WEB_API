using Dapper;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Login;
using System.Data.SqlClient;
using HPCL.DataModel.Account;

namespace HPCL.DataRepository.Account
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DapperContext _context;
        public AccountRepository(DapperContext context)
        {
            _context = context;
        }

        public bool GenerateToken(AccountModel accountObj)
        {
            using (var connection = _context.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    //connection.Open();
                    //cmd.Connection = connection;
                    //cmd.CommandText = "insert into tbl_api_entry(api_flag,useragent,Userip,userid) values('" + Method_Name + "','" + Useragent
                    //    + "','" + Userip + "','" + Userid + "')";
                    //cmd.CommandType = CommandType.Text;
                    //int i = cmd.ExecuteNonQuery();
                    //connection.Close();
                    //IsResult = true;
                }

               using (var connectio1n = _context.CreateConnection())
                {
                    var companies = await connectio1n.QueryAsync<Company>(query);
                    return companies.ToList();
                }
            }
        }

            var procedureName = "sp_Test";
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

            return true;
        }
    }
}
