using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Officer;

namespace HPCL.DataRepository.Officer
{
    public interface IOfficerRepository
    {
        public Task<IEnumerable<OfficerInsertModelOutput>> InsertOfficer([FromBody] OfficerInsertModelInput ObjClass);
        public Task<IEnumerable<GetOfficerModelOutput>> GetOfficerDetail([FromBody] GetOfficerModelInput ObjClass);
        public Task<IEnumerable<OfficerUpdateModelOutput>> UpdateOfficer([FromBody] OfficerUpdateModelInput ObjClass);
        public Task<IEnumerable<DeleteOfficerModelOutput>> DeleteOfficer([FromBody] DeleteOfficerModelInput ObjClass);
    }
}
