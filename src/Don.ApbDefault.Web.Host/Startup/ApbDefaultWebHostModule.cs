using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.ApbDefault.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Don.ApbDefault.Web.Host.Startup
{
    [DependsOn(
       typeof(ApbDefaultWebCoreModule))]
    public class ApbDefaultWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ApbDefaultWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ApbDefaultWebHostModule).GetAssembly());
        }
    }
}
