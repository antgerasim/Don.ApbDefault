using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using Don.ApbDefault.Configuration;
using Don.ApbDefault.EntityFrameworkCore;
using Don.ApbDefault.Migrator.DependencyInjection;

namespace Don.ApbDefault.Migrator
{
    [DependsOn(typeof(ApbDefaultEntityFrameworkModule))]
    public class ApbDefaultMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ApbDefaultMigratorModule(ApbDefaultEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ApbDefaultMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ApbDefaultConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ApbDefaultMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}