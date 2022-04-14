﻿using HPCL.DataModel.RegionalOffice;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.RegionalOffice
{
    public interface IRegionalOfficeRepository
    {
        public Task<IEnumerable<GetRegionalOfficeModelOutput>> GetRegionalOffice([FromBody] GetRegionalOfficeModelInput ObjClass);

        public Task<IEnumerable<DeleteRegionalOfficeModelOutput>> DeleteRegionalOffice([FromBody] DeleteRegionalOfficeModelInput ObjClass);

        public Task<IEnumerable<GetRegionalOfficeModelOutput>> GetRegionalOfficeByMultipleZone([FromBody] GetRegionalOfficebyMultipleZoneModelInput ObjClass);
    }
}
