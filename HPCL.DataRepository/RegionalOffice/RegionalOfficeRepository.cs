﻿using Dapper;
using HPCL.DataModel.RegionalOffice;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.RegionalOffice
{
    public class RegionalOfficeRepository: IRegionalOfficeRepository
    {
        private readonly DapperContext _context;
        public RegionalOfficeRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetRegionalOfficeModelOutput>> GetRegionalOffice([FromBody] GetRegionalOfficeModelInput ObjClass)
        {
            var procedureName = "UspGetRegionalOffice";
            var parameters = new DynamicParameters();
            parameters.Add("ZonalID", ObjClass.ZonalID, DbType.Int32, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<GetRegionalOfficeModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}