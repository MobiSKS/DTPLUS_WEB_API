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
    
    }
}
