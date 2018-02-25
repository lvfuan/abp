using Microsoft.AspNetCore.Antiforgery;
using AbpCoreProjrct.Controllers;

namespace AbpCoreProjrct.Web.Host.Controllers
{
    public class AntiForgeryController : AbpCoreProjrctControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
