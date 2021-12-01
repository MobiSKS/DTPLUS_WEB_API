using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel;
using HPCL.DataModel.Settings;

namespace HPCL.DataRepository.Settings
{
    public interface ISettingsRepository
    {
        public Task<SettingGetCustomerTypeOutput> GetCustomerType([FromBody] SettingGetCustomerTypeInput ObjClass);
        public Task<SettingGetCustomerSubTypeOutput> GetCustomerSubType([FromBody] SettingGetCustomerSubTypeInput ObjClass);
        public Task<SettingGetHQModelOutput> GetHQ([FromBody] SettingGetHQModelInput ObjClass);
        public Task<SettingGetZoneOutput> GetGetZone([FromBody] SettingGetZoneInput ObjClass);
    }
}
