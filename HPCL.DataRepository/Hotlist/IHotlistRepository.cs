using HPCL.DataModel.Hotlist;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Hotlist
{
    public interface IHotlistRepository
    {
        public Task<IEnumerable<GetActionListOutput>> GetActionList([FromBody] GetActionListInput ObjClass);

        public Task<IEnumerable<GetEntityTypeListOutput>> GetEntityTypeList([FromBody] GetEntityTypeListInput ObjClass);


        public Task<IEnumerable<GetReasonListForEntitiesOutput>> GetReasonListForEntities([FromBody] GetReasonListForEntitiesInput ObjClass);
    }
}
