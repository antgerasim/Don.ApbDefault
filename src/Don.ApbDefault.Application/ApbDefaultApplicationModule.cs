using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.ApbDefault.Authorization;

namespace Don.ApbDefault
{
    [DependsOn(
        typeof(ApbDefaultCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ApbDefaultApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ApbDefaultAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(ApbDefaultApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}