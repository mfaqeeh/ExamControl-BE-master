using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ExamControl.Authorization;

namespace ExamControl
{
    [DependsOn(
        typeof(ExamControlCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ExamControlApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ExamControlAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ExamControlApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
