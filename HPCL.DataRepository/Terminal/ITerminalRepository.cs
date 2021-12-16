using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.Terminal;

namespace HPCL.DataRepository.Terminal
{
    public interface ITerminalRepository
    {
        public Task<object> User_Login([FromBody] TerminalModel ObjUser);
    }
}
