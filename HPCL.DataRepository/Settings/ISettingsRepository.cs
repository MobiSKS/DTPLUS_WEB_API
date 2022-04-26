using HPCL.DataModel.Settings;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Settings
{
    public interface ISettingsRepository
    {

        public Task<IEnumerable<SettingGetSalesareaModelOutput>> GetSalesarea([FromBody] SettingGetSalesareaModelInput ObjClass);
        public Task<IEnumerable<SettingGetTransactionTypeModelOutput>> GetTransactionType([FromBody] SettingGetTransactionTypeModelInput ObjClass);
        public Task<IEnumerable<SettingGetRoleModelOutput>> GetRole([FromBody] SettingGetRoleModelInput ObjClass);
        public Task<IEnumerable<SettingGetProductModelOutput>> GetProduct([FromBody] SettingGetProductModelInput ObjClass);
        public Task<IEnumerable<SettingGetEntityTypesModelOutput>> GetEntityStatusType([FromBody] SettingGetEntityTypesModelInput ObjClass);
        public Task<IEnumerable<SettingGetEntityModelOutput>> GetEntity([FromBody] SettingGetEntityModelInput ObjClass);
        public Task<IEnumerable<SettingGetProofTypeModelOutput>> GetProofType([FromBody] SettingGetProofTypeModelInput ObjClass);
        public Task<IEnumerable<SettingGetTierModelOutput>> GetTier([FromBody] SettingGetTierModelInput ObjClass);
        public Task<IEnumerable<SettingGetRecordTypeModelOutput>> GetRecordType([FromBody] SettingGetRecordTypeModelInput ObjClass);

        public Task<IEnumerable<SettingGetSalesareaModelOutput>> GetSalesAreaByMultipleRegion([FromBody] SettingGetSalesAreaByMultipleRegionModelInput ObjClass);

        public Task<IEnumerable<GetStatusTypesForTerminalModelOutput>> GetStatusTypesForTerminal([FromBody] GetStatusTypesForTerminalModelInput ObjClass);

    }
}
