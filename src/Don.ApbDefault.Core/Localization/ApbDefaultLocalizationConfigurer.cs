using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Don.ApbDefault.Localization
{
    public static class ApbDefaultLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ApbDefaultConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ApbDefaultLocalizationConfigurer).GetAssembly(),
                        "Don.ApbDefault.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}