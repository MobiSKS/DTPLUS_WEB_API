using HPCL.DataRepository.DBDapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCL.DataRepository.ConfigureAlert
{
    public class ConfigureAlertRepository:IConfigureAlertRepository
    {
        private readonly DapperContext _context;
        public ConfigureAlertRepository(DapperContext context)
        {
            _context = context;
        }

    }
}
