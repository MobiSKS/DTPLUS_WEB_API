using HPCL.DataModel.State;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.State
{
    public interface IStateRepository
    {
        public Task<IEnumerable<GetStateModelOutput>> GetState([FromBody] GetStateModelInput ObjClass);
    }
}
