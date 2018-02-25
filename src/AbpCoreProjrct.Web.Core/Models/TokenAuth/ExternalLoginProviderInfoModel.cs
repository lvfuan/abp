using Abp.AutoMapper;
using AbpCoreProjrct.Authentication.External;

namespace AbpCoreProjrct.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
