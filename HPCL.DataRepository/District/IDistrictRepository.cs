using HPCL.DataModel.District;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.District
{
    public interface IDistrictRepository
    {
        public Task<IEnumerable<GetDistrictModelOutput>> GetDistrict([FromBody] GetDistrictModelInput ObjClass);
    }
}
