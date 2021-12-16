using Dapper;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.User;
using HPCL.DataModel.UploadDocument;

namespace HPCL.DataRepository.UploadDocument
{
    public class UploadDocumentRepository : IUploadDocumentRepository
    {
        private readonly DapperContext _context;
        public UploadDocumentRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<object> User_Login([FromBody] UploadDocumentModel ObjUser)
        {
            var procedureName = "sp_Test";
            var parameters = new DynamicParameters();
            parameters.Add("Mobileno", ObjUser.Mobileno, DbType.String, ParameterDirection.Input);

            using (var connection = _context.CreateConnection())
            {
                var login_input = await connection.QueryFirstOrDefaultAsync<UploadDocumentModel>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return login_input;
            }

        }
    }
}
