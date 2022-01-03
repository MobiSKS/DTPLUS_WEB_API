using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Officer;

namespace HPCL.DataRepository.Officer
{
    public interface IOfficerRepository
    {
        public Task<IEnumerable<OfficerInsertModelOutput>> InsertOfficer([FromBody] OfficerInsertModelInput ObjClass);
    }
}
