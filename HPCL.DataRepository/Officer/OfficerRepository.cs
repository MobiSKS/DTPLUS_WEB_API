﻿using Dapper;
using HPCL.DataRepository.DBDapper;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;
using HPCL.DataModel.Officer;
using HPCL.Infrastructure.CommonClass;

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
            parameters.Add("CityId", ObjClass.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("DistrictId", ObjClass.DistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("PhoneNo", ObjClass.PhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("Fax", ObjClass.Fax, DbType.String, ParameterDirection.Input);
            parameters.Add("Createdby", ObjClass.Createdby, DbType.String, ParameterDirection.Input);
            parameters.Add("ReferenceId", Variables.FunGenerateStringUId(), DbType.String, ParameterDirection.Input);
            parameters.Add("OfficerType", ObjClass.OfficerType, DbType.Int32, ParameterDirection.Input);
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
            parameters.Add("CityId", ObjClass.CityId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("DistrictId", ObjClass.DistrictId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Pin", ObjClass.Pin, DbType.String, ParameterDirection.Input);
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("PhoneNo", ObjClass.PhoneNo, DbType.String, ParameterDirection.Input);
            parameters.Add("EmailId", ObjClass.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("Fax", ObjClass.Fax, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.Int32, ParameterDirection.Input);
            parameters.Add("OfficerId", ObjClass.OfficerId, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<OfficerUpdateModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        
        public async Task<IEnumerable<DeleteOfficerModelOutput>> DeleteOfficer([FromBody] DeleteOfficerModelInput ObjClass)
        {
            var procedureName = "UspInactiveOfficer";
            var parameters = new DynamicParameters();
            parameters.Add("OfficerId", ObjClass.OfficerId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<DeleteOfficerModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

    }
}
