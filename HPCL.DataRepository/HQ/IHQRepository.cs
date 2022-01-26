﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using HPCL.DataModel.HQ;

namespace HPCL.DataRepository.HQ
{
    public interface IHQRepository
    {
        public Task<IEnumerable<InsertHQModelOutput>> InsertHQ([FromBody] InsertHQModelInput ObjClass);
        public Task<IEnumerable<GetHQModelOutput>> GetHQ([FromBody] GetHQModelInput ObjClass);
        public Task<IEnumerable<UpdateHQModelOutput>> UpdateHQ([FromBody] UpdateHQModelInput ObjClass);
        public Task<IEnumerable<DeleteHQModelOutput>> DeleteHQ([FromBody] DeleteHQModelInput ObjClass);
    }
}