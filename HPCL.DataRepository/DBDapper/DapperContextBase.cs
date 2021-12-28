using Dapper;
using System;
using System.Data;

namespace HPCL.DataRepository.DBDapper
{
    public class DapperContextBase
    {

        public int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            if (sp is null)
            {
                throw new ArgumentNullException(nameof(sp));
            }

            if (parms is null)
            {
                throw new ArgumentNullException(nameof(parms));
            }

            throw new NotImplementedException();
        }
    }
}