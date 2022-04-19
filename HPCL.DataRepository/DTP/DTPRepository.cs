using Dapper;
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

        public async Task<IEnumerable<CardBalanceTransferModelOutput>> CardBalanceTransfer([FromBody] CardBalanceTransferModelInput ObjClass)
        {
            var procedureName = "UspCardBalanceTransfer";
            var parameters = new DynamicParameters();
            parameters.Add("@CardNo", ObjClass.Cardno, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<CardBalanceTransferModelOutput>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
