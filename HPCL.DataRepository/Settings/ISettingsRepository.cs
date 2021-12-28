using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Settings;

namespace HPCL.DataRepository.Settings
{
    public interface ISettingsRepository
    {
        public Task<SettingGetCustomerTypeModelOutput> GetCustomerType([FromBody] SettingGetCustomerTypeModelInput ObjClass);
        public Task<SettingGetCustomerSubTypeModelOutput> GetCustomerSubType([FromBody] SettingGetCustomerSubTypeModelInput ObjClass);
        public Task<SettingGetHQModelOutput> GetHQ([FromBody] SettingGetHQModelInput ObjClass);
        public Task<SettingGetZoneModelOutput> GetZone([FromBody] SettingGetZoneModelInput ObjClass);
        public Task<SettingGetRegionModelOutput> GetRegion([FromBody] SettingGetRegionModelInput ObjClass);
        public Task<SettingGetSalesareaModelOutput> GetSalesarea([FromBody] SettingGetSalesareaModelInput ObjClass);
        public Task<SettingGetTransactionTypeModelOutput> GetTransactionType([FromBody] SettingGetTransactionTypeModelInput ObjClass);
        public Task<SettingGetStoreCategoriesModelOutput> GetStoreCategories([FromBody] SettingGetStoreCategoriesModelInput ObjClass);
        public Task<SettingGetCountryModelOutput> GetCountry([FromBody] SettingGetCountryModelInput ObjClass);
        public Task<SettingGetStateModelOutput> GetState([FromBody] SettingGetStateModelInput ObjClass);
        public Task<SettingGetSBUModelOutput> GetSBU([FromBody] SettingGetSBUModelInput ObjClass);
        public Task<SettingGetRoleModelOutput> GetRole([FromBody] SettingGetRoleModelInput ObjClass);
        public Task<SettingGetProductModelOutput> GetProduct([FromBody] SettingGetProductModelInput ObjClass);
        public Task<SettingGetEntityTypesModelOutput> GetEntityTypes([FromBody] SettingGetEntityTypesModelInput ObjClass);
    }
}
