﻿using Dapper;
using HPCL.DataModel.DTP;
using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.DTP
{
    public class DTPRepository : IDTPRepository
    {
        private readonly DapperContext _context;

        public DTPRepository(DapperContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelOutput>> GetBlockUnBlockCustomerCCMSAccountByCustomerId([FromBody] GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelInput ObjClass)
        {
            var procedureName = "UspGetBlockUnBlockCustomerCCMSAccountByCustomerId";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<BlockUnBlockCustomerCCMSAccountOutput>> BlockUnBlockCustomerCCMSAccount([FromBody] BlockUnBlockCustomerCCMSAccountInput ObjClass)
        {
            var procedureName = "UspBlockUnBlockCustomerCCMSAccount";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerID", ObjClass.CustomerID, DbType.String, ParameterDirection.Input);
            parameters.Add("CCMSBalanceStatus", ObjClass.CCMSBalanceStatus, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CCMSBalanceRemarks", ObjClass.CCMSBalanceRemarks, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);

            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<BlockUnBlockCustomerCCMSAccountOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        //

        public async Task<IEnumerable<CardBalanceTransferModelOutput>> CardBalanceTransfer([FromBody] CardBalanceTransferModelInput ObjClass)
        {
            var procedureName = "UspCardBalanceTransfer";
            var parameters = new DynamicParameters();
            parameters.Add("@CardNo", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CardBalanceTransferModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<InsertTeamMappingModelOutput>> InsertTeamMapping([FromBody] InsertTeamMappingModelInput ObjClass)
        {
            var procedureName = "UspTeamMapping";
            var parameters = new DynamicParameters();
            parameters.Add("ZBMID", ObjClass.ZBMID, DbType.String, ParameterDirection.Input);
            parameters.Add("ZBMName", ObjClass.ZBMName, DbType.String, ParameterDirection.Input);
            parameters.Add("RSMID", ObjClass.RSMID, DbType.String, ParameterDirection.Input);
            parameters.Add("RSMName", ObjClass.RSMName, DbType.String, ParameterDirection.Input);
            parameters.Add("RBEID", ObjClass.RBEID, DbType.String, ParameterDirection.Input);
            parameters.Add("RBEName", ObjClass.RBEName, DbType.String, ParameterDirection.Input);
            parameters.Add("Location", ObjClass.Location, DbType.String, ParameterDirection.Input);          
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<InsertTeamMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetTeamMappingModelOutput>> GetTeamMapping([FromBody] GetTeamMappingModelInput ObjClass)
        {
            var procedureName = "UspGetTeamMapping";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetTeamMappingModelOutput>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<UpdateTeamMappingModelOutput>> UpdateTeamMapping([FromBody] UpdateTeamMappingModelInput ObjClass)
        {
            var procedureName = "UspUpdateTeamMapping";

            var parameters = new DynamicParameters();
            parameters.Add("TeamMappingId", ObjClass.TeamMappingId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ZBMID", ObjClass.ZBMID, DbType.String, ParameterDirection.Input);
            parameters.Add("ZBMName", ObjClass.ZBMName, DbType.String, ParameterDirection.Input);
            parameters.Add("RSMID", ObjClass.RSMID, DbType.String, ParameterDirection.Input);
            parameters.Add("RSMName", ObjClass.RSMName, DbType.String, ParameterDirection.Input);
            parameters.Add("RBEID", ObjClass.RBEID, DbType.String, ParameterDirection.Input);
            parameters.Add("RBEName", ObjClass.RBEName, DbType.String, ParameterDirection.Input);
            parameters.Add("Location", ObjClass.Location, DbType.String, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<UpdateTeamMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<IEnumerable<DeleteTeamMappingModelOutput>> DeleteTeamMapping([FromBody] DeleteTeamMappingModelInput ObjClass)
        {
            var procedureName = "UspInactiveTeamMapping";
            var parameters = new DynamicParameters();
            parameters.Add("TeamMappingId", ObjClass.TeamMappingId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ModifiedBy", ObjClass.ModifiedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<DeleteTeamMappingModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<GetEntityFieldByEntityTypeIdModelOutput>> GetEntityFieldByEntityTypeId([FromBody] GetEntityFieldByEntityTypeIdModelInput ObjClass)
        {
            var procedureName = "GetEntityFieldByEntityTypeId";
            var parameters = new DynamicParameters();
            parameters.Add("EntityTypeId", ObjClass.EntityTypeId, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetEntityFieldByEntityTypeIdModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
