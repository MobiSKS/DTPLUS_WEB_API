using HPCL.DataModel.ConfigureAlert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.ConfigureAlert
{
    public interface IConfigureAlertRepository
    {
        public Task<GetSmsAlertForMultipleMobileDetailModelOutput> GetSmsAlertForMultipleMobile([FromBody] GetSmsAlertForMultipleMobileDetailModelInput ObjClass);
        public Task<IEnumerable<UpdateSmsAlertForMultipleMobileDetailModelOutput>> UpdateSmsAlertForMultipleMobileDetail([FromBody] UpdateSmsAlertForMultipleMobileDetailModelinput ObjClass);
        public Task<IEnumerable<DeleteSmsAlertForMultipleMobileDetailModelOutput>> DeleteSmsAlertForMultipleMobileDetail([FromBody] DeleteSmsAlertForMultipleMobileDetailModelInput ObjClass);

        public Task<IEnumerable<ConfigureAlertGetConfigureSMSAlertsDetailsByCustomerIDModelOutput>> GetConfigureSMSAlertsDetailsByCustomerID([FromBody] ConfigureAlertGetConfigureSMSAlertsDetailsByCustomerIDModelInput ObjClass);

        public Task<IEnumerable<UpdateConfigureSMSAlertsModelOutput>> UpdateConfigureSMSAlerts([FromBody] UpdateConfigureSMSAlertsModelInput ObjClass);

        public Task<IEnumerable<GetConfigureEmailAlertsOutput>> GetConfigureEmailAlerts([FromBody] GetConfigureEmailAlertsModelInput ObjClass);

        public Task<IEnumerable<UpdateConfigureEmailAlertModelOutput>> UpdateConfigureEmailAlert([FromBody] UpdateConfigureEmailAlertModelInput ObjClass);
    }
}
