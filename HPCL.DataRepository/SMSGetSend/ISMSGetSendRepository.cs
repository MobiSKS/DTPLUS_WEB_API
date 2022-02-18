using HPCL.DataModel.SMSGetSend;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.SMSGetSend
{
    public interface ISMSGetSendRepository
    {
        public Task<IEnumerable<SMSGetOutputModel>> GetSMSTemplate([FromBody] SMSGetInputModel ObjClass);

        public Task<IEnumerable<SMSSendOutputModel>> SendSMSTemplate([FromBody] SMSSendInputModel ObjClass);

        public Task<IEnumerable<InsertSMSTextEntryOutputModel>> InsertSMSTextEntry([FromBody] InsertSMSTextEntryInputModel ObjClass);
    }
}
