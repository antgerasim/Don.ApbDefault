using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.ApbDefault.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Don.ApbDefault.Web.Startup
{
    [DependsOn(typeof(ApbDefaultWebCoreModule))]
    public class ApbDefaultWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ApbDefaultWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ApbDefaultNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ApbDefaultWebMvcModule).GetAssembly());
        }
    }
}