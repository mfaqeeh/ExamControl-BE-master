using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ExamControl.Configuration;
using ExamControl.Web;

namespace ExamControl.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ExamControlDbContextFactory : IDesignTimeDbContextFactory<ExamControlDbContext>
    {
        public ExamControlDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ExamControlDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ExamControlDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ExamControlConsts.ConnectionStringName));

            return new ExamControlDbContext(builder.Options);
        }
    }
}
