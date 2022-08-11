using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GSS.EntityFrameworkCore
{
    public static class GSSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GSSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GSSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
