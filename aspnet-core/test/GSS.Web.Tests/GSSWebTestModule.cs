using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GSS.EntityFrameworkCore;
using GSS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GSS.Web.Tests
{
    [DependsOn(
        typeof(GSSWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GSSWebTestModule : AbpModule
    {
        public GSSWebTestModule(GSSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GSSWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GSSWebMvcModule).Assembly);
        }
    }
}