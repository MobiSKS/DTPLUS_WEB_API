using Dapper;
using HPCL.DataModel.Officer;
using HPCL.DataRepository.DBDapper;
using HPCL.Infrastructure.CommonClass;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Officer
{
    public class OfficerRepository : IOfficerRepository
    {
        private readonly DapperContext _context;

        public OfficerRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OfficerInsertModelOutput>> InsertOfficer([FromBody] OfficerInsertModelInput ObjClass)
        {
            var procedureName = "UspInsertOfficer";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("LastName", ObjClass.LastName, DbType.String, ParameterDirection.Input);
            parameters.Add("UserName", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            parameters.Add("LocationId", ObjClass.LocationId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Address1", ObjClass.Address1, DbType.String, ParameterDirection.Input);
            parameters.Add("Address2", ObjClass.Address2, DbType.String, ParameterDirection.Input);
            parameters.Add("Address3", ObjClass.Address3, DbType.String, ParameterDirection.Input);
            parameters.Add("StateId", ObjClass.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CityName", ObjClass.CityName, DbType.String, ParameterDirection.Input);
            parameters.Add("DistrictId", ObjClass.DistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("PhoneNo", ObjClass.PhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("Fax", ObjClass.Fax, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("OfficerType", ObjClass.OfficerType, DbType.Int32, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            parameters.Add("Password", ObjClass.Password, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<OfficerInsertModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetOfficerModelOutput>> GetOfficerDetail([FromBody] GetOfficerModelInput ObjClass)
        {
            var procedureName = "UspGetOfficerDetail";
            var parameters = new DynamicParameters();
            parameters.Add("OfficerType", ObjClass.OfficerType, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Location", ObjClass.Location, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetOfficerModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<OfficerUpdateModelOutput>> UpdateOfficer([FromBody] OfficerUpdateModelInput ObjClass)
        {
            var procedureName = "UspUpdateOfficer";
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", ObjClass.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("LastName", ObjClass.LastName, DbType.String, ParameterDirection.Input);
            parameters.Add("Address1", ObjClass.Address1, DbType.String, ParameterDirection.Input);
            parameters.Add("Address2", ObjClass.Address2, DbType.String, ParameterDirection.Input);
            parameters.Add("Address3", ObjClass.Address3, DbType.String, ParameterDirection.Input);
            parameters.Add("StateId", ObjClass.StateId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CityName", ObjClass.CityName, DbType.String, ParameterDirection.Input);
            parameters.Add("DistrictId", ObjClass.DistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("PhoneNo", ObjClass.PhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("Fax", ObjClass.Fax, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            parameters.Add("OfficerId", ObjClass.OfficerId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("UserAgent", ObjClass.Useragent, DbType.String, ParameterDirection.Input);
            parameters.Add("Userid", ObjClass.Userid, DbType.String, ParameterDirection.Input);
            parameters.Add("Userip", ObjClass.Userip, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<OfficerUpdateModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<DeleteOfficerModelOutput>> DeleteOfficer([FromBody] DeleteOfficerModelInput ObjClass)
        {
            var procedureName = "UspInactiveOfficer";
            var parameters = new DynamicParameters();
            parameters.Add("OfficerId", ObjClass.OfficerId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<DeleteOfficerModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CheckOfficerModelOutput>> ChkUserName([FromBody] CheckOfficerModelInput ObjClass)
        {
            var procedureName = "UspChkUserName";
            var parameters = new DynamicParameters();
            parameters.Add("UserName", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CheckOfficerModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<OfficerLocationMappingModelOutput>> InsertOfficerLocationMapping([FromBody] OfficerLocationMappingModelInput ObjClass)
        {
            var procedureName = "UspInsertOfficerLocationMapping";
            var parameters = new DynamicParameters();
            parameters.Add("OfficerId", ObjClass.OfficerId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("UserName", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            parameters.Add("ZO", ObjClass.ZO, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RO", ObjClass.RO, DbType.Int32, ParameterDirection.Input);
            //parameters.Add("HQ", ObjClass.HQ, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.Createdby, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<OfficerLocationMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<OfficerDeleteLocationMappingModelOutput>> DeleteOfficerLocationMapping([FromBody] OfficerDeleteLocationMappingModelInput ObjClass)
        {
            var procedureName = "UspInactiveOfficerLocationMapping";
            var parameters = new DynamicParameters();
            parameters.Add("UserName", ObjClass.UserName, DbType.String, ParameterDirection.Input);
            parameters.Add("ZO", ObjClass.ZO, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RO", ObjClass.RO, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<OfficerDeleteLocationMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetOfficerModelOutput>> BindOfficer([FromBody] BindOfficerModelInput ObjClass)
        {
            var procedureName = "UspBindOfficerDetail";
            var parameters = new DynamicParameters();
            parameters.Add("OfficerID", ObjClass.OfficerID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetOfficerModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<GetOfficerTypeModelOutput>> GetOfficerType([FromBody] GetOfficerTypeModelInput ObjClass)
        {
            var procedureName = "UspGetOfficerType";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetOfficerTypeModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);

        }

        public async Task<IEnumerable<GetOfficerLocationMappingModelOutput>> GetOfficerLocationMapping([FromBody] BindOfficerModelInput ObjClass)
        {
            var procedureName = "UspGetOfficerLocationMapping";
            var parameters = new DynamicParameters();
            parameters.Add("OfficerID", ObjClass.OfficerID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetOfficerLocationMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<GetOfficerDetailModelOutput>> GetOfficerDetailByLocation([FromBody] GetOfficerDetailModelInput ObjClass)
        {
            var procedureName = "UspGetOfficerDetails";
            var parameters = new DynamicParameters();
            parameters.Add("ZO", ObjClass.ZO, DbType.String, ParameterDirection.Input);
            parameters.Add("RO", ObjClass.RO, DbType.String, ParameterDirection.Input);
            parameters.Add("StateId", ObjClass.StateId, DbType.String, ParameterDirection.Input);
            parameters.Add("DistrictId", ObjClass.DistrictId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetOfficerDetailModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


    }
}
