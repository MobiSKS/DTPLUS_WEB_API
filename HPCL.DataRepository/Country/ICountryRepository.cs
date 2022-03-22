using HPCL.DataModel.Country;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Country
{
    public interface ICountryRepository
    {
        public Task<IEnumerable<GetCountryModelOutput>> GetCountry([FromBody] GetCountryModelInput ObjClass);
    }
}
