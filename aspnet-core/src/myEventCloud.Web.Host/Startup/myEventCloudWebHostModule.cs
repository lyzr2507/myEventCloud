using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myEventCloud.Configuration;

namespace myEventCloud.Web.Host.Startup
{
    [DependsOn(
       typeof(myEventCloudWebCoreModule))]
    public class myEventCloudWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public myEventCloudWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(myEventCloudWebHostModule).GetAssembly());
        }
    }
}
