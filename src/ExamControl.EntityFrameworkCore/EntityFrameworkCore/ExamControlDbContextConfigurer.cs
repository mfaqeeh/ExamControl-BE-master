using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ExamControl.EntityFrameworkCore
{
    public static class ExamControlDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ExamControlDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ExamControlDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
