using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myEventCloud.Authorization;

namespace myEventCloud
{
    [DependsOn(
        typeof(myEventCloudCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class myEventCloudApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<myEventCloudAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(myEventCloudApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
