using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Settings;

namespace HPCL.DataRepository.Settings
{
    public interface ISettingsRepository
    {
        public Task<IEnumerable<SettingGetCustomerTypeModelOutput>> GetCustomerType([FromBody] SettingGetCustomerTypeModelInput ObjClass);
        public Task<IEnumerable<SettingGetCustomerSubTypeModelOutput>> GetCustomerSubType([FromBody] SettingGetCustomerSubTypeModelInput ObjClass);
        public Task<IEnumerable<SettingGetHQModelOutput>> GetHQ([FromBody] SettingGetHQModelInput ObjClass);
        public Task<IEnumerable<SettingGetZoneModelOutput>> GetZone([FromBody] SettingGetZoneModelInput ObjClass);
        public Task<IEnumerable<SettingGetRegionModelOutput>> GetRegion([FromBody] SettingGetRegionModelInput ObjClass);
        public Task<IEnumerable<SettingGetSalesareaModelOutput>> GetSalesarea([FromBody] SettingGetSalesareaModelInput ObjClass);
        public Task<IEnumerable<SettingGetTransactionTypeModelOutput>> GetTransactionType([FromBody] SettingGetTransactionTypeModelInput ObjClass);
        public Task<IEnumerable<SettingGetStoreCategoriesModelOutput>> GetStoreCategories([FromBody] SettingGetStoreCategoriesModelInput ObjClass);
        public Task<IEnumerable<SettingGetCountryModelOutput>> GetCountry([FromBody] SettingGetCountryModelInput ObjClass);
        public Task<IEnumerable<SettingGetStateModelOutput>> GetState([FromBody] SettingGetStateModelInput ObjClass);
        public Task<IEnumerable<SettingGetSBUModelOutput>> GetSBU([FromBody] SettingGetSBUModelInput ObjClass);
        public Task<IEnumerable<SettingGetRoleModelOutput>> GetRole([FromBody] SettingGetRoleModelInput ObjClass);
        public Task<IEnumerable<SettingGetProductModelOutput>> GetProduct([FromBody] SettingGetProductModelInput ObjClass);
        public Task<IEnumerable<SettingGetEntityTypesModelOutput>> GetEntityTypes([FromBody] SettingGetEntityTypesModelInput ObjClass);
    }
}
