﻿using HPCL.DataModel.ZonalOffice;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.ZonalOffice
{
    public interface IZonalOfficeRepository
    {
        public Task<IEnumerable<GetZonalOfficeModelOutput>> GetZonalOffice([FromBody] GetZonalOfficeModelInput ObjClass);
    }
}