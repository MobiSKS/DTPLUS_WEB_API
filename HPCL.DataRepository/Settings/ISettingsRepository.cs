using HPCL.DataModel.Settings;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Settings
{
    public interface ISettingsRepository
    {

        public Task<IEnumerable<SettingGetZoneModelOutput>> GetZone([FromBody] SettingGetZoneModelInput ObjClass);
        public Task<IEnumerable<SettingGetRegionModelOutput>> GetRegion([FromBody] SettingGetRegionModelInput ObjClass);
        public Task<IEnumerable<SettingGetSalesareaModelOutput>> GetSalesarea([FromBody] SettingGetSalesareaModelInput ObjClass);
        public Task<IEnumerable<SettingGetTransactionTypeModelOutput>> GetTransactionType([FromBody] SettingGetTransactionTypeModelInput ObjClass);
        public Task<IEnumerable<SettingGetCountryModelOutput>> GetCountry([FromBody] SettingGetCountryModelInput ObjClass);
        public Task<IEnumerable<SettingGetStateModelOutput>> GetState([FromBody] SettingGetStateModelInput ObjClass);
        public Task<IEnumerable<SettingGetRoleModelOutput>> GetRole([FromBody] SettingGetRoleModelInput ObjClass);
        public Task<IEnumerable<SettingGetProductModelOutput>> GetProduct([FromBody] SettingGetProductModelInput ObjClass);
        public Task<IEnumerable<SettingGetEntityTypesModelOutput>> GetEntityStatusType([FromBody] SettingGetEntityTypesModelInput ObjClass);
        public Task<IEnumerable<SettingGetCityModelOutput>> GetCity([FromBody] SettingGetCityModelInput ObjClass);
        public Task<IEnumerable<SettingGetDistrictModelOutput>> GetDistrict([FromBody] SettingGetDistrictModelInput ObjClass);
        public Task<IEnumerable<SettingGetEntityModelOutput>> GetEntity([FromBody] SettingGetEntityModelInput ObjClass);
        public Task<IEnumerable<SettingGetProofTypeModelOutput>> GetProofType([FromBody] SettingGetProofTypeModelInput ObjClass);
    }
}
