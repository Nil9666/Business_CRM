using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace WizeTech_Business_CRM.Localization
{
    public static class WizeTech_Business_CRMLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(WizeTech_Business_CRMConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(WizeTech_Business_CRMLocalizationConfigurer).GetAssembly(),
                        "WizeTech_Business_CRM.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
