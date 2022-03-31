using Dapper;
using HPCL.DataModel.RBE;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.RBE
{
    public class RBERepository : IRBERepository
    {
        private readonly DapperContext _context;
        public RBERepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ChangeRBEMappingModelOutput>> ChangeRBEMapping([FromBody] ChangeRBEMappingModelInput ObjClass)
        {
            var procedureName = "UspChangeRBEMapping";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ChangeRBEMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ManageRBEUserModelOutput>> ManageRBEUser([FromBody] ManageRBEUserModelInput ObjClass)
        {
            var procedureName = "UspManageRBEUser";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ManageRBEUserModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
