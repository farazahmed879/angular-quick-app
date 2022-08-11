using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GSS.Authorization;

namespace GSS
{
    [DependsOn(
        typeof(GSSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GSSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GSSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GSSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
