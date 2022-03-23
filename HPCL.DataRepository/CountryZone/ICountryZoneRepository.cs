using HPCL.DataModel.CountryZone;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.CountryZone
{
    public interface ICountryZoneRepository
    {
        public Task<IEnumerable<GetCountryZoneModelOutput>> GetCountryZone([FromBody] GetCountryZoneModelInput ObjClass);

        public Task<IEnumerable<DeleteCountryZoneModelOutput>> DeleteCountryZone([FromBody] DeleteCountryZoneModelInput ObjClass);
    }
}
