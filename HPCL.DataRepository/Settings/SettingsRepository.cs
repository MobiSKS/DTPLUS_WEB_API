﻿using Dapper;
using HPCL.DataRepository.DBDapper;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Settings;
using HPCL.DataModel;
using System.Collections.Generic;

namespace HPCL.DataRepository.Settings
{
    public class SettingsRepository : ISettingsRepository
    {
        private readonly DapperContext _context;
        public SettingsRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SettingGetCustomerTypeModelOutput>> GetCustomerType([FromBody] SettingGetCustomerTypeModelInput ObjClass)
        {
            var procedureName = "UspGetCustomerType";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetCustomerTypeModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetCustomerSubTypeModelOutput>> GetCustomerSubType([FromBody] SettingGetCustomerSubTypeModelInput ObjClass)
        {
            var procedureName = "UspGetCustomerSubType";
            var parameters = new DynamicParameters();
            parameters.Add("CustomerTypeId", ObjClass.CustomerTypeId, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetCustomerSubTypeModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetHQModelOutput>> GetHQ([FromBody] SettingGetHQModelInput ObjClass)
        {
            var procedureName = "UspGetHQ";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetHQModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetZoneModelOutput>> GetZone([FromBody] SettingGetZoneModelInput ObjClass)
        {
            var procedureName = "UspGetZone";
            var parameters = new DynamicParameters();
            parameters.Add("HQID", ObjClass.HQID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetZoneModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetRegionModelOutput>> GetRegion([FromBody] SettingGetRegionModelInput ObjClass)
        {
            var procedureName = "UspGetRegion";
            var parameters = new DynamicParameters();
            parameters.Add("ZoneID", ObjClass.ZoneID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetRegionModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetSalesareaModelOutput>> GetSalesarea([FromBody] SettingGetSalesareaModelInput ObjClass)
        {
            var procedureName = "UspGetSalesarea";
            var parameters = new DynamicParameters();
            parameters.Add("RegionID", ObjClass.RegionID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetSalesareaModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetTransactionTypeModelOutput>> GetTransactionType([FromBody] SettingGetTransactionTypeModelInput ObjClass)
        {
            var procedureName = "UspGetTransactionType";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetTransactionTypeModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetStoreCategoriesModelOutput>> GetStoreCategories([FromBody] SettingGetStoreCategoriesModelInput ObjClass)
        {
            var procedureName = "UspGetStoreCategories";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetStoreCategoriesModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetCountryModelOutput>> GetCountry([FromBody] SettingGetCountryModelInput ObjClass)
        {
            var procedureName = "UspGetCountry";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetCountryModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetStateModelOutput>> GetState([FromBody] SettingGetStateModelInput ObjClass)
        {
            var procedureName = "UspGetState";
            var parameters = new DynamicParameters();
            parameters.Add("CountryID", ObjClass.CountryID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetStateModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetSBUModelOutput>> GetSBU([FromBody] SettingGetSBUModelInput ObjClass)
        {
            var procedureName = "UspGetSBU";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetSBUModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetRoleModelOutput>> GetRole([FromBody] SettingGetRoleModelInput ObjClass)
        {
            var procedureName = "UspGetRole";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetRoleModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }

        public async Task<IEnumerable<SettingGetProductModelOutput>> GetProduct([FromBody] SettingGetProductModelInput ObjClass)
        {
            var procedureName = "UspGetProduct";
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetProductModelOutput>
            (procedureName, null, commandType: CommandType.StoredProcedure);
            return login_input;
        }


        public async Task<IEnumerable<SettingGetEntityTypesModelOutput>> GetEntityTypes([FromBody] SettingGetEntityTypesModelInput ObjClass)
        {
            var procedureName = "UspGetEntityTypes";
            var parameters = new DynamicParameters();
            parameters.Add("EntityTypeId", ObjClass.EntityTypeId, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var login_input = await connection.QueryAsync<SettingGetEntityTypesModelOutput>
            (procedureName, parameters, commandType: CommandType.StoredProcedure);
            return login_input;
        }


    }
}
