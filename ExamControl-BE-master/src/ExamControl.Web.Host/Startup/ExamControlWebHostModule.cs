using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ExamControl.Configuration;

namespace ExamControl.Web.Host.Startup
{
    [DependsOn(
       typeof(ExamControlWebCoreModule))]
    public class ExamControlWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ExamControlWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ExamControlWebHostModule).GetAssembly());
        }
    }
}
