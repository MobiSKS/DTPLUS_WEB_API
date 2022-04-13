using Dapper;
using HPCL.DataModel.TMS;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.TMS
{
    public class TMSRepository : ITMSRepository
    {
        private readonly DapperContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public TMSRepository(DapperContext context, IHostingEnvironment hostingEnvironment) // , IConfiguration configuration
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<IEnumerable<GetEnrollTransportManagementSystemModelOutput>> GetEnrollTransportManagementSystem([FromBody] GetEnrollTransportManagementSystemModelInput ObjClass)
        {
            var procedureName = "UspGetEnrollTransportManagementSystem";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", ObjClass.CustomerId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetEnrollTransportManagementSystemModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<GetEnrollmentStatusModelOutput>> GetEnrollmentStatus([FromBody] GetEnrollmentStatusModelInput ObjClass)
        {
            var procedureName = "UspGetEnrollmentStatus";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetEnrollmentStatusModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }
        public async Task<GetEnrollVehicleModelOutput> GetEnrollVehicle([FromBody] GetEnrollVehicleModelInput ObjClass)
        {
            var procedureName = "UspGetEnrollVehicle";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", ObjClass.CustomerId, DbType.String, ParameterDirection.Input);
            parameters.Add("EnrollmentStatus", ObjClass.EnrollmentStatus, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var result = await connection.QueryMultipleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            var storedProcedureResult = new GetEnrollVehicleModelOutput();
            storedProcedureResult.ObjGetEnrollVehicleCustomerName = (List<GetEnrollVehicleCustomerNameModelOutput>)await result.ReadAsync<GetEnrollVehicleCustomerNameModelOutput>();
            storedProcedureResult.ObjGetEnrollVehicle = (List<GetStatusEnrollVehicleModelOutput>)await result.ReadAsync<GetStatusEnrollVehicleModelOutput>();
            return storedProcedureResult;
        }
        public async Task<IEnumerable<GetManageEnrollmentsModelOutput>> GetManageEnrollments([FromBody] GetManageEnrollmentsModelInput ObjClass)
        {
            var procedureName = "UspGetManageEnrollments";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", ObjClass.CustomerId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetManageEnrollmentsModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

    }

}
