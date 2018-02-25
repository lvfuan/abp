using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpCoreProjrct.Localization
{
    public static class AbpCoreProjrctLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpCoreProjrctConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpCoreProjrctLocalizationConfigurer).GetAssembly(),
                        "AbpCoreProjrct.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
