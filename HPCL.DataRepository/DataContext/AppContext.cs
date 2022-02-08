using HPCL.DataModel;
using Microsoft.EntityFrameworkCore;

namespace HPCL.DataRepository.DataContext
{
    public class HPCLAppContext : DbContext
    {
        public HPCLAppContext() { }
        public HPCLAppContext(DbContextOptions<HPCLAppContext> options) : base(options) { }


        public DbSet<BaseClass> TodoItems { get; set; } = null!;


    }
}
