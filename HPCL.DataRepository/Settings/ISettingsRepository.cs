using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Settings;

namespace HPCL.DataRepository.Settings
{
    public interface ISettingsRepository
    {
        public Task<SettingGetHQModelOutput> GetHQ([FromBody] SettingGetHQModelInput ObjClass);
    }
}
