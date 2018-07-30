using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Iodine.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<IodineDbContext>
    {
        public IodineDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder();
            optionBuilder.UseSqlite("DataSource=db.sqlite");
            return new IodineDbContext(optionBuilder.Options);
        }
    }
}
