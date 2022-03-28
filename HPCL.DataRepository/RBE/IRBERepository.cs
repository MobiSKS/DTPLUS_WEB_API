using HPCL.DataModel.RBE;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.RBE
{
    public interface IRBERepository
    {
        public Task<IEnumerable<ChangeRBEMappingModelOutput>> ChangeRBEMapping([FromBody] ChangeRBEMappingModelInput ObjClass);

        public Task<IEnumerable<ManageRBEUserModelOutput>> ManageRBEUser([FromBody] ManageRBEUserModelInput ObjClass);
    }
}
