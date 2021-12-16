using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.UploadDocument;

namespace HPCL.DataRepository.UploadDocument
{
    public interface IUploadDocumentRepository
    {
        public Task<object> User_Login([FromBody] UploadDocumentModel ObjUser);
    }
}
