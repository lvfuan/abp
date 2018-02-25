using System.Collections.Generic;

namespace AbpCoreProjrct.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
