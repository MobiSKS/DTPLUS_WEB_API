using HPCL.DataModel.SMSGetSend;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.SMSGetSend
{
    public interface ISMSGetSendRepository
    {
        public Task<IEnumerable<SMSGetOutputModel>> GetSMSTemplate([FromBody] SMSGetInputModel ObjClass);
    }
}
