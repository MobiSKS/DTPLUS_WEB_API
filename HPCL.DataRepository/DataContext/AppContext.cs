using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPCL.DataModel;

namespace HPCL.DataRepository.DataContext
{
    public class HPCLAppContext : DbContext
    {
        public HPCLAppContext() { }
        public HPCLAppContext(DbContextOptions<HPCLAppContext> options) : base(options) { }


        public DbSet<BaseClass> TodoItems { get; set; } = null!;


    }
}
