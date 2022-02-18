using Dapper;
using HPCL.DataModel.SMSGetSend;
using HPCL.DataRepository.DBDapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.SMSGetSend
{
    public class SMSGetSendRepository: ISMSGetSendRepository
    {
        private readonly DapperContext _context;
        public SMSGetSendRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SMSGetOutputModel>> GetSMSTemplate([FromBody] SMSGetInputModel ObjClass)
        {
            var procedureName = "UspGetSMSTemplate";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SMSGetOutputModel>(procedureName, null, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<SMSSendOutputModel>> SendSMSTemplate([FromBody] SMSSendInputModel ObjClass)
        {
            var procedureName = "UspGetSMSConfiguration";
            var parameters = new DynamicParameters();
            parameters.Add("CTID", ObjClass.CTID, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<SMSSendOutputModel>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<InsertSMSTextEntryOutputModel>> InsertSMSTextEntry([FromBody] InsertSMSTextEntryInputModel ObjClass)
        {
            var procedureName = "UspInsertSMSTextEntry";
            var parameters = new DynamicParameters();
            parameters.Add("MobileNo", ObjClass.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("HeaderTemplate", ObjClass.HeaderTemplate, DbType.String, ParameterDirection.Input);
            parameters.Add("CTID", ObjClass.CTID, DbType.String, ParameterDirection.Input);
            parameters.Add("SMSText", ObjClass.SMSText, DbType.String, ParameterDirection.Input);
            parameters.Add("SMSStatus", ObjClass.SMSStatus, DbType.String, ParameterDirection.Input);
            parameters.Add("SMSStatusDesc", ObjClass.SMSStatusDesc, DbType.String, ParameterDirection.Input);
            parameters.Add("CreatedBy", ObjClass.CreatedBy, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<InsertSMSTextEntryOutputModel>(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
