using Dapper;
using HPCL.DataModel.Card;
using HPCL.DataModel.CustomerAPI;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.CustomerAPI
{
    public class CustomerAPIRepository : ICustomerAPIRepository
    {
        private readonly DapperContext _context;
        public CustomerAPIRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CustomerAPIValidateCredentialsModelOutput>> ApproveRejectCard([FromBody] CustomerAPIValidateCredentialsModelInput ObjClass)
        {
            var procedureName = "UspCustomerAPIValidateCredentials";
            var parameters = new DynamicParameters();
            parameters.Add("Username", ObjClass.Username, DbType.String, ParameterDirection.Input);
            parameters.Add("Password", ObjClass.Password, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerAPIValidateCredentialsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<CustomerAPICheckVechileNoModelOutput>> CustomerAPICheckVechileNo([FromBody] CustomerAPICheckVechileNoModelInput ObjClass)
        {
            var procedureName = "UspCheckVechileNo";
            var parameters = new DynamicParameters();
            parameters.Add("VehicleRegistrationNumber", ObjClass.VehicleRegistrationNumber, DbType.String, ParameterDirection.Input);
            parameters.Add("MethodName", "CustomerAPICheckVechileNo", DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CustomerAPICheckVechileNoModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
