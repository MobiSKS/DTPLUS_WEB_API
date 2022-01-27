using HPCL.DataModel.RegionalOffice;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.RegionalOffice
{
    public interface IRegionalOfficeRepository
    {
        public Task<IEnumerable<GetRegionalOfficeModelOutput>> GetRegionalOffice([FromBody] GetRegionalOfficeModelInput ObjClass);
    }
}
