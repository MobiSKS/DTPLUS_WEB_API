using HPCL.DataModel.Login;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Login
{
    public interface ILoginRepository
    {
        public Task<IEnumerable<GetLoginModelOutput>> GetLogin([FromBody] GetLoginModelInput ObjClass);
        public Task<IEnumerable<GetMenuDetailsForUserModelOutput>> GetMenuDetailsForUser([FromBody] GetMenuDetailsForUserModelInput ObjClass);
    }
}
